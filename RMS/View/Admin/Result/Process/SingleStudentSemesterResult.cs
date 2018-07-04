using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.EF;
using Model.ViewModel;
using RMS.Model;
using RMS.ViewHelper;
using Telerik.WinControls.UI;

namespace RMS.View.Admin.Result.Process
{
    public partial class SingleStudentSemesterResult : Telerik.WinControls.UI.RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public IResultService ResultService => Program.container.GetInstance<IResultService>();
        private List<ResultSingleStudentTemplateDownloadModel> _resultTemplateDownloadModels = new List<ResultSingleStudentTemplateDownloadModel>();
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public AspNetUserModel MatricNumber { get; set; }

        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(SingleStudentSemesterResult));

        public SingleStudentSemesterResult()
        {
            InitializeComponent();
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddlSemester2.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddlLevel.DataSource = levels.Select(c => c.Name);
            ddlLevel2.DataSource = levels.Select(c => c.Name);

            ddlMatricNumber.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .Select(c => c.MatricNumber);
        }

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                var level = LevelService.GetLevelId((string)ddlLevel.SelectedValue);

                if (level.SectionModels != null && level.SectionModels.Count > 0)
                {
                    var lblFolderName = "";
                    using (var folderBrowserDialog = new FolderBrowserDialog()
                    {
                        Description = @"Select folder to save the template",
                        ShowNewFolderButton = true,
                    })
                    {
                        SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
                        LevelId = level.Id;
                        var data = ResultService.DownloadReportResultSingleStudent(LevelId, SemesterId);
                        var csv = new CsvExport<ResultSingleStudentTemplateDownloadModel>(Enumerable.Range(0, 25).ToList(), data.ToList());

                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            string path = Path.Combine(folderBrowserDialog.SelectedPath, "ResultSingleStudent.csv");
                            csv.ExportToFile(path);
                            lblFolderName = $@"Your Single Student Result template saved successfully to :{Environment.NewLine}{folderBrowserDialog.SelectedPath}";
                            MessageBox.Show(lblFolderName, @"Template Path");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"Ensure that LEVEL selected has a SESSION attached to it.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                var level = LevelService.GetLevelId((string)ddlLevel2.SelectedValue);

                if (level.SectionModels != null && level.SectionModels.Count > 0)
                {
                    if (TextHelper.ContainsValue(new List<string>
                    {
                        beResultTemplate.Value
                    }))
                    {
                        lblError.Text = @"Result data is not selected";
                        return;
                    }

                    var dataRows = FileHelper.GetDataFromFile(beResultTemplate.Value);
                    var models = new List<ResultSingleStudentTemplateDownloadModel>();

                    var rowIndex = 2;
                    foreach (var row in dataRows)
                    {
                        try
                        {
                            var institutionModel = new ResultSingleStudentTemplateDownloadModel()
                            {
                                CourseCode = row["CourseCode"].ToString(),
                                Score = Convert.ToInt32(row["Score"].ToString()),
                            };
                            models.Add(institutionModel);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    gridSingleStudentResult.DataSource = models;
                    _resultTemplateDownloadModels = models;
                    MatricNumber = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue);
                    gridSingleStudentResult.Enabled = true;
                    gridSingleStudentResult.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                    SemesterId = SemesterService.GetSemesterId((string)ddlSemester2.SelectedValue);
                    LevelId = level.Id;
                }
                else
                {
                    MessageBox.Show(@"Ensure that LEVEL selected has a SESSION attached to it.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                var studentDetails = $"{MatricNumber.FirstName} {MatricNumber.LastName}({MatricNumber.MatricNumber})";
                var course = _resultTemplateDownloadModels.Aggregate("", (current, resultSingleStudentTemplateDownloadModel) => current + $"{resultSingleStudentTemplateDownloadModel.CourseCode}: {resultSingleStudentTemplateDownloadModel.Score}{Environment.NewLine}");
                var level = LevelService.GetItem(LevelId);

                if (level.SectionModels != null && level.SectionModels.Count > 0)
                {
                    var message = $@"Upload Details {Environment.NewLine}Matric Number: {studentDetails}{Environment.NewLine}{Environment.NewLine}Course{Environment.NewLine}{course}";
                    var dialogResult = MessageBox.Show(message, @"Upload Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.OK)
                    {
                        var results = new List<ResultModel>();
                        var courseProcessed = $@"Course Processed: {Environment.NewLine}";
                        var courseInDb = $@"Course with result: {Environment.NewLine}";

                        foreach (var resultSingleStudentTemplateDownloadModel in _resultTemplateDownloadModels)
                        {
                            var courseModel = CourseService.GetCourseByName(resultSingleStudentTemplateDownloadModel.CourseCode);
                            if (string.IsNullOrWhiteSpace(resultSingleStudentTemplateDownloadModel.CourseCode)) continue;

                            if(courseModel == null) continue;

                            var CourseWithResult = ResultService.CanSaveResult(MatricNumber.Id, courseModel.Id);
                            if (CourseWithResult != null)
                            {
                                courseInDb += $"{courseModel.Code}: {CourseWithResult.Score} {Environment.NewLine}";
                                continue;
                            }

                            var result = new ResultModel
                            {
                                SectionId = level.SectionModels.FirstOrDefault().Id,
                                CourseId = courseModel.Id,
                                StudentId = MatricNumber.Id,
                                Score = resultSingleStudentTemplateDownloadModel.Score,
                                CreatedAt = DateTime.UtcNow
                            };
                            results.Add(result);
                            courseProcessed += $"{courseModel.Code} {Environment.NewLine}";
                        }

                        ResultService.CreateBulk(results);
                        MessageBox.Show($@"{courseProcessed}{Environment.NewLine}{courseInDb}", @"Result Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(@"Ensure that LEVEL selected has a SESSION attached to it.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }
        }
    }
}
