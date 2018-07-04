using System;
using System.Windows.Forms;
using Model.ViewModel;
using RMS.Controllers;
using RMS.View.Admin;
using RMS.View.EO;
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
                var user = (UserModel) result.Data;
                if (!user.IsAdmin && !user.IsActiveEO)
                {
                    MessageBox.Show($@"Contact the admin of the software to authorize your acccout",
                        "Account Issue",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                if (user.IsAdmin)
                {
                    AdminMainForm adminMainForm = new AdminMainForm();
                    adminMainForm.Show();
                    Hide();
                }

                if (user.IsActiveEO)
                {
                    var eoMainForm = new EoMainForm();
                    eoMainForm.Show();
                    Hide();
                }

            }
        }

    }
}
