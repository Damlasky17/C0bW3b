namespace C0bW3b
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
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBar2 = new System.Windows.Forms.Panel();
            this.pnlPageViewer = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.AutoSave = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnEngines = new System.Windows.Forms.Button();
            this.btnPlugins = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHits = new System.Windows.Forms.Button();
            this.btnRunner = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBar.SuspendLayout();
            this.pnlBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlBar.Controls.Add(this.lblTitle);
            this.pnlBar.Controls.Add(this.picLogo);
            this.pnlBar.Controls.Add(this.btnMinimize);
            this.pnlBar.Controls.Add(this.btnMaximize);
            this.pnlBar.Controls.Add(this.btnClose);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1237, 32);
            this.pnlBar.TabIndex = 0;
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1083, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "C0bW3b";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDoubleClick);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // pnlBar2
            // 
            this.pnlBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlBar2.Controls.Add(this.btnHelp);
            this.pnlBar2.Controls.Add(this.btnEngines);
            this.pnlBar2.Controls.Add(this.btnPlugins);
            this.pnlBar2.Controls.Add(this.btnSettings);
            this.pnlBar2.Controls.Add(this.btnHits);
            this.pnlBar2.Controls.Add(this.btnRunner);
            this.pnlBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar2.Location = new System.Drawing.Point(0, 32);
            this.pnlBar2.Name = "pnlBar2";
            this.pnlBar2.Size = new System.Drawing.Size(1237, 44);
            this.pnlBar2.TabIndex = 1;
            // 
            // pnlPageViewer
            // 
            this.pnlPageViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPageViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlPageViewer.Location = new System.Drawing.Point(12, 87);
            this.pnlPageViewer.Name = "pnlPageViewer";
            this.pnlPageViewer.Size = new System.Drawing.Size(1213, 460);
            this.pnlPageViewer.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblFooter.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(37, 553);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1163, 23);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFooter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDoubleClick);
            this.lblFooter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::C0bW3b.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(1126, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHelp.Size = new System.Drawing.Size(111, 44);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnEngines
            // 
            this.btnEngines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEngines.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEngines.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEngines.FlatAppearance.BorderSize = 0;
            this.btnEngines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEngines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEngines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngines.ForeColor = System.Drawing.Color.White;
            this.btnEngines.Image = global::C0bW3b.Properties.Resources.Spyglass;
            this.btnEngines.Location = new System.Drawing.Point(444, 0);
            this.btnEngines.Name = "btnEngines";
            this.btnEngines.Size = new System.Drawing.Size(111, 44);
            this.btnEngines.TabIndex = 8;
            this.btnEngines.Text = "Engines";
            this.btnEngines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEngines.UseVisualStyleBackColor = false;
            this.btnEngines.Click += new System.EventHandler(this.btnEngines_Click);
            // 
            // btnPlugins
            // 
            this.btnPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPlugins.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlugins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPlugins.FlatAppearance.BorderSize = 0;
            this.btnPlugins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPlugins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPlugins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlugins.ForeColor = System.Drawing.Color.White;
            this.btnPlugins.Image = global::C0bW3b.Properties.Resources.Puzzle;
            this.btnPlugins.Location = new System.Drawing.Point(333, 0);
            this.btnPlugins.Name = "btnPlugins";
            this.btnPlugins.Size = new System.Drawing.Size(111, 44);
            this.btnPlugins.TabIndex = 7;
            this.btnPlugins.Text = "Plugins";
            this.btnPlugins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlugins.UseVisualStyleBackColor = false;
            this.btnPlugins.Click += new System.EventHandler(this.btnPlugins_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::C0bW3b.Properties.Resources.Cog;
            this.btnSettings.Location = new System.Drawing.Point(222, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 44);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHits
            // 
            this.btnHits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnHits.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHits.FlatAppearance.BorderSize = 0;
            this.btnHits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnHits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHits.ForeColor = System.Drawing.Color.White;
            this.btnHits.Image = global::C0bW3b.Properties.Resources.Database;
            this.btnHits.Location = new System.Drawing.Point(111, 0);
            this.btnHits.Name = "btnHits";
            this.btnHits.Size = new System.Drawing.Size(111, 44);
            this.btnHits.TabIndex = 4;
            this.btnHits.Text = "Hits";
            this.btnHits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHits.UseVisualStyleBackColor = false;
            this.btnHits.Click += new System.EventHandler(this.btnHits_Click);
            // 
            // btnRunner
            // 
            this.btnRunner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRunner.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRunner.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRunner.FlatAppearance.BorderSize = 0;
            this.btnRunner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRunner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunner.ForeColor = System.Drawing.Color.White;
            this.btnRunner.Image = global::C0bW3b.Properties.Resources.runner;
            this.btnRunner.Location = new System.Drawing.Point(0, 0);
            this.btnRunner.Name = "btnRunner";
            this.btnRunner.Size = new System.Drawing.Size(111, 44);
            this.btnRunner.TabIndex = 2;
            this.btnRunner.Text = "Runner";
            this.btnRunner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunner.UseVisualStyleBackColor = false;
            this.btnRunner.Click += new System.EventHandler(this.btnRunner_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::C0bW3b.Properties.Resources.icon;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(25, 32);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            this.picLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::C0bW3b.Properties.Resources.Minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1108, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::C0bW3b.Properties.Resources.Maximize;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1151, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(43, 32);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::C0bW3b.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1194, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1237, 576);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.pnlPageViewer);
            this.Controls.Add(this.pnlBar2);
            this.Controls.Add(this.pnlBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBar2;
        private System.Windows.Forms.Button btnRunner;
        private System.Windows.Forms.Panel pnlPageViewer;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnHits;
        private System.Windows.Forms.Button btnPlugins;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEngines;
        private System.Windows.Forms.Timer AutoSave;
        private System.Windows.Forms.Button btnHelp;
    }
}