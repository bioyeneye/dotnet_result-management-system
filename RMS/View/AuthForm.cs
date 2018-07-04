using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model.ViewModel;
using RMS.Controllers;
using RMS.Model;
using RMS.View.Admin;
using RMS.View.SuperAdmin;
using RMS.ViewHelper;
using Telerik.WinControls.UI;

namespace RMS.View
{
    public partial class AuthForm : RadForm
    {
        //private readonly AccountController _accountController;
        private AccountNewController _accountNewController;
        public AuthForm(AccountNewController accountControl)
        {
            _accountNewController = accountControl;
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            _accountNewController.ShowPassword(txtPassword, chkShowPassword.CheckState != CheckState.Checked);
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            LoginViewModel model = new LoginViewModel()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            if (TextHelper.ContainsValue(new List<string> {model.Username, model.Password}))
            {
                lblError.Text = @"Ensure fields are filled";
                return;
            }

            var applicationUser = _accountNewController.Authenticate(model);
            if (applicationUser == null)
            {
                lblError.Text = @"Login credential is wrong";
                return;
            }

            var role = _accountNewController.UserRole(applicationUser);

            switch (role)
            {
                case RolesConstants.Enum.SuperAdmin:
                    SuperAdminView();
                    break;

                case RolesConstants.Enum.Admin:
                    ShowAdminView();
                    break;
            }



        }

        private void SuperAdminView()
        {
            SuperAdminMainForm adminMainForm = new SuperAdminMainForm();
            adminMainForm.Show();
            Hide();
        }

        private void ShowAdminView()
        {
            var eoMainForm = new EoMainForm();
            eoMainForm.Show();
            Hide();
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
