namespace RMS.View.Admin.Result.Process
{
    partial class SingleStudentSemesterResult
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
            this.gridSingleStudentResult = new Telerik.WinControls.UI.RadGridView();
            this.btnSaveResult = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.btnDownloadTemplate = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlSemester2 = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlLevel2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beResultTemplate = new Telerik.WinControls.UI.RadBrowseEditor();
            this.btnUpload = new Telerik.WinControls.UI.RadButton();
            this.ddlMatricNumber = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beResultTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSingleStudentResult
            // 
            this.gridSingleStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSingleStudentResult.Enabled = false;
            this.gridSingleStudentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gridSingleStudentResult.Location = new System.Drawing.Point(12, 109);
            // 
            // 
            // 
            this.gridSingleStudentResult.MasterTemplate.AllowAddNewRow = false;
            this.gridSingleStudentResult.MasterTemplate.AllowEditRow = false;
            this.gridSingleStudentResult.MasterTemplate.PageSize = 50;
            this.gridSingleStudentResult.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridSingleStudentResult.Name = "gridSingleStudentResult";
            this.gridSingleStudentResult.Size = new System.Drawing.Size(1156, 401);
            this.gridSingleStudentResult.TabIndex = 7;
            this.gridSingleStudentResult.ThemeName = "TelerikMetro";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveResult.Location = new System.Drawing.Point(12, 514);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(110, 24);
            this.btnSaveResult.TabIndex = 8;
            this.btnSaveResult.Text = "Upload Result";
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ddlSemester);
            this.radGroupBox1.Controls.Add(this.ddlLevel);
            this.radGroupBox1.Controls.Add(this.btnDownloadTemplate);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Download Upload Template";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(574, 91);
            this.radGroupBox1.TabIndex = 9;
            this.radGroupBox1.Text = "Download Upload Template";
            // 
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(264, 36);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(147, 24);
            this.ddlSemester.TabIndex = 17;
            this.ddlSemester.Text = "radDropDownList1";
            // 
            // ddlLevel
            // 
            this.ddlLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlLevel.Location = new System.Drawing.Point(50, 36);
            this.ddlLevel.Name = "ddlLevel";
            this.ddlLevel.Size = new System.Drawing.Size(147, 24);
            this.ddlLevel.TabIndex = 16;
            this.ddlLevel.Text = "radDropDownList1";
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownloadTemplate.Location = new System.Drawing.Point(423, 34);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(137, 24);
            this.btnDownloadTemplate.TabIndex = 9;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(202, 37);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(65, 17);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Semester:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(10, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 17);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Level: ";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.ddlSemester2);
            this.radGroupBox2.Controls.Add(this.ddlLevel2);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.lblError);
            this.radGroupBox2.Controls.Add(this.label2);
            this.radGroupBox2.Controls.Add(this.beResultTemplate);
            this.radGroupBox2.Controls.Add(this.btnUpload);
            this.radGroupBox2.Controls.Add(this.ddlMatricNumber);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "Upload Section";
            this.radGroupBox2.Location = new System.Drawing.Point(592, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(576, 91);
            this.radGroupBox2.TabIndex = 10;
            this.radGroupBox2.Text = "Upload Section";
            // 
            // ddlSemester2
            // 
            this.ddlSemester2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester2.Location = new System.Drawing.Point(318, 25);
            this.ddlSemester2.Name = "ddlSemester2";
            this.ddlSemester2.Size = new System.Drawing.Size(149, 24);
            this.ddlSemester2.TabIndex = 32;
            this.ddlSemester2.Text = "radDropDownList1";
            // 
            // ddlLevel2
            // 
            this.ddlLevel2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlLevel2.Location = new System.Drawing.Point(78, 24);
            this.ddlLevel2.Name = "ddlLevel2";
            this.ddlLevel2.Size = new System.Drawing.Size(149, 24);
            this.ddlLevel2.TabIndex = 31;
            this.ddlLevel2.Text = "radDropDownList1";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(237, 26);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 17);
            this.radLabel4.TabIndex = 30;
            this.radLabel4.Text = "Semester:";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(31, 24);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 17);
            this.radLabel5.TabIndex = 29;
            this.radLabel5.Text = "Level: ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(77, 72);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(11, 15);
            this.lblError.TabIndex = 28;
            this.lblError.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(231, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Select File:";
            // 
            // beResultTemplate
            // 
            this.beResultTemplate.Location = new System.Drawing.Point(318, 50);
            this.beResultTemplate.Name = "beResultTemplate";
            this.beResultTemplate.Size = new System.Drawing.Size(149, 21);
            this.beResultTemplate.TabIndex = 26;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpload.Location = new System.Drawing.Point(495, 26);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(69, 40);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ddlMatricNumber
            // 
            this.ddlMatricNumber.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlMatricNumber.Location = new System.Drawing.Point(78, 49);
            this.ddlMatricNumber.Name = "ddlMatricNumber";
            this.ddlMatricNumber.Size = new System.Drawing.Size(149, 24);
            this.ddlMatricNumber.TabIndex = 18;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(7, 50);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 17);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "Matric No:";
            // 
            // SingleStudentSemesterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 539);
            this.Controls.Add(this.gridSingleStudentResult);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.btnSaveResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "SingleStudentSemesterResult";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Single Student Result";
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSingleStudentResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beResultTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridSingleStudentResult;
        private Telerik.WinControls.UI.RadButton btnSaveResult;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton btnDownloadTemplate;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private Telerik.WinControls.UI.RadDropDownList ddlLevel;
        private Telerik.WinControls.UI.RadDropDownList ddlMatricNumber;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadBrowseEditor beResultTemplate;
        private Telerik.WinControls.UI.RadButton btnUpload;
        private System.Windows.Forms.Label lblError;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester2;
        private Telerik.WinControls.UI.RadDropDownList ddlLevel2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}
