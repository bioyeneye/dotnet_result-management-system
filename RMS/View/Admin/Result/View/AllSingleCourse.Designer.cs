namespace RMS.View.Admin.Result.View
{
    partial class AllSingleCourse
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnShowResult = new Telerik.WinControls.UI.RadButton();
            this.ddLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlCourse = new Telerik.WinControls.UI.RadDropDownList();
            this.gridSingleStudentResult = new Telerik.WinControls.UI.RadGridView();
            this.btnEnableForEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnableForEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.lblError);
            this.radGroupBox1.Controls.Add(this.btnShowResult);
            this.radGroupBox1.Controls.Add(this.ddLevel);
            this.radGroupBox1.Controls.Add(this.label7);
            this.radGroupBox1.Controls.Add(this.ddlSemester);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.ddlCourse);
            this.radGroupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Process Result";
            this.radGroupBox1.Location = new System.Drawing.Point(9, 8);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(744, 88);
            this.radGroupBox1.TabIndex = 14;
            this.radGroupBox1.Text = "Process Result";
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
            // btnShowResult
            // 
            this.btnShowResult.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowResult.Location = new System.Drawing.Point(414, 58);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(107, 20);
            this.btnShowResult.TabIndex = 41;
            this.btnShowResult.Text = "Show";
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddLevel.Location = new System.Drawing.Point(70, 30);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(240, 20);
            this.ddLevel.TabIndex = 40;
            this.ddLevel.Text = "radDropDownList1";
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
            // gridSingleStudentResult
            // 
            this.gridSingleStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSingleStudentResult.Enabled = false;
            this.gridSingleStudentResult.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.gridSingleStudentResult.Location = new System.Drawing.Point(9, 102);
            // 
            // 
            // 
            this.gridSingleStudentResult.MasterTemplate.AllowAddNewRow = false;
            this.gridSingleStudentResult.MasterTemplate.AllowEditRow = false;
            this.gridSingleStudentResult.MasterTemplate.PageSize = 50;
            this.gridSingleStudentResult.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridSingleStudentResult.Name = "gridSingleStudentResult";
            this.gridSingleStudentResult.Size = new System.Drawing.Size(747, 390);
            this.gridSingleStudentResult.TabIndex = 16;
            this.gridSingleStudentResult.ThemeName = "TelerikMetro";
            // 
            // btnEnableForEdit
            // 
            this.btnEnableForEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnableForEdit.Location = new System.Drawing.Point(12, 498);
            this.btnEnableForEdit.Name = "btnEnableForEdit";
            this.btnEnableForEdit.Size = new System.Drawing.Size(94, 24);
            this.btnEnableForEdit.TabIndex = 17;
            this.btnEnableForEdit.Text = "Enable for edit";
            this.btnEnableForEdit.Click += new System.EventHandler(this.btnEnableForEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(112, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 24);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Data";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AllSingleCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.gridSingleStudentResult);
            this.Controls.Add(this.btnEnableForEdit);
            this.Name = "AllSingleCourse";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AllSingleCourse";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnableForEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label lblError;
        private Telerik.WinControls.UI.RadButton btnShowResult;
        private Telerik.WinControls.UI.RadDropDownList ddLevel;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList ddlCourse;
        private Telerik.WinControls.UI.RadGridView gridSingleStudentResult;
        private Telerik.WinControls.UI.RadButton btnEnableForEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}
