using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using Microsoft.AspNet.Identity;
using Model.ViewModel;
using RMS.Model;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.SuperAdmin.Course
{
    public partial class ListForm : Telerik.WinControls.UI.RadForm
    {
        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ListForm));

        private bool canPerformOtherAction;
        private CourseItem _courseItem;

        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();

        public ListForm()
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
            gridCourse.DataSource = CourseService.GetCount().Select(c => new
            {
                CouseCode = c.Code,
                CourseTitle = c.Title,
                c.Unit,
                Level = c.LevelName,
                Semester = c.SemeterName,
                Date = c.CreatedAt.ToShortDateString(),
            });
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                throw;
            }
        }

        private void btnBulkCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new ProcessBulkForm() { StartPosition = FormStartPosition.CenterScreen };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                throw;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                newForm.IsEdit = true;
                newForm.Id = _courseItem.Id;
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                throw;
            }
        }

        private void gridCourse_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;

                _courseItem = CourseService.GetCount().ToList()[e.RowIndex];
                canPerformOtherAction = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var message = $@"Are you sure to delete the course with the following details: {Environment.NewLine}"
                              + $"Code: {_courseItem.Code}{Environment.NewLine}"
                              + $"Title: {_courseItem.Title}{Environment.NewLine}"
                              + $"Unit: {_courseItem.Unit}{Environment.NewLine}";

                var result = MessageBox.Show(message, "Delete Course", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    CourseService.Delete(_courseItem.Id);
                    MessageBox.Show($"Course deleted successfully");
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                throw;
            }
        }
    }
}
