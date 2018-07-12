namespace RMS.View.SuperAdmin.Course
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridCourse = new Telerik.WinControls.UI.RadGridView();
            this.btnAddCourse = new Telerik.WinControls.UI.RadButton();
            this.btnBulkCourse = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBulkCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCourse
            // 
            this.gridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourse.Location = new System.Drawing.Point(12, 63);
            // 
            // 
            // 
            this.gridCourse.MasterTemplate.AllowAddNewRow = false;
            this.gridCourse.MasterTemplate.AllowEditRow = false;
            this.gridCourse.MasterTemplate.PageSize = 50;
            this.gridCourse.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(1100, 458);
            this.gridCourse.TabIndex = 2;
            this.gridCourse.ThemeName = "TelerikMetro";
            this.gridCourse.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridCourse_CellClick);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCourse.Location = new System.Drawing.Point(881, 18);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(107, 36);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "New Course";
            this.btnAddCourse.ThemeName = "Material";
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnBulkCourse
            // 
            this.btnBulkCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBulkCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBulkCourse.Location = new System.Drawing.Point(768, 18);
            this.btnBulkCourse.Name = "btnBulkCourse";
            this.btnBulkCourse.Size = new System.Drawing.Size(107, 36);
            this.btnBulkCourse.TabIndex = 4;
            this.btnBulkCourse.Text = "Bulk Upload";
            this.btnBulkCourse.ThemeName = "Material";
            this.btnBulkCourse.Click += new System.EventHandler(this.btnBulkCourse_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(994, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 36);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ThemeName = "Material";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(1054, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ThemeName = "Material";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 547);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBulkCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.gridCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "ListForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Courses";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBulkCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView gridCourse;
        private Telerik.WinControls.UI.RadButton btnAddCourse;
        private Telerik.WinControls.UI.RadButton btnBulkCourse;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnDelete;
    }
}
