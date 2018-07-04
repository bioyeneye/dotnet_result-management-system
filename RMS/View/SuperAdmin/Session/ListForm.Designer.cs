namespace RMS.View.SuperAdmin.Session
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
            this.gridCourse = new Telerik.WinControls.UI.RadGridView();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAddSession = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCourse
            // 
            this.gridCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCourse.Location = new System.Drawing.Point(2, 54);
            // 
            // 
            // 
            this.gridCourse.MasterTemplate.AllowAddNewRow = false;
            this.gridCourse.MasterTemplate.AllowEditRow = false;
            this.gridCourse.MasterTemplate.PageSize = 50;
            this.gridCourse.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(476, 236);
            this.gridCourse.TabIndex = 3;
            this.gridCourse.ThemeName = "TelerikMetro";
            this.gridCourse.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridCourse_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(425, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.ThemeName = "Material";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddSession.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSession.Location = new System.Drawing.Point(312, 12);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(107, 36);
            this.btnAddSession.TabIndex = 5;
            this.btnAddSession.Text = "New Session";
            this.btnAddSession.ThemeName = "Material";
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 293);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.gridCourse);
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Semester List";
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridCourse;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAddSession;
    }
}
