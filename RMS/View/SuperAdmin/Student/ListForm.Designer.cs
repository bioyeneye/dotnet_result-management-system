namespace RMS.View.SuperAdmin.Student
{
    partial class ListForm
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
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAddStudent = new Telerik.WinControls.UI.RadButton();
            this.gridStudent = new Telerik.WinControls.UI.RadGridView();
            this.btnBulkCourse = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBulkCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(523, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 36);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ThemeName = "Material";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(463, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ThemeName = "Material";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(350, 5);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(107, 36);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "New Student";
            this.btnAddStudent.ThemeName = "Material";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // gridStudent
            // 
            this.gridStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStudent.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridStudent.Location = new System.Drawing.Point(1, 45);
            // 
            // 
            // 
            this.gridStudent.MasterTemplate.AllowAddNewRow = false;
            this.gridStudent.MasterTemplate.AllowEditRow = false;
            this.gridStudent.MasterTemplate.PageSize = 50;
            this.gridStudent.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.Size = new System.Drawing.Size(576, 293);
            this.gridStudent.TabIndex = 10;
            this.gridStudent.ThemeName = "TelerikMetro";
            this.gridStudent.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridStudent_CellClick);
            // 
            // btnBulkCourse
            // 
            this.btnBulkCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBulkCourse.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnBulkCourse.Location = new System.Drawing.Point(237, 5);
            this.btnBulkCourse.Name = "btnBulkCourse";
            this.btnBulkCourse.Size = new System.Drawing.Size(107, 36);
            this.btnBulkCourse.TabIndex = 14;
            this.btnBulkCourse.Text = "Bulk Upload";
            this.btnBulkCourse.ThemeName = "Material";
            this.btnBulkCourse.Click += new System.EventHandler(this.btnBulkCourse_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 339);
            this.Controls.Add(this.btnBulkCourse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.gridStudent);
            this.Name = "ListForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "List Student";
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBulkCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAddStudent;
        private Telerik.WinControls.UI.RadGridView gridStudent;
        private Telerik.WinControls.UI.RadButton btnBulkCourse;
    }
}
