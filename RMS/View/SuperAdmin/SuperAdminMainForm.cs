using System;
using System.Windows.Forms;
using RMS.View.SuperAdmin.Course;
using SesionForm = RMS.View.SuperAdmin.Session;
using Telerik.WinControls;

namespace RMS.View.SuperAdmin
{
    public partial class SuperAdminMainForm : Telerik.WinControls.UI.RadRibbonForm
    {
        public SuperAdminMainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;

            ShowChild(new ListForm(), this);
        }

        private void SuperAdminMainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnListCourse_Click(object sender, System.EventArgs e)
        {
            ShowChild(new ListForm(), this);
        }

        private void ShowChild(Form listForm, Form parent)
        {
            ActiveMdiChild?.Close();
            foreach (var mdiChild in MdiChildren)
            {
                mdiChild.Close();
            }

            listForm.MdiParent = parent;
            listForm.WindowState = FormWindowState.Maximized;
            listForm.Show();
            ThemeResolutionService.ApplyThemeToControlTree(listForm, ThemeName);
            ActivateMdiChild(listForm);
        }

        private void ShowChildDialog(Form listForm)
        {
            listForm.StartPosition = FormStartPosition.CenterScreen;
            ThemeResolutionService.ApplyThemeToControlTree(listForm, ThemeName);
            listForm.ShowDialog();
        }

        public void ApplyTheme(string themeName) { this.ThemeName = themeName; ThemeResolutionService.ApplyThemeToControlTree(this, themeName); }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            ShowChildDialog(new SesionForm.ListForm());
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            ShowChild(new ClassRep.ListForm(), this);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ShowChild(new Student.ListForm(), this);
        }
    }
}

