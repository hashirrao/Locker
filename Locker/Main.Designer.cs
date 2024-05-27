namespace Locker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.changePassworButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutputButton = new System.Windows.Forms.Button();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.addBGWorker = new System.ComponentModel.BackgroundWorker();
            this.deleteBGWorker = new System.ComponentModel.BackgroundWorker();
            this.retrieveBGWorker = new System.ComponentModel.BackgroundWorker();
            this.minimizeButton1 = new Locker.MinimizeButton();
            this.maximizeButton1 = new Locker.MaximizeButton();
            this.closeButton = new Locker.CloseButton();
            this.topBar1 = new Locker.TopBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openButton.BackgroundImage")));
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(25, 388);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(118, 22);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Add Item";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(25, 59);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(738, 323);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // retrieveButton
            // 
            this.retrieveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.retrieveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retrieveButton.BackgroundImage")));
            this.retrieveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retrieveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrieveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveButton.Location = new System.Drawing.Point(149, 388);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(118, 22);
            this.retrieveButton.TabIndex = 5;
            this.retrieveButton.Text = "Retrieve Item";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // changePassworButton
            // 
            this.changePassworButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changePassworButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePassworButton.BackgroundImage")));
            this.changePassworButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePassworButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassworButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassworButton.Location = new System.Drawing.Point(397, 388);
            this.changePassworButton.Name = "changePassworButton";
            this.changePassworButton.Size = new System.Drawing.Size(118, 22);
            this.changePassworButton.TabIndex = 6;
            this.changePassworButton.Text = "Change Password";
            this.changePassworButton.UseVisualStyleBackColor = true;
            this.changePassworButton.Click += new System.EventHandler(this.changePassworButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.outputButton.BackgroundImage = global::Locker.Properties.Resources.MBoxBG;
            this.outputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(521, 388);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(118, 22);
            this.outputButton.TabIndex = 12;
            this.outputButton.Text = "Set Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(273, 388);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 22);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.retrieveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.totalItemsToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(133, 114);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // retrieveToolStripMenuItem
            // 
            this.retrieveToolStripMenuItem.Name = "retrieveToolStripMenuItem";
            this.retrieveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.retrieveToolStripMenuItem.Text = "Retrieve";
            this.retrieveToolStripMenuItem.Click += new System.EventHandler(this.retrieveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // totalItemsToolStripMenuItem
            // 
            this.totalItemsToolStripMenuItem.Name = "totalItemsToolStripMenuItem";
            this.totalItemsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.totalItemsToolStripMenuItem.Text = "Total Items";
            this.totalItemsToolStripMenuItem.Click += new System.EventHandler(this.totalItemsToolStripMenuItem_Click);
            // 
            // openOutputButton
            // 
            this.openOutputButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openOutputButton.BackgroundImage = global::Locker.Properties.Resources.MBoxBG;
            this.openOutputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openOutputButton.Location = new System.Drawing.Point(645, 388);
            this.openOutputButton.Name = "openOutputButton";
            this.openOutputButton.Size = new System.Drawing.Size(118, 22);
            this.openOutputButton.TabIndex = 14;
            this.openOutputButton.Text = "Open Output";
            this.openOutputButton.UseVisualStyleBackColor = true;
            this.openOutputButton.Click += new System.EventHandler(this.openOutputButton_Click);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.searchPictureBox.BackgroundImage = global::Locker.Properties.Resources.Search;
            this.searchPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchPictureBox.Location = new System.Drawing.Point(371, 24);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(30, 30);
            this.searchPictureBox.TabIndex = 15;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            this.searchPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchPictureBox_MouseDown);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchBox.Location = new System.Drawing.Point(252, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(282, 17);
            this.searchBox.TabIndex = 16;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.Visible = false;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar.Location = new System.Drawing.Point(25, 416);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(738, 10);
            this.progressBar.TabIndex = 17;
            // 
            // addBGWorker
            // 
            this.addBGWorker.WorkerReportsProgress = true;
            this.addBGWorker.WorkerSupportsCancellation = true;
            this.addBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.addBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.addBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // deleteBGWorker
            // 
            this.deleteBGWorker.WorkerReportsProgress = true;
            this.deleteBGWorker.WorkerSupportsCancellation = true;
            this.deleteBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deleteBGWorker_DoWork);
            this.deleteBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.deleteBGWorker_ProgressChanged);
            this.deleteBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.deleteBGWorker_RunWorkerCompleted);
            // 
            // retrieveBGWorker
            // 
            this.retrieveBGWorker.WorkerReportsProgress = true;
            this.retrieveBGWorker.WorkerSupportsCancellation = true;
            this.retrieveBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.retrieveBGWorker_DoWork);
            this.retrieveBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.retrieveBGWorker_ProgressChanged);
            this.retrieveBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.retrieveBGWorker_RunWorkerCompleted);
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton1.BackgroundImage")));
            this.minimizeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton1.Location = new System.Drawing.Point(743, 3);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(14, 14);
            this.minimizeButton1.TabIndex = 10;
            this.minimizeButton1.TabStop = false;
            this.minimizeButton1.Click += new System.EventHandler(this.minimizeButton1_Click);
            // 
            // maximizeButton1
            // 
            this.maximizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeButton1.BackgroundImage")));
            this.maximizeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximizeButton1.Location = new System.Drawing.Point(757, 3);
            this.maximizeButton1.Name = "maximizeButton1";
            this.maximizeButton1.Size = new System.Drawing.Size(14, 14);
            this.maximizeButton1.TabIndex = 9;
            this.maximizeButton1.TabStop = false;
            this.maximizeButton1.Click += new System.EventHandler(this.maximizeButton1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Location = new System.Drawing.Point(771, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(14, 14);
            this.closeButton.TabIndex = 8;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // topBar1
            // 
            this.topBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBar1.BackgroundImage")));
            this.topBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(787, 20);
            this.topBar1.TabIndex = 7;
            this.topBar1.TabStop = false;
            this.topBar1.DoubleClick += new System.EventHandler(this.topBar1_DoubleClick);
            this.topBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar1_MouseDown);
            this.topBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar1_MouseMove);
            this.topBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar1_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locker.Properties.Resources.MBoxBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 440);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.openOutputButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.maximizeButton1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.changePassworButton);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.openButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Button changePassworButton;
        private TopBar topBar1;
        private CloseButton closeButton;
        private MaximizeButton maximizeButton1;
        private MinimizeButton minimizeButton1;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem;
        private System.Windows.Forms.Button openOutputButton;
        private System.Windows.Forms.ToolStripMenuItem totalItemsToolStripMenuItem;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker addBGWorker;
        private System.ComponentModel.BackgroundWorker deleteBGWorker;
        private System.ComponentModel.BackgroundWorker retrieveBGWorker;
    }
}

