using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Services;
using DataAccess.EF;
using Model.ViewModel;
using RMS.Extension;
using RMS.View.Admin.Result.View;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.Admin.Result.Process
{
    public partial class PerSemesterNonBulk : Telerik.WinControls.UI.RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public IResultService ResultService => Program.container.GetInstance<IResultService>();
        private List<ResultSingleStudentTemplateDownloadModel> _resultTemplateDownloadModels = new List<ResultSingleStudentTemplateDownloadModel>();
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public AspNetUserModel Student { get; set; }

        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(PerSemesterNonBulk));
        public PerSemesterNonBulk()
        {
            InitializeComponent();

            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddlLevel.DataSource = levels.Select(c => c.Name);

            gridSingleStudentResult.Enabled = true;

            ddlMatricNumber.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .Select(c => c.MatricNumber);

            ddlLevel.SelectedIndexChanged += (sender, args) => { LevelId = LevelService.GetLevelId((string)ddlLevel.SelectedValue).Id; };
            ddlSemester.SelectedIndexChanged += (sender, args) =>
            {
                SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
            };
            ddlMatricNumber.SelectedIndexChanged += (sender, args) => { Student = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue); };
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
            var level = LevelService.GetLevelId((string)ddlLevel.SelectedValue);
            LevelId = level.Id;

            if (level.SectionModels.Any())
            {
                radGroupBox2.Enabled = true;
                var courseForResult = CourseService.GetCoursePerSemesterLevel(LevelId, SemesterId);
                gridSingleStudentResult.DataSource = courseForResult;
                gridSingleStudentResult.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                radGroupBox2.Enabled = false;
                gridSingleStudentResult.DataSource = null;
                this.ShowMessageBox(@"Ensure that LEVEL selected has a SESSION attached to it, because no result can be attached to it.", "Course Seletion", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
                var level = LevelService.GetLevelId((string)ddlLevel.SelectedValue);
                LevelId = level.Id;

                Student = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue);
                var data = (List<ResultSingleStudentTemplateDownloadModel>)gridSingleStudentResult.DataSource;
                var oldResult = ResultService.GetStudentResultForSemester(Student.Id, LevelId, SemesterId);

                var updateResult = false;
                if (oldResult.Count == data.Count)
                {
                    updateResult = true;
                    var dialog = this.ShowMessageBox(@"Student have results for this semester already, Could you like to update it.", "Result Compeletion", MessageBoxButtons.OKCancel, RadMessageIcon.Error);
                    if (dialog == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                if (oldResult.Count < data.Count)
                {
                    var dialog = this.ShowMessageBox($@"Student have {oldResult.Count} results for this semester already, could you like to save the rest.", "Result Processing", MessageBoxButtons.OKCancel, RadMessageIcon.Error);
                    if (dialog == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                var newData = data.Except(oldResult, new ResultSingleStudentTemplateDownloadModelComparer()).ToList();

                var message = string.Empty;
                if (newData.Any())
                {
                    List<ResultModel> resultModels = new List<ResultModel>();
                    foreach (var resultSingleCourseTemplateDownloadModel in newData)
                    {
                        var result = oldResult.FirstOrDefault(c =>
                            c.CourseCode.Equals(resultSingleCourseTemplateDownloadModel.CourseCode,
                                StringComparison.OrdinalIgnoreCase));

                        ResultModel model = null;
                        if (result != null)
                        {
                            if (CheckScore(resultSingleCourseTemplateDownloadModel)) return;
                            if (updateResult)
                            {
                                model = ResultService.GetByMatricNumberCourseCode(Student.MatricNumber, result.CourseCode);
                                model.Score = resultSingleCourseTemplateDownloadModel.Score;
                            }

                            if (updateResult)
                            {
                                message +=
                                    $"{resultSingleCourseTemplateDownloadModel.CourseCode}: Old({result.Score}) - New({resultSingleCourseTemplateDownloadModel.Score}){Environment.NewLine}";

                            }

                        }
                        else
                        {
                            if (CheckScore(resultSingleCourseTemplateDownloadModel)) return;

                            var cId = CourseService.GetCourseByName(resultSingleCourseTemplateDownloadModel.CourseCode).Id;
                            model = new ResultModel
                            {
                                SectionId = level.SectionModels.FirstOrDefault().Id,
                                CourseId = cId,
                                StudentId = Student.Id,
                                Score = resultSingleCourseTemplateDownloadModel.Score,
                                CreatedAt = DateTime.UtcNow
                            };

                            message +=
                                $"{resultSingleCourseTemplateDownloadModel.CourseCode}: {resultSingleCourseTemplateDownloadModel.Score}{Environment.NewLine}";

                        }

                        if (model != null)
                        {
                            resultModels.Add(model);
                        }
                    }



                    if (!string.IsNullOrWhiteSpace(message))
                    {
                        var dialogResult = this.ShowMessageBox(message, "Result to process", MessageBoxButtons.OKCancel,
                            RadMessageIcon.Info);

                        if (dialogResult == DialogResult.OK)
                        {
                            if (updateResult)
                            {
                                ResultService.UpdateBulk(resultModels);
                            }
                            else
                            {
                                ResultService.CreateBulk(resultModels);
                            }
                            this.ShowMessageBox($"{newData.Count} processed", "Result after processing",
                                MessageBoxButtons.OKCancel);

                            gridSingleStudentResult.DataSource = ResultService.GetStudentResultForSemester(Student.Id, LevelId, SemesterId);
                        }
                    }

                    return;
                }

                message = "No result to update";
                this.ShowMessageBox(message, "Update Process", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                this.ShowMessageBox($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(AllStudentCourseResult)}");
            }
        }

        private bool CheckScore(ResultSingleStudentTemplateDownloadModel resultSingleCourseTemplateDownloadModel)
        {
            if (resultSingleCourseTemplateDownloadModel.Score <= 0 || resultSingleCourseTemplateDownloadModel.Score > 100)
            {
                var dialog = this.ShowMessageBox(
                    $@"Course score cant be {
                            resultSingleCourseTemplateDownloadModel.Score
                        }, it should be in the range of 1-100, Could you like to update the value", "Result Processing",
                    MessageBoxButtons.OKCancel, RadMessageIcon.Info);
                if (dialog == DialogResult.OK)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
