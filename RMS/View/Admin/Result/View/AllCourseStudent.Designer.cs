namespace RMS.View.Admin.Result.View
{
    partial class AllCourseStudent
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.btnUpload = new Telerik.WinControls.UI.RadButton();
            this.ddlMatricNumber = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.gridSingleStudentResult = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnEnableForEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnableForEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(305, 25);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(149, 20);
            this.ddlSemester.TabIndex = 32;
            this.ddlSemester.Text = "radDropDownList1";
            // 
            // ddlLevel
            // 
            this.ddlLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlLevel.Location = new System.Drawing.Point(78, 24);
            this.ddlLevel.Name = "ddlLevel";
            this.ddlLevel.Size = new System.Drawing.Size(149, 20);
            this.ddlLevel.TabIndex = 31;
            this.ddlLevel.Text = "radDropDownList1";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(237, 26);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(63, 18);
            this.radLabel4.TabIndex = 30;
            this.radLabel4.Text = "Semester:";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(31, 25);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(43, 18);
            this.radLabel5.TabIndex = 29;
            this.radLabel5.Text = "Level: ";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpload.Location = new System.Drawing.Point(78, 51);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(149, 32);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Show Result";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ddlMatricNumber
            // 
            this.ddlMatricNumber.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlMatricNumber.Location = new System.Drawing.Point(537, 26);
            this.ddlMatricNumber.Name = "ddlMatricNumber";
            this.ddlMatricNumber.Size = new System.Drawing.Size(168, 20);
            this.ddlMatricNumber.TabIndex = 18;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(466, 27);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 18);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "Matric No:";
            // 
            // gridSingleStudentResult
            // 
            this.gridSingleStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSingleStudentResult.Enabled = false;
            this.gridSingleStudentResult.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.gridSingleStudentResult.Location = new System.Drawing.Point(12, 109);
            // 
            // 
            // 
            this.gridSingleStudentResult.MasterTemplate.AllowAddNewRow = false;
            this.gridSingleStudentResult.MasterTemplate.PageSize = 50;
            this.gridSingleStudentResult.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridSingleStudentResult.Name = "gridSingleStudentResult";
            this.gridSingleStudentResult.Size = new System.Drawing.Size(726, 327);
            this.gridSingleStudentResult.TabIndex = 11;
            this.gridSingleStudentResult.ThemeName = "TelerikMetro";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.ddlSemester);
            this.radGroupBox2.Controls.Add(this.ddlLevel);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.btnUpload);
            this.radGroupBox2.Controls.Add(this.ddlMatricNumber);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "Upload Section";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(726, 91);
            this.radGroupBox2.TabIndex = 14;
            this.radGroupBox2.Text = "Upload Section";
            // 
            // btnEnableForEdit
            // 
            this.btnEnableForEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnableForEdit.Location = new System.Drawing.Point(12, 442);
            this.btnEnableForEdit.Name = "btnEnableForEdit";
            this.btnEnableForEdit.Size = new System.Drawing.Size(110, 24);
            this.btnEnableForEdit.TabIndex = 12;
            this.btnEnableForEdit.Text = "Enable for edit";
            this.btnEnableForEdit.Click += new System.EventHandler(this.btnEnableForEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(128, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Update";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AllCourseStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 471);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridSingleStudentResult);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.btnEnableForEdit);
            this.Name = "AllCourseStudent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Student Semester Result";
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnableForEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private Telerik.WinControls.UI.RadDropDownList ddlLevel;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btnUpload;
        private Telerik.WinControls.UI.RadDropDownList ddlMatricNumber;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGridView gridSingleStudentResult;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton btnEnableForEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}
