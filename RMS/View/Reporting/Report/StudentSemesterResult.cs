using System.Collections.Generic;

namespace RMS.View.Reporting.Report
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for StudentSemesterResult.
    /// </summary>
    public partial class StudentSemesterResult : Telerik.Reporting.Report
    {
        public StudentSemesterResult()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            DataSource = new List<StudentSemesterCourse>();
        }
    }
}