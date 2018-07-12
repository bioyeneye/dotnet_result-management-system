using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Services;
using Microsoft.Reporting.WinForms;
using Model.ViewModel;
using RMS.Extension;
using Telerik.WinControls;

namespace RMS.View.Reporting
{
    public partial class ReportingPractise : Telerik.WinControls.UI.RadForm
    {
        public ISemesterService SemesterService => Program.container.GetInstance<ISemesterService>();
        public IAspNetUserService AspNetUserService => Program.container.GetInstance<IAspNetUserService>();
        public ILevelService LevelService => Program.container.GetInstance<ILevelService>();
        public ICourseService CourseService => Program.container.GetInstance<ICourseService>();
        public IResultService ResultService => Program.container.GetInstance<IResultService>();
        private List<ResultSingleStudentTemplateDownloadModel> _resultTemplateDownloadModels = new List<ResultSingleStudentTemplateDownloadModel>();
        public int SemesterId { get; set; }
        public int LevelId { get; set; }
        public AspNetUserModel Student { get; set; }

        public static readonly log4net.ILog _logger =
            log4net.LogManager.GetLogger(typeof(ReportingPractise));

        public ReportingPractise()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            var semesterItems = SemesterService.GetCount().OrderBy(c => c.Id).ToList();
            var levels = LevelService.GetCount().OrderBy(c => c.Id).ToList();
            ddlSemester.DataSource = semesterItems.ToList().Select(c => c.Name);
            ddlLevel.DataSource = levels.Select(c => c.Name);

            ddlMatricNumber.DataSource = AspNetUserService
                .GetCount(Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Student))
                .Select(c => c.MatricNumber);

            ddlLevel.SelectedIndexChanged += (sender, args) => { LevelId = LevelService.GetLevelId((string)ddlLevel.SelectedValue).Id; };
            ddlSemester.SelectedIndexChanged += (sender, args) =>
            {
                SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);
            };
            ddlMatricNumber.SelectedIndexChanged += (sender, args) => { Student = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue); };
            LoadDataForResult();
        }

        private void LoadDataForResult()
        {
            
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            Student = AspNetUserService.GetStudentId((string)ddlMatricNumber.SelectedValue);
            LevelId = LevelService.GetLevelId((string)ddlLevel.SelectedValue).Id;
            SemesterId = SemesterService.GetSemesterId((string)ddlSemester.SelectedValue);


            var result = ResultService.StudentSemesterResult(Student.Id, LevelId, SemesterId);
            if (result == null)
            {
                this.ShowMessageBox("Can not load result at this time, please check selected values",
                    "Error processing result", MessageBoxButtons.OK, RadMessageIcon.Error);

                return;
            }

            ReportDataSource studentDetails = new ReportDataSource("StudentDetails", new List<ReportStudentDetail>()
            {
                result.StudentDetail??new ReportStudentDetail(),
            });

            ReportDataSource reportStudentSemesterCourse = new ReportDataSource("ReportStudentSemesterCourse",
                result.SemesterCourse
            );

            ReportDataSource reportGradeDetail = new ReportDataSource("ReportGradeDetail",
                new List<ReportGradeDetail>()
                {
                    result.GradeDetail??new ReportGradeDetail(),
                }
            );


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportGradeDetail);
            reportViewer1.LocalReport.DataSources.Add(reportStudentSemesterCourse);
            reportViewer1.LocalReport.DataSources.Add(studentDetails);
            reportViewer1.RefreshReport();
        }
    }
}
