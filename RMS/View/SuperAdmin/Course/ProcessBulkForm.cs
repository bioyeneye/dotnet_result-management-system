using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using Model.ViewModel;
using RMS.Model;
using RMS.ViewHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.SuperAdmin.Course
{
    public partial class ProcessBulkForm : Telerik.WinControls.UI.RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public List<CourseTemplateDownloadModel> CourseTemplateDownloadModels { get; set; }
        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ListForm));
        public ProcessBulkForm()
        {
            InitializeComponent();
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id);
            var levels = LevelService.GetCount().OrderBy(c => c.Id);
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddLevel.DataSource = levels.ToList().Select(c => c.Name);

            int page = 1;
            int count = 5;
            ((PagingPanelElement)(gridCourse.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumericButtonsCount = 5;
            gridCourse.MasterTemplate.EnableFiltering = true;
            gridCourse.MasterTemplate.EnablePaging = true;
            gridCourse.BestFitColumns(BestFitColumnMode.AllCells);
            gridCourse.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridCourse.AutoExpandGroups = true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextHelper.ContainsValue(new List<string>
                {
                    beCourseTemplate.Value
                }))
                {
                    lblError.Text = @"Course data is not selected";
                    return;
                }

                var dataRows = FileHelper.GetDataFromFile(beCourseTemplate.Value);
                var models = new List<CourseTemplateDownloadModel>();

                var rowIndex = 2;
                foreach (var row in dataRows)
                {
                    try
                    {
                        var institutionModel = new CourseTemplateDownloadModel()
                        {
                            Title = row["Title"].ToString(),
                            Code = row["Code"].ToString(),
                            Unit = Convert.ToInt32(row["Unit"].ToString()),
                        };
                        models.Add(institutionModel);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                gridCourse.DataSource = models;
                CourseTemplateDownloadModels = models;
                SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
                LevelId = LevelService.GetLevelId((string)ddLevel.SelectedValue).Id;
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }


        }

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                lblFolderName.Text = "";
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
                {
                    Description = "Select folder to save the template",
                    ShowNewFolderButton = true,
                })
                {
                    var csv = new CsvExport<CourseTemplateDownloadModel>(new List<int>() { 0, 1, 2 },
                        new List<CourseTemplateDownloadModel>());

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = Path.Combine(folderBrowserDialog.SelectedPath, "course.csv");
                        csv.ExportToFile(path);
                        lblFolderName.Text = $@"Course template saved to :{Environment.NewLine}{folderBrowserDialog.SelectedPath}";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var message = $"Bulk dertails: {Environment.NewLine}" +
                              $"Number of data: {CourseTemplateDownloadModels.Count}{Environment.NewLine}" +
                              $"Level: {LevelService.GetLevel(LevelId).Name}{Environment.NewLine}" +
                              $"Semester: {SemesterService.GetSemester(SemesterId).Name}{Environment.NewLine}{Environment.NewLine}" +
                              $"Do you want to continue with the process?";

                var title = "Course bulk details";

                var dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult != DialogResult.Yes)
                {
                    MessageBox.Show("Correct any data and process again ", "Saving Process Aborted", MessageBoxButtons.OK);
                    return;
                }

                var courseProcessed = $@"Course Processed: {Environment.NewLine}";
                var courseInDb = $@"Course in db: {Environment.NewLine}";
                var models = new List<CourseModel>();
                foreach (var courseTemplateDownloadModel in CourseTemplateDownloadModels)
                {
                    var courseModel = CourseService.GetCourseByName(courseTemplateDownloadModel.Code);
                    if (string.IsNullOrWhiteSpace(courseTemplateDownloadModel.Code)) continue;

                    if (courseModel == null) continue;

                    var courseModelInDb = CourseService.CanSaveCourse(courseTemplateDownloadModel.Code);
                    if (courseModelInDb != null)
                    {
                        courseInDb += $"{courseModel.Code}{Environment.NewLine}";
                        continue;
                    }

                    var model = new CourseModel()
                    {
                        Code = courseTemplateDownloadModel.Code,
                        Unit = courseTemplateDownloadModel.Unit,
                        Title = courseTemplateDownloadModel.Title,
                        CreatedAt = DateTime.UtcNow,
                        SemesterId = SemesterId,
                        LevelId = LevelId
                    };
                    models.Add(model);
                    courseProcessed += $"{courseModel.Code} {Environment.NewLine}";
                }

                if (models.Count > 0)
                {
                    CourseService.CreateBulk(models);
                    var completeProcessResult = MessageBox.Show($@"{CourseTemplateDownloadModels.Count} courses saved, reload the course list view", "Process result", MessageBoxButtons.OK);
                    Close();
                }

                MessageBox.Show($@"{courseProcessed}{Environment.NewLine}{courseInDb}", @"Course Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }
        }
    }
}
