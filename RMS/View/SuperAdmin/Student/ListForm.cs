using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using Model.ViewModel;
using RMS.Model;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.SuperAdmin.Student
{
    public partial class ListForm : Telerik.WinControls.UI.RadForm
    {
        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ClassRep.ListForm));

        private bool canPerformOtherAction;
        private AspNetUserItem _netUser;
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();

        public ListForm()
        {
            InitializeComponent();
            int page = 1;
            int count = 5;
            ((PagingPanelElement)(gridStudent.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumericButtonsCount = 5;
            gridStudent.MasterTemplate.EnableFiltering = true;
            gridStudent.MasterTemplate.EnablePaging = true;
            gridStudent.BestFitColumns(BestFitColumnMode.AllCells);
            gridStudent.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridStudent.AutoExpandGroups = true;
            gridStudent.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .Select(c => new
                {
                    c.MatricNumber,
                    c.Email,
                    c.UserName,
                    Surname = c.FirstName,
                    OtherName = c.LastName,
                    c.PhoneNumber,

                });
        }

        private void gridStudent_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;

                _netUser = AspNetUserService.GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student)).ToList()[e.RowIndex];
                canPerformOtherAction = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen, Id = _netUser.Id, IsEdit = true };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var message = $@"Are you sure to delete the student with the following details: {Environment.NewLine}"
                              + $"Matric Number: {_netUser.MatricNumber}{Environment.NewLine}"
                              + $"Surname: {_netUser.FirstName}{Environment.NewLine}"
                              + $"Other Names: {_netUser.LastName}{Environment.NewLine}"
                              + $"Phone Number: {_netUser.PhoneNumber}{Environment.NewLine}";

                var result = MessageBox.Show(message, "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    AspNetUserService.Delete(_netUser.Id);
                    MessageBox.Show($@"Student deleted successfully");
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}");
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
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
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ClassRep.ListForm)}");
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
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }
        }
    }
}
