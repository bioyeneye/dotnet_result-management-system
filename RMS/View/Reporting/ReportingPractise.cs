using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.EF;
using Model.ViewModel;
using RMS.View.Admin.Result.View;
using RMS.View.Reporting.Report;
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


        }

        private void ReportingPractise_Load(object sender, EventArgs e)
        {
            //StudentSemesterResultModel resultModel =
            this.reportViewer1.RefreshReport();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {

        }
    }
}
