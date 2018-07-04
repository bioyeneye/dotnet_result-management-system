using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.EF;
using Model.ViewModel;
using RMS.Model;

namespace RMS.View.Admin.Result.Process
{
    public partial class SingleStudentCourseResult : Telerik.WinControls.UI.RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public IResultService ResultService => Program.container.GetInstance<IResultService>();
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public AspNetUserModel MatricNumber { get; set; }

        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(SingleStudentCourseResult));

        public SingleStudentCourseResult()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddLevel.DataSource = levels.Select(c => c.Name);
            ProcessCourseDataSourse(LevelId, SemesterId);

            ddlMatricNumber.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .Select(c => c.MatricNumber);

            nddScore.Value = 0;
        }

        private void SingleStudentCourseResult_Load(object sender, EventArgs e)
        {

        }

        private void ddLevel_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LevelId = LevelService.GetLevelId((string)ddLevel.SelectedValue).Id;
            ProcessCourseDataSourse(LevelId, SemesterId);
        }

        private void ddlSemester_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
            ProcessCourseDataSourse(LevelId, SemesterId);
        }

        private void ProcessCourseDataSourse(int levelId, int semesterId)
        {
            var courseItem = CourseService.GetCount().Where(c => c.LevelId == levelId && c.SemesterId == semesterId).OrderBy(c => c.Id).ToList();
            ddlCourse.DataSource = courseItem.Select(c => c.Code);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //InitializeData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (nddScore.Value <= 0)
            {
                lblError.Text = @"Score is required";
                return;
            }
            if ((nddScore.Value % 1) != 0)
            {
                lblError.Text = @"Score is whole number";
                return;
            }

            try
            {
                MatricNumber = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue);
                var studentDetails = $"{MatricNumber.FirstName} {MatricNumber.LastName}({MatricNumber.MatricNumber})";
                var level = LevelService.GetItem(LevelId);

                if (level.SectionModels != null && level.SectionModels.Count > 0)
                {
                    var message = $@"Result Details {Environment.NewLine}Matric Number: {studentDetails}{Environment.NewLine}Course: {(string)ddlCourse.SelectedValue}{Environment.NewLine}Result: {nddScore.Value}";
                    var dialogResult = MessageBox.Show(message, @"Result Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.OK)
                    {
                        var cId = CourseService.GetCourseByName((string)ddlCourse.SelectedValue).Id;
                        var courseWithResult = ResultService.CanSaveResult(MatricNumber.Id, cId);
                        if (courseWithResult != null)
                        {
                            MessageBox.Show(@"Student already have result", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var result = new ResultModel
                        {
                            SectionId = level.SectionModels.FirstOrDefault().Id,
                            CourseId = cId,
                            StudentId = MatricNumber.Id,
                            Score = int.Parse(nddScore.Value.ToString()),
                            CreatedAt = DateTime.UtcNow
                        };

                        ResultService.Create(result, 0);
                        MessageBox.Show($@"Result of {studentDetails} is saved", "Upload successfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(@"Ensure that LEVEL selected has a SESSION attached to it.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error Message: " + ex.Message.ToString(), ex);
                MessageBox.Show($@"Message: {ex.Message}{Environment.NewLine}Stack Message: {ex.StackTrace}", $@"Error Message from {typeof(SingleStudentSemesterResult)}");
            }

        }
    }
}
