using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.EF;
using log4net;
using Model.ViewModel;
using RMS.Extension;
using RMS.Model;
using RMS.ViewHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using PositionChangedEventArgs = Telerik.WinControls.UI.Data.PositionChangedEventArgs;

namespace RMS.View.Admin.Result.Process
{
    public partial class AllStudentCourseResult : RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public IResultService ResultService => Program.container.GetInstance<IResultService>();
        private List<ResultSingleCourseTemplateDownloadModel> _resultTemplateDownloadModels = new List<ResultSingleCourseTemplateDownloadModel>();

        public static readonly ILog _logger =
            LogManager.GetLogger(typeof(SingleStudentCourseResult));
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public int CourseId { get; set; }
        public AllStudentCourseResult()
        {
            InitializeComponent();
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddLevel.DataSource = levels.Select(c => c.Name);

            ProcessCourseDataSourse(LevelId, SemesterId);
            ddlCourse.SelectedIndexChanged += (sender, args) =>
            {
                CourseId = CourseService.GetCourseByName((string)ddlCourse.SelectedValue).Id;
            };

            btnSaveResult.Enabled = false;
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

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folderBrowserDialog = new FolderBrowserDialog
                {
                    Description = @"Select folder to save the template",
                    ShowNewFolderButton = true
                })
                {
                    var data = ResultService.DownloadReportResultSingleCourse();
                    var csv = new CsvExport<ResultSingleCourseTemplateDownloadModel>(Enumerable.Range(0, 25).ToList(), data.ToList());

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = Path.Combine(folderBrowserDialog.SelectedPath, "ResultSingleCourse.csv");
                        csv.ExportToFile(path);
                        var lblFolderName = $@"Your Single Course Result template saved successfully to :{Environment.NewLine}{folderBrowserDialog.SelectedPath}{Environment.NewLine}{Environment.NewLine}File: Name: ResultSingleCourse.csv";
                        this.ShowMessageBox(lblFolderName, @"Template Path", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                this.ShowMessageBox($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(AllStudentCourseResult)}");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                btnSaveResult.Enabled = true;
                var level = LevelService.GetLevelId((string)ddLevel.SelectedValue);

                if (level.SectionModels != null && level.SectionModels.Count > 0)
                {
                    if (TextHelper.ContainsValue(new List<string>
                    {
                        beResultTemplate.Value
                    }))
                    {
                        lblError.Text = @"Result data is not selected";
                        btnSaveResult.Enabled = false;
                        return;
                    }

                    var dataRows = FileHelper.GetDataFromFile(beResultTemplate.Value);
                    var models = new List<ResultSingleCourseTemplateDownloadModel>();

                    var rowIndex = 2;
                    foreach (var row in dataRows)
                    {
                        try
                        {
                            var institutionModel = new ResultSingleCourseTemplateDownloadModel
                            {
                                MatricNumber = row["Student"].ToString(),
                                Score = Convert.ToInt32(row["Score"].ToString() ?? "0")
                            };
                            models.Add(institutionModel);

                        }
                        catch (Exception ex)
                        {
                            btnSaveResult.Enabled = false;
                            MessageBox.Show(ex.Message);
                        }
                    }

                    gridSingleStudentResult.DataSource = models;
                    _resultTemplateDownloadModels = models;
                    gridSingleStudentResult.Enabled = true;
                    gridSingleStudentResult.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                    SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
                    LevelId = level.Id;
                    CourseId = CourseService.GetCourseByName((string)ddlCourse.SelectedValue).Id;
                }
                else
                {
                    btnSaveResult.Enabled = false;
                    this.ShowMessageBox(@"Ensure that LEVEL selected has a SESSION attached to it.", "Upload Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
            catch (Exception ex)
            {
                btnSaveResult.Enabled = false;
                _logger.Error("Error Message: " + ex.Message, ex);
                this.ShowMessageBox($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }
        }



        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                var level = LevelService.GetItem(LevelId);
                var semester = SemesterService.GetSemester(SemesterId).Name;
                var course = CourseService.GetCourse(CourseId).Code;

                if (level.SectionModels != null && level.SectionModels.Count > 0)
                {
                    var message = $@"Upload Details {Environment.NewLine}Level: {level.Name}{Environment.NewLine}Semester: {semester}{Environment.NewLine}Course: {course}{Environment.NewLine}Number of student: {_resultTemplateDownloadModels.Count}";
                    var dialogResult = this.ShowMessageBox(message, @"Data Upload Details", MessageBoxButtons.OKCancel, RadMessageIcon.Info);

                    if (dialogResult == DialogResult.OK)
                    {
                        var results = new List<ResultModel>();
                        var studentProcessed = $@"Student Processed: {Environment.NewLine}";
                        var studentInDb = $@"Student with result: {Environment.NewLine}";

                        foreach (var resultSingleStudentTemplateDownloadModel in _resultTemplateDownloadModels)
                        {
                            var studentModel = AspNetUserService.GetStudentId(resultSingleStudentTemplateDownloadModel.MatricNumber);
                            var courseModel = CourseService.GetCourse(CourseId);
                            if (string.IsNullOrWhiteSpace(resultSingleStudentTemplateDownloadModel.MatricNumber)) continue;

                            if (courseModel == null) continue;
                            var courseWithResult = ResultService.CanSaveResult(studentModel.Id, courseModel.Id);
                            if (courseWithResult != null)
                            {
                                studentInDb += $"{studentModel.MatricNumber}: {courseWithResult.Score} {Environment.NewLine}";
                                continue;
                            }

                            var result = new ResultModel
                            {
                                SectionId = level.SectionModels.FirstOrDefault().Id,
                                CourseId = courseModel.Id,
                                StudentId = studentModel.Id,
                                Score = resultSingleStudentTemplateDownloadModel.Score,
                                CreatedAt = DateTime.UtcNow
                            };
                            results.Add(result);
                            studentProcessed += $"{studentModel.MatricNumber}: {result.Score} {Environment.NewLine}";
                        }

                        ResultService.CreateBulk(results);
                        this.ShowMessageBox($@"{studentProcessed}{Environment.NewLine}{studentInDb}", @"Result Successed", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }
                else
                {
                    this.ShowMessageBox(@"Ensure that LEVEL selected has a SESSION attached to it.", "Upload Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                this.ShowMessageBox($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }
        }


    }
}
