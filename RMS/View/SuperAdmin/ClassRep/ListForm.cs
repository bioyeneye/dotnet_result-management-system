using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Services;
using log4net;
using Model.ViewModel;
using RMS.Model;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RMS.View.SuperAdmin.ClassRep
{
    public partial class ListForm : RadForm
    {
        public static readonly ILog _logger =
            LogManager.GetLogger(typeof(ListForm));

        private bool canPerformOtherAction;
        private AspNetUserItem _netUser;

        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();

        public ListForm()
        {
            InitializeComponent();

            int page = 1;
            int count = 5;
            ((PagingPanelElement)(gridRep.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumericButtonsCount = 5;
            gridRep.MasterTemplate.EnableFiltering = true;
            gridRep.MasterTemplate.EnablePaging = true;
            gridRep.BestFitColumns(BestFitColumnMode.AllCells);
            gridRep.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridRep.AutoExpandGroups = true;
            gridRep.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Admin))
                .Select(c => new
                {
                    c.Email,
                    c.UserName,
                    Surname = c.FirstName,
                    OtherName = c.LastName,
                    c.PhoneNumber

                });
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRep_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var newForm = new NewForm { StartPosition = FormStartPosition.CenterScreen, Id = _netUser.Id, IsEdit = true };
                ThemeResolutionService.ApplyThemeToControlTree(newForm, ThemeName);
                newForm.ShowDialog();
                //gridRep.
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
                var message = $@"Are you sure to delete the rep with the following details: {Environment.NewLine}"
                              + $"Surname: {_netUser.FirstName}{Environment.NewLine}"
                              + $"Other Names: {_netUser.LastName}{Environment.NewLine}"
                              + $"Phone Number: {_netUser.PhoneNumber}{Environment.NewLine}";

                var result = MessageBox.Show(message, "Delete Rep", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    AspNetUserService.Delete(_netUser.Id);
                    MessageBox.Show($"Course rep deleted successfully");
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message, ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}");
            }
        }

        private void gridRep_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;

                _netUser = AspNetUserService.GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Admin)).ToList()[e.RowIndex];
                canPerformOtherAction = true;
            }
        }
    }
}
