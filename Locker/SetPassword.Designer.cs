namespace Locker
{
    partial class SetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPassword));
            this.newPassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.minimizeButton1 = new Locker.MinimizeButton();
            this.closeButton1 = new Locker.CloseButton();
            this.topBar1 = new Locker.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.newPassword.Location = new System.Drawing.Point(140, 90);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '•';
            this.newPassword.Size = new System.Drawing.Size(210, 15);
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
            this.confirmPassword.Location = new System.Drawing.Point(140, 162);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '•';
            this.confirmPassword.Size = new System.Drawing.Size(210, 15);
            this.confirmPassword.TabIndex = 4;
            this.confirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmPassword_KeyDown);
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton1.BackgroundImage")));
            this.minimizeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton1.Location = new System.Drawing.Point(461, 3);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(14, 14);
            this.minimizeButton1.TabIndex = 2;
            this.minimizeButton1.TabStop = false;
            this.minimizeButton1.Click += new System.EventHandler(this.minimizeButton1_Click);
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
            // topBar1
            // 
            this.topBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBar1.BackgroundImage")));
            this.topBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(491, 20);
            this.topBar1.TabIndex = 0;
            this.topBar1.TabStop = false;
            this.topBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar1_MouseDown);
            this.topBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar1_MouseMove);
            this.topBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar1_MouseUp);
            // 
            // SetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locker.Properties.Resources.SetPasswordBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(491, 248);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.topBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TopBar topBar1;
        private CloseButton closeButton1;
        private MinimizeButton minimizeButton1;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox confirmPassword;
    }
}