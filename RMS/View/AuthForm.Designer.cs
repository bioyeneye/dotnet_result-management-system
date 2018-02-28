namespace RMS.View
{
    partial class AuthForm
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pvAuth = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.lblError = new Telerik.WinControls.UI.RadLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new Telerik.WinControls.UI.RadCheckBox();
            this.btnAuthenticate = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvAuth)).BeginInit();
            this.pvAuth.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAuthenticate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.radLabel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.LightGray;
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Location = new System.Drawing.Point(-4, -1);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(473, 37);
            this.radPanel1.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(11, 7);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(249, 19);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Note: Provide the authentication detail";
            // 
            // pvAuth
            // 
            this.pvAuth.Controls.Add(this.radPageViewPage1);
            this.pvAuth.Controls.Add(this.radPageViewPage2);
            this.pvAuth.Controls.Add(this.radPageViewPage3);
            this.pvAuth.Font = new System.Drawing.Font("Microsoft Tai Le", 10.5F, System.Drawing.FontStyle.Bold);
            this.pvAuth.Location = new System.Drawing.Point(-5, 30);
            this.pvAuth.Name = "pvAuth";
            this.pvAuth.SelectedPage = this.radPageViewPage1;
            this.pvAuth.Size = new System.Drawing.Size(473, 270);
            this.pvAuth.TabIndex = 1;
            this.pvAuth.Text = "radPageView1";
            this.pvAuth.ThemeName = "Material";
            this.pvAuth.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pvAuth.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pvAuth.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Bottom;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.pvAuth.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.pvAuth.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(100, 0);
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.lblError);
            this.radPageViewPage1.Controls.Add(this.txtPassword);
            this.radPageViewPage1.Controls.Add(this.chkShowPassword);
            this.radPageViewPage1.Controls.Add(this.btnAuthenticate);
            this.radPageViewPage1.Controls.Add(this.radLabel3);
            this.radPageViewPage1.Controls.Add(this.txtUsername);
            this.radPageViewPage1.Controls.Add(this.radLabel2);
            this.radPageViewPage1.Controls.Add(this.pictureBox1);
            this.radPageViewPage1.Image = global::RMS.Properties.Resources.icons8_Access_20px;
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(93F, 50F);
            this.radPageViewPage1.Location = new System.Drawing.Point(6, 5);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(462, 210);
            this.radPageViewPage1.Text = "Login";
            this.radPageViewPage1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPageViewPage1.ToolTipText = "Login";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(177, 18);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(2, 2);
            this.lblError.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(174, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 23);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkShowPassword.Location = new System.Drawing.Point(332, 140);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(103, 18);
            this.chkShowPassword.TabIndex = 10;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkShowPassword_ToggleStateChanged);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(174, 139);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(83, 36);
            this.btnAuthenticate.TabIndex = 7;
            this.btnAuthenticate.Text = "Login";
            this.btnAuthenticate.ThemeName = "Material";
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(174, 89);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(83, 22);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Password : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(174, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(256, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // radLabel2
            // 
            this.radLabel2.Controls.Add(this.radLabel4);
            this.radLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(174, 40);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(87, 22);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Username : ";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(100, -19);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(87, 22);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Username : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RMS.Properties.Resources.login_2;
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(66F, 50F);
            this.radPageViewPage2.Location = new System.Drawing.Point(6, 5);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(462, 210);
            this.radPageViewPage2.Text = "New";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(72F, 50F);
            this.radPageViewPage3.Location = new System.Drawing.Point(6, 5);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(462, 210);
            this.radPageViewPage3.Text = "Reset";
            // 
            // AuthForm
            // 
            this.AcceptButton = this.btnAuthenticate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 306);
            this.Controls.Add(this.pvAuth);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth Form";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvAuth)).EndInit();
            this.pvAuth.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAuthenticate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.radLabel2.ResumeLayout(false);
            this.radLabel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageView pvAuth;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnAuthenticate;
        private Telerik.WinControls.UI.RadTextBox txtUsername;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadCheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private Telerik.WinControls.UI.RadLabel lblError;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
