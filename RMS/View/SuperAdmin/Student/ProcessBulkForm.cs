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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model.ViewModel;
using RMS.Model;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using RMS.ViewHelper;

namespace RMS.View.SuperAdmin.Student
{
    public partial class ProcessBulkForm : Telerik.WinControls.UI.RadForm
    {
        public List<StudentTemplateDownloadModel> StudentTemplateDownloadModels { get; set; }
        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ListForm));
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();


        public ProcessBulkForm()
        {
            InitializeComponent();

            int page = 1;
            int count = 5;
            ((PagingPanelElement)(gridCourse.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumericButtonsCount = 5;
            gridCourse.MasterTemplate.EnableFiltering = true;
            gridCourse.MasterTemplate.EnablePaging = true;
            gridCourse.BestFitColumns(BestFitColumnMode.AllCells);
            gridCourse.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridCourse.AutoExpandGroups = true;
        }

        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            lblFolderName.Text = "";
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Select folder to save the template",
                ShowNewFolderButton = true,
            })
            {
                var csv = new CsvExport<StudentTemplateDownloadModel>(new List<int>() { 0, 1, 2, 3, 4 },
                    new List<StudentTemplateDownloadModel>());

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.Combine(folderBrowserDialog.SelectedPath, "student.csv");
                    csv.ExportToFile(path);
                    lblFolderName.Text = $@"Student template saved to : {folderBrowserDialog.SelectedPath}";
                }
            }
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
                    lblError.Text = @"Student data is not selected";
                    return;
                }

                var dataRows = FileHelper.GetDataFromFile(beCourseTemplate.Value);
                var models = new List<StudentTemplateDownloadModel>();

                var rowIndex = 2;
                foreach (var row in dataRows)
                {
                    try
                    {
                        var institutionModel = new StudentTemplateDownloadModel()
                        {
                            Email = row["Email"].ToString(),
                            MatricNumber = row["Student"].ToString(),
                            PhoneNumber = row["PhoneNumber"].ToString(),
                            OtherName = row["OtherName"].ToString(),
                            Surname = row["Surname"].ToString(),
                        };
                        models.Add(institutionModel);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                gridCourse.DataSource = models;
                StudentTemplateDownloadModels = models;
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
                              $"Number of data: {StudentTemplateDownloadModels.Count}{Environment.NewLine}" +
                              $"Do you want to continue with the process?";

                var title = "Student bulk details";

                var dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult != DialogResult.Yes)
                {
                    MessageBox.Show("Correct any data and process again ", "Saving Process Aborted", MessageBoxButtons.OK);
                    return;
                }

                var models = StudentTemplateDownloadModels.Select(c => new AspNetUserModel()
                {
                    CreatedAt = DateTime.Now,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    FirstName = c.Surname,
                    LastName = c.OtherName,
                    UserName = c.Email,
                    Password = c.Surname + c.Email,
                    RoleName = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student),
                    MatricNumber = c.MatricNumber
                }).ToList();

                var ids = AspNetUserService.CreateBulk(models);

                foreach (var id in ids)
                {
                    var authContext = new ApplicationDbContext();
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(authContext));
                    userManager.AddToRole(id, Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student));
                }

                var completeProcessResult = MessageBox.Show($@"{StudentTemplateDownloadModels.Count} student saved, reload the student list view", "Process result", MessageBoxButtons.OK);
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
