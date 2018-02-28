using System;
using System.Windows.Forms;
using Model.ViewModel;
using RMS.Controllers;
using RMS.View.Admin;
using Telerik.WinControls.UI;

namespace RMS.View
{
    public partial class AuthForm : RadForm
    {
        private readonly AccountController _accountController;
        public AuthForm(AccountController accountControl)
        {
            _accountController = accountControl;
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            _accountController.ShowPassword(txtPassword, chkShowPassword.CheckState != CheckState.Checked);
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            var model = new UserModel
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            var result = _accountController.Authenticate(model);
            if (!result.Success)
            {
                lblError.Text = (string)result.Data;
            }
            else
            {
                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                Hide();
            }
        }

    }
}
