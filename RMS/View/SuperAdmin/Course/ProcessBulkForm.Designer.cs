namespace RMS.View.SuperAdmin.Course
{
    partial class ProcessBulkForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnDownloadTemplate = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new Telerik.WinControls.UI.RadButton();
            this.ddLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.beCourseTemplate = new Telerik.WinControls.UI.RadBrowseEditor();
            this.gridCourse = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCourseTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Location = new System.Drawing.Point(14, 10);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(118, 35);
            this.btnDownloadTemplate.TabIndex = 0;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.beCourseTemplate);
            this.radGroupBox1.Controls.Add(this.lblError);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.btnUpload);
            this.radGroupBox1.Controls.Add(this.ddLevel);
            this.radGroupBox1.Controls.Add(this.label7);
            this.radGroupBox1.Controls.Add(this.ddlSemester);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.HeaderText = "Upload Guide";
            this.radGroupBox1.Location = new System.Drawing.Point(14, 49);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(723, 134);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Upload Guide";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(11, 46);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 22;
            this.lblError.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 9F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Note: Kindly select the desired option from the drop downs, the right semester an" +
    "d level.";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(643, 76);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(69, 28);
            this.btnUpload.TabIndex = 20;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddLevel.Location = new System.Drawing.Point(223, 81);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(205, 20);
            this.ddLevel.TabIndex = 19;
            this.ddLevel.Text = "radDropDownList1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Level: ";
            // 
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(12, 81);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(205, 20);
            this.ddlSemester.TabIndex = 17;
            this.ddlSemester.Text = "radDropDownList1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Semester:";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Lato Black", 7.5F);
            this.lblFolderName.ForeColor = System.Drawing.Color.Navy;
            this.lblFolderName.Location = new System.Drawing.Point(12, 49);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(0, 12);
            this.lblFolderName.TabIndex = 22;
            // 
            // beCourseTemplate
            // 
            this.beCourseTemplate.Location = new System.Drawing.Point(434, 81);
            this.beCourseTemplate.Name = "beCourseTemplate";
            this.beCourseTemplate.Size = new System.Drawing.Size(203, 20);
            this.beCourseTemplate.TabIndex = 23;
            // 
            // gridCourse
            // 
            this.gridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourse.Location = new System.Drawing.Point(14, 189);
            // 
            // 
            // 
            this.gridCourse.MasterTemplate.PageSize = 50;
            this.gridCourse.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(726, 384);
            this.gridCourse.TabIndex = 23;
            this.gridCourse.ThemeName = "TelerikMetro";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radButton1.Location = new System.Drawing.Point(14, 579);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(69, 27);
            this.radButton1.TabIndex = 24;
            this.radButton1.Text = "Proceed...";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select File: ";
            // 
            // ProcessBulkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 606);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.gridCourse);
            this.Controls.Add(this.lblFolderName);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnDownloadTemplate);
            this.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.Name = "ProcessBulkForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Bulk Course";
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCourseTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnDownloadTemplate;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnUpload;
        private Telerik.WinControls.UI.RadDropDownList ddLevel;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFolderName;
        private Telerik.WinControls.UI.RadBrowseEditor beCourseTemplate;
        private Telerik.WinControls.UI.RadGridView gridCourse;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label2;
    }
}
