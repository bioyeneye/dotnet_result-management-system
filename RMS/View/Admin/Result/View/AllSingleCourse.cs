using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.EF;
using log4net;
using RMS.Extension;
using RMS.View.Admin.Result.Process;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PositionChangedEventArgs = Telerik.WinControls.UI.Data.PositionChangedEventArgs;


namespace RMS.View.Admin.Result.View
{
    public partial class AllSingleCourse : Telerik.WinControls.UI.RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public IResultService ResultService => Program.container.GetInstance<IResultService>();

        public static readonly ILog _logger =
            LogManager.GetLogger(typeof(SingleStudentCourseResult));
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public int CourseId { get; set; }
        public AllSingleCourse()
        {
            InitializeComponent();
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddLevel.DataSource = levels.Select(c => c.Name);
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);

            ddLevel.SelectedIndexChanged += ddLevel_SelectedIndexChanged;
            ddlSemester.SelectedIndexChanged += ddlSemester_SelectedIndexChanged;

            LevelId = LevelService.GetLevelId((string)ddLevel.SelectedValue).Id;
            SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);

            ddlCourse.SelectedIndexChanged += (sender, args) =>
            {
                var model = CourseService.GetCourseByName((string)ddlCourse.SelectedValue);
                if (model != null)
                    CourseId = model.Id;
            };
            ProcessCourseDataSourse(LevelId, SemesterId);
            gridSingleStudentResult.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridSingleStudentResult.AllowEditRow = true;
        }

        private void ddLevel_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            LevelId = LevelService.GetLevelId((string)ddLevel.SelectedValue).Id;
            ProcessCourseDataSourse(LevelId, SemesterId);
        }

        private void ddlSemester_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
            ProcessCourseDataSourse(LevelId, SemesterId);
        }

        private void btnEnableForEdit_Click(object sender, EventArgs e)
        {
            btnEnableForEdit.Text = gridSingleStudentResult.Enabled ? "Enable for edit" : "Disable for edit";
            gridSingleStudentResult.Enabled = !gridSingleStudentResult.Enabled;
            btnSave.Enabled = gridSingleStudentResult.Enabled;

        }

        private void ProcessCourseDataSourse(int levelId, int semesterId)
        {
            var courseItem = CourseService.GetCount().Where(c => c.LevelId == levelId && c.SemesterId == semesterId).OrderBy(c => c.Id).ToList();
            ddlCourse.DataSource = courseItem.Select(c => c.Code);
            if (courseItem.Any())
            {
                CourseId = CourseService.GetCourseByName((string)ddlCourse.SelectedValue).Id;
            }
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            try
            {
                var allSingleCourse = ResultService.GetAllSingleCourse(CourseId);
                if (allSingleCourse.Any())
                {
                    gridSingleStudentResult.DataSource = allSingleCourse;
                }
                else
                {
                    this.ShowMessageBox($@"No Result for the Course yet", "Result Details", MessageBoxButtons.OKCancel, RadMessageIcon.Info);
                }

            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                this.ShowMessageBox($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(AllStudentCourseResult)}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (List<ResultSingleCourseTemplateDownloadModel>)gridSingleStudentResult.DataSource;
                var oldResult = ResultService.GetAllSingleCourse(CourseId);

                var newData = data.Except(oldResult, new ResultSingleCourseTemplateDownloadModelComparer()).ToList();

                var message = string.Empty;
                if (newData.Any())
                {
                    List<ResultModel> resultModels = new List<ResultModel>();
                    foreach (var resultSingleCourseTemplateDownloadModel in newData)
                    {
                        var result = oldResult.FirstOrDefault(c =>
                            c.MatricNumber.Equals(resultSingleCourseTemplateDownloadModel.MatricNumber,
                                StringComparison.OrdinalIgnoreCase));


                        if (result != null)
                        {
                            ResultModel model = ResultService.GetByMatricNumberCourseId(result.MatricNumber, CourseId);
                            model.Score = resultSingleCourseTemplateDownloadModel.Score;

                            resultModels.Add(model);
                            message +=
                                $"{resultSingleCourseTemplateDownloadModel.MatricNumber}: Old({result.Score}) - New({resultSingleCourseTemplateDownloadModel.Score})";
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

                            gridSingleStudentResult.DataSource = ResultService.GetAllSingleCourse(CourseId);
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
