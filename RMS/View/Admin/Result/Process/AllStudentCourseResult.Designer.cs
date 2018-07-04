namespace RMS.View.Admin.Result.Process
{
    partial class AllStudentCourseResult
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlCourse = new Telerik.WinControls.UI.RadDropDownList();
            this.ddLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beResultTemplate = new Telerik.WinControls.UI.RadBrowseEditor();
            this.btnUpload = new Telerik.WinControls.UI.RadButton();
            this.btnDownloadTemplate = new Telerik.WinControls.UI.RadButton();
            this.gridSingleStudentResult = new Telerik.WinControls.UI.RadGridView();
            this.btnSaveResult = new Telerik.WinControls.UI.RadButton();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beResultTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.lblError);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.beResultTemplate);
            this.radGroupBox1.Controls.Add(this.btnUpload);
            this.radGroupBox1.Controls.Add(this.ddLevel);
            this.radGroupBox1.Controls.Add(this.label7);
            this.radGroupBox1.Controls.Add(this.ddlSemester);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.ddlCourse);
            this.radGroupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Process Result";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 44);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(743, 88);
            this.radGroupBox1.TabIndex = 10;
            this.radGroupBox1.Text = "Process Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "Course: ";
            // 
            // ddlCourse
            // 
            this.ddlCourse.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlCourse.Location = new System.Drawing.Point(70, 56);
            this.ddlCourse.Name = "ddlCourse";
            this.ddlCourse.Size = new System.Drawing.Size(240, 20);
            this.ddlCourse.TabIndex = 35;
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddLevel.Location = new System.Drawing.Point(70, 30);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(240, 20);
            this.ddLevel.TabIndex = 40;
            this.ddLevel.Text = "radDropDownList1";
            this.ddLevel.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(24, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "Level: ";
            // 
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(414, 32);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(240, 20);
            this.ddlSemester.TabIndex = 38;
            this.ddlSemester.Text = "radDropDownList1";
            this.ddlSemester.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlSemester_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(350, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 37;
            this.label4.Text = "Semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select File: ";
            // 
            // beResultTemplate
            // 
            this.beResultTemplate.Location = new System.Drawing.Point(414, 57);
            this.beResultTemplate.Name = "beResultTemplate";
            this.beResultTemplate.Size = new System.Drawing.Size(240, 20);
            this.beResultTemplate.TabIndex = 42;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpload.Location = new System.Drawing.Point(660, 33);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(69, 40);
            this.btnUpload.TabIndex = 41;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownloadTemplate.Location = new System.Drawing.Point(12, 14);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(137, 24);
            this.btnDownloadTemplate.TabIndex = 11;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // gridSingleStudentResult
            // 
            this.gridSingleStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSingleStudentResult.Enabled = false;
            this.gridSingleStudentResult.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.gridSingleStudentResult.Location = new System.Drawing.Point(12, 138);
            // 
            // 
            // 
            this.gridSingleStudentResult.MasterTemplate.AllowAddNewRow = false;
            this.gridSingleStudentResult.MasterTemplate.AllowEditRow = false;
            this.gridSingleStudentResult.MasterTemplate.PageSize = 50;
            this.gridSingleStudentResult.MasterTemplate.ViewDefinition = tableViewDefinition7;
            this.gridSingleStudentResult.Name = "gridSingleStudentResult";
            this.gridSingleStudentResult.Size = new System.Drawing.Size(743, 294);
            this.gridSingleStudentResult.TabIndex = 12;
            this.gridSingleStudentResult.ThemeName = "TelerikMetro";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveResult.Location = new System.Drawing.Point(12, 438);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(94, 24);
            this.btnSaveResult.TabIndex = 13;
            this.btnSaveResult.Text = "Upload Result";
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Roboto", 7F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(94, 6);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 44;
            this.lblError.Text = ".";
            // 
            // AllStudentCourseResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 469);
            this.Controls.Add(this.gridSingleStudentResult);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.btnDownloadTemplate);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "AllStudentCourseResult";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Students Single Course ";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beResultTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList ddlCourse;
        private Telerik.WinControls.UI.RadDropDownList ddLevel;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadBrowseEditor beResultTemplate;
        private Telerik.WinControls.UI.RadButton btnUpload;
        private Telerik.WinControls.UI.RadButton btnDownloadTemplate;
        private Telerik.WinControls.UI.RadGridView gridSingleStudentResult;
        private Telerik.WinControls.UI.RadButton btnSaveResult;
        private System.Windows.Forms.Label lblError;
    }
}
