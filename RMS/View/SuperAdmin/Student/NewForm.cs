using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model.ViewModel;
using RMS.Model;
using RMS.ViewHelper;
using Telerik.WinControls;

namespace RMS.View.SuperAdmin.Student
{
    public partial class NewForm : Telerik.WinControls.UI.RadForm
    {
        public bool IsEdit { get; set; }
        public string Id { get; set; }
        public AspNetUserItem AspNetUserItem { get; set; }
        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ListForm));
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public NewForm()
        {
            InitializeComponent();
        }

        private void ResetModel()
        {
            txtSurname.Clear();
            txtOtherName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtMatricNumber.Clear();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    AspNetUserItem = AspNetUserService.GetItem(Id);

                    txtSurname.Text = AspNetUserItem.FirstName;
                    txtOtherName.Text = AspNetUserItem.LastName;
                    txtPhoneNumber.Text = AspNetUserItem.PhoneNumber;
                    txtEmail.Text = AspNetUserItem.Email;
                    txtMatricNumber.Text = AspNetUserItem.MatricNumber;
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var listTxt = new List<string>
                {
                    txtSurname.Text,
                    txtOtherName.Text,
                    txtPhoneNumber.Text,
                    txtEmail.Text,
                    txtMatricNumber.Text
                };

                if (TextHelper.ContainsValue(listTxt))
                {
                    lblError.Text = @"Ensure fields are filled";
                    return;
                }

                if (!TextHelper.IsEmail(txtEmail.Text))
                {
                    lblError.Text = @"Email is not in correct format";
                    return;
                }

                var model = new AspNetUserModel()
                {
                    CreatedAt = DateTime.Now,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    FirstName = txtSurname.Text,
                    LastName = txtOtherName.Text,
                    UserName = txtEmail.Text,
                    Password = txtSurname.Text+txtEmail.Text,
                    RoleName = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student),
                    MatricNumber = txtMatricNumber.Text
                };

                if (!IsEdit)
                {
                    string id = "";
                    AspNetUserService.Create(model, out id);

                    var authContext = new ApplicationDbContext();
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(authContext));
                    userManager.AddToRole(id, model.RoleName);

                    lblError.Text = @"Student saved successfully";
                    ResetModel();
                }
                else
                {
                    model.Id = Id;
                    AspNetUserService.Update(model, 0);
                    lblError.Text = @"Student details upadated successfully";
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(ListForm)}");
            }
        }
    }
}
