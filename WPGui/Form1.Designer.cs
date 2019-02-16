namespace WPGui
{
    partial class Form1
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
            this.Main = new VelyseTheme.VelyseForm();
            this.velyseControlBox1 = new VelyseTheme.VelyseControlBox();
            this.TabControl = new VelyseTheme.VelyseTabControl();
            this.THome = new System.Windows.Forms.TabPage();
            this.cUsernames = new VelyseTheme.VelyseCheckbox();
            this.cThemes = new VelyseTheme.VelyseCheckbox();
            this.cPlugins = new VelyseTheme.VelyseCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.TScanner = new System.Windows.Forms.TabPage();
            this.TAbout = new System.Windows.Forms.TabPage();
            this.txtView = new System.Windows.Forms.RichTextBox();
            this.btnStart = new VelyseTheme.VelyseButton();
            this.txtURL = new VelyseTheme.VelyseTextBox();
            this.txtRuby = new System.Windows.Forms.Label();
            this.txtWP = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.THome.SuspendLayout();
            this.TScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.Main.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.Main.Controls.Add(this.velyseControlBox1);
            this.Main.Controls.Add(this.TabControl);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.Main.RoundCorners = VelyseTheme.VelyseForm.VLRoundCorner.Round;
            this.Main.Sizable = true;
            this.Main.Size = new System.Drawing.Size(818, 403);
            this.Main.SmartBounds = true;
            this.Main.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Main.TabIndex = 0;
            this.Main.Text = "WPGui | Moba";
            this.Main.Text_Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Main.TextColor = System.Drawing.Color.White;
            this.Main.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(124)))));
            // 
            // velyseControlBox1
            // 
            this.velyseControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.velyseControlBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(124)))));
            this.velyseControlBox1.EnableHoverHighlight = false;
            this.velyseControlBox1.EnableMaximizeButton = false;
            this.velyseControlBox1.EnableMinimizeButton = true;
            this.velyseControlBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(124)))));
            this.velyseControlBox1.Location = new System.Drawing.Point(722, 0);
            this.velyseControlBox1.Name = "velyseControlBox1";
            this.velyseControlBox1.Size = new System.Drawing.Size(100, 25);
            this.velyseControlBox1.TabIndex = 2;
            this.velyseControlBox1.Text = "velyseControlBox1";
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl.Controls.Add(this.THome);
            this.TabControl.Controls.Add(this.TScanner);
            this.TabControl.Controls.Add(this.TAbout);
            this.TabControl.FirstHeaderBorder = false;
            this.TabControl.ItemSize = new System.Drawing.Size(40, 180);
            this.TabControl.Location = new System.Drawing.Point(0, 73);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl.Size = new System.Drawing.Size(822, 341);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabControlBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.TabControlSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TabControl.TabIndex = 0;
            this.TabControl.TabMouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(124)))));
            this.TabControl.unSelectedTextColor = System.Drawing.Color.Gray;
            // 
            // THome
            // 
            this.THome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.THome.Controls.Add(this.txtOther);
            this.THome.Controls.Add(this.txtWP);
            this.THome.Controls.Add(this.txtRuby);
            this.THome.Controls.Add(this.txtURL);
            this.THome.Controls.Add(this.btnStart);
            this.THome.Controls.Add(this.cUsernames);
            this.THome.Controls.Add(this.cPlugins);
            this.THome.Controls.Add(this.cThemes);
            this.THome.Controls.Add(this.label1);
            this.THome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.THome.ForeColor = System.Drawing.Color.White;
            this.THome.Location = new System.Drawing.Point(184, 4);
            this.THome.Name = "THome";
            this.THome.Padding = new System.Windows.Forms.Padding(3);
            this.THome.Size = new System.Drawing.Size(634, 333);
            this.THome.TabIndex = 0;
            this.THome.Text = "Home";
            // 
            // cUsernames
            // 
            this.cUsernames.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.cUsernames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cUsernames.Checked = false;
            this.cUsernames.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
            this.cUsernames.ElipseColor = System.Drawing.Color.White;
            this.cUsernames.Location = new System.Drawing.Point(237, 276);
            this.cUsernames.Name = "cUsernames";
            this.cUsernames.Size = new System.Drawing.Size(129, 22);
            this.cUsernames.TabIndex = 5;
            this.cUsernames.Text = "Scan Usernames";
            this.cUsernames.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cThemes
            // 
            this.cThemes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.cThemes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cThemes.Checked = false;
            this.cThemes.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
            this.cThemes.ElipseColor = System.Drawing.Color.White;
            this.cThemes.Location = new System.Drawing.Point(124, 276);
            this.cThemes.Name = "cThemes";
            this.cThemes.Size = new System.Drawing.Size(107, 22);
            this.cThemes.TabIndex = 4;
            this.cThemes.Text = "Scan Themes";
            this.cThemes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cPlugins
            // 
            this.cPlugins.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.cPlugins.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cPlugins.Checked = false;
            this.cPlugins.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
            this.cPlugins.ElipseColor = System.Drawing.Color.White;
            this.cPlugins.Location = new System.Drawing.Point(11, 276);
            this.cPlugins.Name = "cPlugins";
            this.cPlugins.Size = new System.Drawing.Size(107, 22);
            this.cPlugins.TabIndex = 3;
            this.cPlugins.Text = "Scan Plugins";
            this.cPlugins.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL TO SCAN";
            // 
            // TScanner
            // 
            this.TScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TScanner.Controls.Add(this.txtView);
            this.TScanner.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TScanner.ForeColor = System.Drawing.Color.White;
            this.TScanner.Location = new System.Drawing.Point(184, 4);
            this.TScanner.Name = "TScanner";
            this.TScanner.Padding = new System.Windows.Forms.Padding(3);
            this.TScanner.Size = new System.Drawing.Size(634, 333);
            this.TScanner.TabIndex = 1;
            this.TScanner.Text = "Scanner";
            // 
            // TAbout
            // 
            this.TAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TAbout.ForeColor = System.Drawing.Color.White;
            this.TAbout.Location = new System.Drawing.Point(184, 4);
            this.TAbout.Name = "TAbout";
            this.TAbout.Size = new System.Drawing.Size(630, 322);
            this.TAbout.TabIndex = 2;
            this.TAbout.Text = "About";
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtView.DetectUrls = false;
            this.txtView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.ForeColor = System.Drawing.Color.White;
            this.txtView.Location = new System.Drawing.Point(0, 0);
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.Size = new System.Drawing.Size(634, 326);
            this.txtView.TabIndex = 0;
            this.txtView.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btnStart.Location = new System.Drawing.Point(471, 248);
            this.btnStart.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(132)))), ((int)(((byte)(165)))));
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.VMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(122)))), ((int)(((byte)(155)))));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.Transparent;
            this.txtURL.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(79)))), ((int)(((byte)(124)))));
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtURL.Image = null;
            this.txtURL.Location = new System.Drawing.Point(11, 207);
            this.txtURL.MaxLength = 32767;
            this.txtURL.Multiline = false;
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = false;
            this.txtURL.Size = new System.Drawing.Size(355, 41);
            this.txtURL.TabIndex = 7;
            this.txtURL.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtURL.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtURL.UseSystemPasswordChar = false;
            // 
            // txtRuby
            // 
            this.txtRuby.AutoSize = true;
            this.txtRuby.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuby.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRuby.Location = new System.Drawing.Point(6, 17);
            this.txtRuby.Name = "txtRuby";
            this.txtRuby.Size = new System.Drawing.Size(0, 25);
            this.txtRuby.TabIndex = 8;
            // 
            // txtWP
            // 
            this.txtWP.AutoSize = true;
            this.txtWP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtWP.Location = new System.Drawing.Point(6, 53);
            this.txtWP.Name = "txtWP";
            this.txtWP.Size = new System.Drawing.Size(0, 25);
            this.txtWP.TabIndex = 9;
            // 
            // txtOther
            // 
            this.txtOther.AutoSize = true;
            this.txtOther.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOther.Location = new System.Drawing.Point(6, 89);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(0, 25);
            this.txtOther.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(818, 403);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "WPGui | Moba";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Main.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.THome.ResumeLayout(false);
            this.THome.PerformLayout();
            this.TScanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VelyseTheme.VelyseForm Main;
        private VelyseTheme.VelyseTabControl TabControl;
        private System.Windows.Forms.TabPage THome;
        private System.Windows.Forms.TabPage TScanner;
        private System.Windows.Forms.TabPage TAbout;
        private VelyseTheme.VelyseControlBox velyseControlBox1;
        private VelyseTheme.VelyseCheckbox cUsernames;
        private VelyseTheme.VelyseCheckbox cThemes;
        private VelyseTheme.VelyseCheckbox cPlugins;
        private System.Windows.Forms.Label label1;
        private VelyseTheme.VelyseButton btnStart;
        private System.Windows.Forms.RichTextBox txtView;
        private VelyseTheme.VelyseTextBox txtURL;
        private System.Windows.Forms.Label txtOther;
        private System.Windows.Forms.Label txtWP;
        private System.Windows.Forms.Label txtRuby;
    }
}

