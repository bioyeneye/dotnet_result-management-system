namespace RMS.View.Admin.Result.Process
{
    partial class SingleStudentCourseResult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ddLevel = new Telerik.WinControls.UI.RadDropDownList();
            this.label7 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.nddScore = new System.Windows.Forms.NumericUpDown();
            this.ddlSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.btnReset = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlMatricNumber = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.ddlCourse = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nddScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-15, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 31);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kindly supply the required result detils\r\n";
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddLevel.Location = new System.Drawing.Point(79, 56);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(240, 20);
            this.ddLevel.TabIndex = 29;
            this.ddLevel.Text = "radDropDownList1";
            this.ddLevel.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddLevel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(33, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 14);
            this.label7.TabIndex = 28;
            this.label7.Text = "Level: ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(78, 39);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(10, 13);
            this.lblError.TabIndex = 27;
            this.lblError.Text = ".";
            // 
            // nddScore
            // 
            this.nddScore.Location = new System.Drawing.Point(79, 166);
            this.nddScore.Name = "nddScore";
            this.nddScore.Size = new System.Drawing.Size(240, 20);
            this.nddScore.TabIndex = 26;
            // 
            // ddlSemester
            // 
            this.ddlSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlSemester.Location = new System.Drawing.Point(79, 81);
            this.ddlSemester.Name = "ddlSemester";
            this.ddlSemester.Size = new System.Drawing.Size(240, 20);
            this.ddlSemester.TabIndex = 25;
            this.ddlSemester.Text = "radDropDownList1";
            this.ddlSemester.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlSemester_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(139, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 24);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(79, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 24);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Semester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Score:";
            // 
            // ddlMatricNumber
            // 
            this.ddlMatricNumber.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlMatricNumber.Location = new System.Drawing.Point(79, 137);
            this.ddlMatricNumber.Name = "ddlMatricNumber";
            this.ddlMatricNumber.Size = new System.Drawing.Size(240, 20);
            this.ddlMatricNumber.TabIndex = 31;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(9, 138);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 18);
            this.radLabel3.TabIndex = 30;
            this.radLabel3.Text = "Matric No:";
            // 
            // ddlCourse
            // 
            this.ddlCourse.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlCourse.Location = new System.Drawing.Point(79, 109);
            this.ddlCourse.Name = "ddlCourse";
            this.ddlCourse.Size = new System.Drawing.Size(240, 20);
            this.ddlCourse.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Course: ";
            // 
            // SingleStudentCourseResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlCourse);
            this.Controls.Add(this.ddlMatricNumber);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ddLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.nddScore);
            this.Controls.Add(this.ddlSemester);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SingleStudentCourseResult";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Course Result";
            this.Load += new System.EventHandler(this.SingleStudentCourseResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nddScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMatricNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDropDownList ddLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.NumericUpDown nddScore;
        private Telerik.WinControls.UI.RadDropDownList ddlSemester;
        private Telerik.WinControls.UI.RadButton btnReset;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList ddlMatricNumber;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList ddlCourse;
        private System.Windows.Forms.Label label1;
    }
}
