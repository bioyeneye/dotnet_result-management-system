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
using RMS.View.Admin.Result.Process;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.Admin.Result.View
{
    public partial class AllCourseStudent : Telerik.WinControls.UI.RadForm
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
            log4net.LogManager.GetLogger(typeof(AllCourseStudent));
        public AllCourseStudent()
        {
            InitializeComponent();

            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddlLevel.DataSource = levels.Select(c => c.Name);

            gridSingleStudentResult.Enabled = false;

            ddlMatricNumber.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .Select(c => c.MatricNumber);

            ddlLevel.SelectedIndexChanged += (sender, args) => { LevelId = LevelService.GetLevelId((string)ddlLevel.SelectedValue).Id; };
            ddlSemester.SelectedIndexChanged += (sender, args) =>
            {
                SemesterId = SemesterService.GetSemesterId((string) ddlSemester.SelectedValue);
            };
            ddlMatricNumber.SelectedIndexChanged += (sender, args) => { Student = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue); };
        }

        private void ddLevel_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            LevelId = LevelService.GetLevelId((string)ddlLevel.SelectedValue).Id;
        }

        private void ddlSemester_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                LevelId = LevelService.GetLevelId((string)ddlLevel.SelectedValue).Id;
                SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
                Student = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue);
                List<ResultSingleStudentTemplateDownloadModel> forSemester = ResultService.GetStudentResultForSemester(Student.Id, LevelId, SemesterId);

                gridSingleStudentResult.DataSource = forSemester;
                gridSingleStudentResult.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                this.ShowMessageBox($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }
        }

        private void btnEnableForEdit_Click(object sender, EventArgs e)
        {
            btnEnableForEdit.Text = gridSingleStudentResult.Enabled ? "Enable for edit" : "Disable for edit";
            gridSingleStudentResult.Enabled = !gridSingleStudentResult.Enabled;
            btnSave.Enabled = gridSingleStudentResult.Enabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (List<ResultSingleStudentTemplateDownloadModel>)gridSingleStudentResult.DataSource;
                var oldResult = ResultService.GetStudentResultForSemester(Student.Id, LevelId, SemesterId);

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


                        if (result != null)
                        {
                            ResultModel model = ResultService.GetByMatricNumberCourseCode(Student.MatricNumber, result.CourseCode);
                            model.Score = resultSingleCourseTemplateDownloadModel.Score;

                            resultModels.Add(model);
                            message +=
                                $"{resultSingleCourseTemplateDownloadModel.CourseCode}: Old({result.Score}) - New({resultSingleCourseTemplateDownloadModel.Score})";
                        }
                    }


                    if (!string.IsNullOrWhiteSpace(message))
                    {
                        var dialogResult = this.ShowMessageBox(message, "Result to process", MessageBoxButtons.OKCancel,
                            RadMessageIcon.Info);

                        if (dialogResult == DialogResult.OK)
                        {
                            ResultService.UpdateBulk(resultModels);
                            this.ShowMessageBox($"{newData.Count} processed", "Result after processing update",
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
    }
}
