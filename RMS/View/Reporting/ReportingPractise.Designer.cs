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
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.ddlMatricNumber = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnLoadReport = new Telerik.WinControls.UI.RadButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(286, 12);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(149, 24);
            this.ddlSemester.TabIndex = 38;
            this.ddlSemester.Text = "radDropDownList1";
            // 
            // ddlLevel
            // 
            this.ddlLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlLevel.Location = new System.Drawing.Point(59, 11);
            this.ddlLevel.Name = "ddlLevel";
            this.ddlLevel.Size = new System.Drawing.Size(149, 24);
            this.ddlLevel.TabIndex = 37;
            this.ddlLevel.Text = "radDropDownList1";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(218, 13);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 17);
            this.radLabel4.TabIndex = 36;
            this.radLabel4.Text = "Semester:";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(12, 12);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 17);
            this.radLabel5.TabIndex = 35;
            this.radLabel5.Text = "Level: ";
            // 
            // ddlMatricNumber
            // 
            this.ddlMatricNumber.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlMatricNumber.Location = new System.Drawing.Point(518, 13);
            this.ddlMatricNumber.Name = "ddlMatricNumber";
            this.ddlMatricNumber.Size = new System.Drawing.Size(168, 24);
            this.ddlMatricNumber.TabIndex = 34;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(447, 14);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 17);
            this.radLabel3.TabIndex = 33;
            this.radLabel3.Text = "Matric No:";
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Location = new System.Drawing.Point(691, 11);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(110, 24);
            this.btnLoadReport.TabIndex = 39;
            this.btnLoadReport.Text = "Load";
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RMS.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(1203, 454);
            this.reportViewer1.TabIndex = 40;
            // 
            // ReportingPractise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 507);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnLoadReport);
            this.Controls.Add(this.ddlSemester);
            this.Controls.Add(this.ddlLevel);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.ddlMatricNumber);
            this.Controls.Add(this.radLabel3);
            this.Name = "ReportingPractise";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ReportingPractise";
            this.ThemeName = "TelerikMetro";
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
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private Telerik.WinControls.UI.RadDropDownList ddlLevel;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList ddlMatricNumber;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnLoadReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
