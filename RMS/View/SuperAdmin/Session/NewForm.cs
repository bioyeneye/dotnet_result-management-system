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
using RMS.ViewHelper;
using Telerik.WinControls;

namespace RMS.View.SuperAdmin.Session
{
    public partial class NewForm : Telerik.WinControls.UI.RadForm
    {
        public bool IsEdit { get; set; }
        public int Id { get; set; }
        public SectionItem SectionItem { get; set; }
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ISectionService SectionService => Program.container.GetInstance<ISectionService>();

        public NewForm()
        {
            InitializeComponent();

        }


        private void NewForm_Load(object sender, EventArgs e)
        {
            var levels = LevelService.GetCount().OrderBy(c => c.Id);
            ddLevel.DataSource = levels.ToList().Select(c => c.Name);

            if (IsEdit)
            {
                SectionItem = SectionService.GetItem(Id);
                txtName.Text = SectionItem.Name;
                cmbIsActive.Checked = SectionItem.IsActive;
                ddLevel.SelectedIndex = ((IEnumerable<dynamic>)ddLevel.DataSource).ToList().IndexOf(SectionItem.LevelName);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModel();
        }

        private void ResetModel()
        {
            txtName.Clear();
            cmbIsActive.Checked = false;
            ddLevel.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TextHelper.ContainsValue(new List<string>
            {
                txtName.Text
            }))
            {
                lblError.Text = @"Ensure fields are filled";
                return;
            }

            var model = new SectionModel()
            {
                Name = txtName.Text,
                IsActive = cmbIsActive.Checked,
                LevelId = LevelService.GetLevelId((string)ddLevel.SelectedValue).Id,
                CreatedAt = DateTime.UtcNow,
            };

            if (IsEdit)
            {
                model.Id = Id;
            }

            if (SectionService.LevelExit(model))
            {
                lblError.Text = @"Session with level exist";
                return;
            }

            if (!IsEdit)
            {
                SectionService.Create(model, 0);
                lblError.Text = @"Session saved successfully";
                ResetModel();
            }
            else
            {
                SectionService.Update(model, 0);
                lblError.Text = @"Sesseion upadated successfully";
            }
        }

    }
}
