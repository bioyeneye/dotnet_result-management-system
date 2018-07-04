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
using SimpleInjector;

namespace RMS.View.SuperAdmin.Course
{
    public partial class NewForm : Telerik.WinControls.UI.RadForm
    {
        public bool IsEdit { get; set; }
        public int Id { get; set; }
        public CourseItem CourseModel { get; set; }
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id);
            var levels = LevelService.GetCount().OrderBy(c => c.Id);
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddLevel.DataSource = levels.ToList().Select(c => c.Name);

            if (IsEdit)
            {
                CourseModel = CourseService.GetItem(Id);

                txtCode.Text = CourseModel.Code;
                txtTitle.Text = CourseModel.Title;
                nddUnit.Value = CourseModel.Unit;
                ddlSemester.SelectedIndex = ((IEnumerable<dynamic>)ddlSemester.DataSource).ToList().IndexOf(CourseModel.SemeterName);
                ddLevel.SelectedIndex = ((IEnumerable<dynamic>)ddLevel.DataSource).ToList().IndexOf(CourseModel.LevelName);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetModel();
        }

        private void ResetModel()
        {
            txtCode.Clear();
            txtTitle.Clear();
            nddUnit.Value = 0;
            ddlSemester.SelectedIndex = 0;
            ddLevel.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TextHelper.ContainsValue(new List<string>
            {
                txtCode.Text,
                txtTitle.Text
            }))
            {
                lblError.Text = @"Ensure fields are filled";
                return;
            }

            if ((nddUnit.Value % 1) != 0)
            {
                lblError.Text = @"Unit is whole number";
                return;
            }

            var model = new CourseModel()
            {
                Code = txtCode.Text,
                Title = txtTitle.Text,
                LevelId = LevelService.GetLevelId((string)ddLevel.SelectedValue).Id,
                CreatedAt = DateTime.UtcNow,
                Unit = Convert.ToInt32(nddUnit.Value),
                SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue)
            };

            var courseModelInDb = CourseService.CanSaveCourse(model.Code);
            if (courseModelInDb != null)
            {
                var msg = $@"Course with the code already exit in the db {Environment.NewLine}Code: {courseModelInDb.Code}{Environment.NewLine}";
                MessageBox.Show(msg, "Course Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsEdit)
            {
                CourseService.Create(model, 0);
                lblError.Text = @"Course saved successfully";
                ResetModel();
            }
            else
            {
                model.Id = Id;
                CourseService.Update(model, 0);
                lblError.Text = @"Course upadated successfully";
            }
           /* Close();*/
        }
    }
}
