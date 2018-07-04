namespace RMS.View.Reporting
{
    partial class ReportingPractise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TypeReportSource typeReportSource1 = new Telerik.Reporting.TypeReportSource();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.ddlMatricNumber = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnLoadReport = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer1.Location = new System.Drawing.Point(12, 55);
            this.reportViewer1.Name = "reportViewer1";
            typeReportSource1.TypeName = "RMS.View.Reporting.Report.StudentSemesterResult, RMS, Version=1.0.0.0, Culture=ne" +
    "utral, PublicKeyToken=null";
            this.reportViewer1.ReportSource = typeReportSource1;
            this.reportViewer1.Size = new System.Drawing.Size(930, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(282, 30);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(149, 20);
            this.ddlSemester.TabIndex = 38;
            this.ddlSemester.Text = "radDropDownList1";
            // 
            // ddlLevel
            // 
            this.ddlLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlLevel.Location = new System.Drawing.Point(55, 29);
            this.ddlLevel.Name = "ddlLevel";
            this.ddlLevel.Size = new System.Drawing.Size(149, 20);
            this.ddlLevel.TabIndex = 37;
            this.ddlLevel.Text = "radDropDownList1";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(214, 31);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(63, 18);
            this.radLabel4.TabIndex = 36;
            this.radLabel4.Text = "Semester:";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(8, 30);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(43, 18);
            this.radLabel5.TabIndex = 35;
            this.radLabel5.Text = "Level: ";
            // 
            // ddlMatricNumber
            // 
            this.ddlMatricNumber.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlMatricNumber.Location = new System.Drawing.Point(514, 31);
            this.ddlMatricNumber.Name = "ddlMatricNumber";
            this.ddlMatricNumber.Size = new System.Drawing.Size(168, 20);
            this.ddlMatricNumber.TabIndex = 34;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(443, 32);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 18);
            this.radLabel3.TabIndex = 33;
            this.radLabel3.Text = "Matric No:";
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Location = new System.Drawing.Point(687, 29);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(110, 24);
            this.btnLoadReport.TabIndex = 39;
            this.btnLoadReport.Text = "Load";
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // ReportingPractise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 507);
            this.Controls.Add(this.btnLoadReport);
            this.Controls.Add(this.ddlSemester);
            this.Controls.Add(this.ddlLevel);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.ddlMatricNumber);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportingPractise";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ReportingPractise";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.ReportingPractise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private Telerik.WinControls.UI.RadDropDownList ddlLevel;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList ddlMatricNumber;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnLoadReport;
    }
}
