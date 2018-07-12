using System;
using System.Windows.Forms;
using RMS.View.Admin.Result;
using RMS.View.Admin.Result.Process;
using RMS.View.Admin.Result.View;
using RMS.View.Reporting;
using Telerik.WinControls;

namespace RMS.View.Admin
{
    public partial class EoMainForm : Telerik.WinControls.UI.RadRibbonForm
    {
        public EoMainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void EoMainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnResultSingleStudent_Click(object sender, EventArgs e)
        {
            ShowChild(new SingleStudentSemesterResult(), this);
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
            ActivateMdiChild(listForm);
            ThemeResolutionService.ApplyThemeToControlTree(listForm, ThemeName);
            listForm.Show();
        }

        private void btnResultSingleSemester_Click(object sender, EventArgs e)
        {
           ShowChildDialog(new SingleStudentCourseResult());
        }

        private void ShowChildDialog(Form listForm)
        {
            listForm.StartPosition = FormStartPosition.CenterScreen;
            ThemeResolutionService.ApplyThemeToControlTree(listForm, ThemeName);
            listForm.ShowDialog();
        }

        private void btnResultStudentsCourse_Click(object sender, EventArgs e)
        {
            ShowChild(new AllStudentCourseResult(), this);
        }

        private void menuViewResultPerCourse_Click(object sender, EventArgs e)
        {
            ShowChild(new AllSingleCourse(), this);
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            ShowChild(new AllCourseStudent(), this);
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            ShowChild(new SuperAdmin.Student.ListForm(), this);
        }

        private void btnPerSemesterNonBulk_Click(object sender, EventArgs e)
        {
            ShowChild(new PerSemesterNonBulk(), this);
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            ShowChild(new ReportingPractise(), this);
        }
    }
}
