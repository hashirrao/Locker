namespace Locker
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.closeButton1 = new Locker.CloseButton();
            this.topBar = new Locker.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).BeginInit();
            this.SuspendLayout();
            // 
            // currentPassword
            // 
            this.currentPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.currentPassword.Location = new System.Drawing.Point(140, 56);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.PasswordChar = '•';
            this.currentPassword.Size = new System.Drawing.Size(209, 15);
            this.currentPassword.TabIndex = 2;
            this.currentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentPassword_KeyDown);
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.newPassword.Location = new System.Drawing.Point(140, 124);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '•';
            this.newPassword.Size = new System.Drawing.Size(209, 15);
            this.newPassword.TabIndex = 3;
            this.newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newPassword_KeyDown);
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.confirmPassword.Location = new System.Drawing.Point(140, 196);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '•';
            this.confirmPassword.Size = new System.Drawing.Size(209, 15);
            this.confirmPassword.TabIndex = 4;
            this.confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmPassword_KeyDown);
            // 
            // closeButton1
            // 
            this.closeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton1.BackgroundImage")));
            this.closeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton1.Location = new System.Drawing.Point(475, 3);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(14, 14);
            this.closeButton1.TabIndex = 1;
            this.closeButton1.TabStop = false;
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click);
            // 
            // topBar
            // 
            this.topBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBar.BackgroundImage")));
            this.topBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(491, 20);
            this.topBar.TabIndex = 0;
            this.topBar.TabStop = false;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseUp);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locker.Properties.Resources.ChangePasswordBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(491, 248);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.currentPassword);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.topBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TopBar topBar;
        private CloseButton closeButton1;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox confirmPassword;
    }
}