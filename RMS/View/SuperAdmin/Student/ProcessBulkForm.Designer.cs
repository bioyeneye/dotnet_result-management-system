namespace RMS.View.SuperAdmin.Student
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
            this.btnUpload = new Telerik.WinControls.UI.RadButton();
            this.btnDownloadTemplate = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.gridCourse = new Telerik.WinControls.UI.RadGridView();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.beCourseTemplate = new Telerik.WinControls.UI.RadBrowseEditor();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCourseTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(521, 39);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(64, 29);
            this.btnUpload.TabIndex = 20;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Location = new System.Drawing.Point(12, 25);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(118, 35);
            this.btnDownloadTemplate.TabIndex = 25;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radButton1.Location = new System.Drawing.Point(0, 427);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(69, 27);
            this.radButton1.TabIndex = 29;
            this.radButton1.Text = "Proceed...";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // gridCourse
            // 
            this.gridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourse.Location = new System.Drawing.Point(0, 95);
            // 
            // 
            // 
            this.gridCourse.MasterTemplate.PageSize = 50;
            this.gridCourse.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(600, 328);
            this.gridCourse.TabIndex = 28;
            this.gridCourse.ThemeName = "TelerikMetro";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Lato Black", 7.5F);
            this.lblFolderName.ForeColor = System.Drawing.Color.Navy;
            this.lblFolderName.Location = new System.Drawing.Point(17, 67);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(0, 12);
            this.lblFolderName.TabIndex = 27;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.btnDownloadTemplate);
            this.radGroupBox1.Controls.Add(this.beCourseTemplate);
            this.radGroupBox1.Controls.Add(this.lblError);
            this.radGroupBox1.Controls.Add(this.lblFolderName);
            this.radGroupBox1.Controls.Add(this.btnUpload);
            this.radGroupBox1.HeaderText = "Upload Guide";
            this.radGroupBox1.Location = new System.Drawing.Point(2, 7);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(598, 82);
            this.radGroupBox1.TabIndex = 30;
            this.radGroupBox1.Text = "Upload Guide";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select File: ";
            // 
            // beCourseTemplate
            // 
            this.beCourseTemplate.Location = new System.Drawing.Point(295, 43);
            this.beCourseTemplate.Name = "beCourseTemplate";
            this.beCourseTemplate.Size = new System.Drawing.Size(220, 20);
            this.beCourseTemplate.TabIndex = 23;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(293, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 22;
            this.lblError.Text = ".";
            // 
            // ProcessBulkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 458);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.gridCourse);
            this.Name = "ProcessBulkForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Student Bulk Upload";
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCourseTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnUpload;
        private Telerik.WinControls.UI.RadButton btnDownloadTemplate;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView gridCourse;
        private System.Windows.Forms.Label lblFolderName;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadBrowseEditor beCourseTemplate;
        private System.Windows.Forms.Label lblError;
    }
}
