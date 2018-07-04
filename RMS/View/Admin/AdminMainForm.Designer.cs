namespace RMS.View.Admin
{
    partial class EoMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EoMainForm));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnResultSingleStudent = new Telerik.WinControls.UI.RadButtonElement();
            this.btnResultSingleSemester = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnResultStudentsCourse = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup6 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.menuViewResultPerCourse = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.ribbonTab4 = new Telerik.WinControls.UI.RibbonTab();
            this.btnStudent = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnPerSemesterNonBulk = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 475);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1219, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab2,
            this.ribbonTab1,
            this.ribbonTab3,
            this.ribbonTab4});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(1219, 154);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Class Rep";
            this.radRibbonBar1.ThemeName = "TelerikMetroBlue";
            this.radRibbonBar1.Click += new System.EventHandler(this.radRibbonBar1_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.IsSelected = true;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup6});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Result";
            this.ribbonTab2.UseMnemonic = false;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnResultSingleStudent,
            this.btnResultSingleSemester,
            this.btnPerSemesterNonBulk});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Process Result(1 Student)";
            // 
            // btnResultSingleStudent
            // 
            this.btnResultSingleStudent.Name = "btnResultSingleStudent";
            this.btnResultSingleStudent.Text = "Per Semester";
            this.btnResultSingleStudent.Click += new System.EventHandler(this.btnResultSingleStudent_Click);
            // 
            // btnResultSingleSemester
            // 
            this.btnResultSingleSemester.Name = "btnResultSingleSemester";
            this.btnResultSingleSemester.Text = "Per Course";
            this.btnResultSingleSemester.Click += new System.EventHandler(this.btnResultSingleSemester_Click);
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnResultStudentsCourse});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Process Result(All student)";
            // 
            // btnResultStudentsCourse
            // 
            this.btnResultStudentsCourse.Name = "btnResultStudentsCourse";
            this.btnResultStudentsCourse.Text = "Per Course";
            this.btnResultStudentsCourse.Click += new System.EventHandler(this.btnResultStudentsCourse_Click);
            // 
            // radRibbonBarGroup6
            // 
            this.radRibbonBarGroup6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuViewResultPerCourse,
            this.radButtonElement4});
            this.radRibbonBarGroup6.Name = "radRibbonBarGroup6";
            this.radRibbonBarGroup6.Text = "View Result";
            // 
            // menuViewResultPerCourse
            // 
            this.menuViewResultPerCourse.Name = "menuViewResultPerCourse";
            this.menuViewResultPerCourse.Text = "Per Course";
            this.menuViewResultPerCourse.Click += new System.EventHandler(this.menuViewResultPerCourse_Click);
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "Per Student";
            this.radButtonElement4.Click += new System.EventHandler(this.radButtonElement4_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = false;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Student";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement5});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Student";
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.Text = "List student";
            this.radButtonElement5.Click += new System.EventHandler(this.radButtonElement5_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.IsSelected = false;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup4,
            this.radRibbonBarGroup5});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Report";
            this.ribbonTab3.UseMnemonic = false;
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "Single";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "Student";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "Semester";
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "Sheet";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Help";
            this.ribbonTab4.UseMnemonic = false;
            // 
            // btnStudent
            // 
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Text = "List Student";
            this.btnStudent.UseCompatibleTextRendering = false;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "List Student";
            this.radButtonElement3.UseCompatibleTextRendering = false;
            // 
            // btnPerSemesterNonBulk
            // 
            this.btnPerSemesterNonBulk.Name = "btnPerSemesterNonBulk";
            this.btnPerSemesterNonBulk.Text = "Per Semester(Non Bulk)";
            this.btnPerSemesterNonBulk.Click += new System.EventHandler(this.btnPerSemesterNonBulk_Click);
            // 
            // EoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 501);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.MainMenuStrip = null;
            this.Name = "EoMainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Class Rep";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EoMainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab4;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement btnResultSingleStudent;
        private Telerik.WinControls.UI.RadButtonElement btnResultSingleSemester;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnResultStudentsCourse;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup6;
        private Telerik.WinControls.UI.RadButtonElement menuViewResultPerCourse;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement5;
        private Telerik.WinControls.UI.RadButtonElement btnStudent;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement btnPerSemesterNonBulk;
    }
}
