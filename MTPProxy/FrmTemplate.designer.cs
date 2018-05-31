namespace MTPProxy
{
    partial class FrmTemplate
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.port = new MetroFramework.Controls.MetroTextBox();
            this.ip = new MetroFramework.Controls.MetroTextBox();
            this.secret = new MetroFramework.Controls.MetroTextBox();
            this.ToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.st = new MetroFramework.Controls.MetroButton();
            this.backlog = new MetroFramework.Controls.MetroTextBox();
            this.textbox = new MetroFramework.Controls.MetroTextBox();
            this.save = new MetroFramework.Controls.MetroButton();
            this.load = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // port
            // 
            // 
            // 
            // 
            this.port.CustomButton.Image = null;
            this.port.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.port.CustomButton.Name = "";
            this.port.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.port.CustomButton.TabIndex = 1;
            this.port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.port.CustomButton.UseSelectable = true;
            this.port.CustomButton.Visible = false;
            this.port.Lines = new string[0];
            this.port.Location = new System.Drawing.Point(23, 63);
            this.port.MaxLength = 32767;
            this.port.Name = "port";
            this.port.PasswordChar = '\0';
            this.port.PromptText = "Listen Port";
            this.port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.port.SelectedText = "";
            this.port.SelectionLength = 0;
            this.port.SelectionStart = 0;
            this.port.ShortcutsEnabled = true;
            this.port.Size = new System.Drawing.Size(146, 23);
            this.port.TabIndex = 0;
            this.port.UseSelectable = true;
            this.port.WaterMark = "Listen Port";
            this.port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.port.TextChanged += new System.EventHandler(this.port_change);
            // 
            // ip
            // 
            // 
            // 
            // 
            this.ip.CustomButton.Image = null;
            this.ip.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.ip.CustomButton.Name = "";
            this.ip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip.CustomButton.TabIndex = 1;
            this.ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip.CustomButton.UseSelectable = true;
            this.ip.CustomButton.Visible = false;
            this.ip.Lines = new string[0];
            this.ip.Location = new System.Drawing.Point(247, 63);
            this.ip.MaxLength = 32767;
            this.ip.Name = "ip";
            this.ip.PasswordChar = '\0';
            this.ip.PromptText = "Listen on IP";
            this.ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip.SelectedText = "";
            this.ip.SelectionLength = 0;
            this.ip.SelectionStart = 0;
            this.ip.ShortcutsEnabled = true;
            this.ip.Size = new System.Drawing.Size(205, 23);
            this.ip.TabIndex = 1;
            this.ip.UseSelectable = true;
            this.ip.WaterMark = "Listen on IP";
            this.ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secret
            // 
            // 
            // 
            // 
            this.secret.CustomButton.Image = null;
            this.secret.CustomButton.Location = new System.Drawing.Point(407, 1);
            this.secret.CustomButton.Name = "";
            this.secret.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.secret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secret.CustomButton.TabIndex = 1;
            this.secret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secret.CustomButton.UseSelectable = true;
            this.secret.CustomButton.Visible = false;
            this.secret.Lines = new string[0];
            this.secret.Location = new System.Drawing.Point(23, 109);
            this.secret.MaxLength = 32767;
            this.secret.Name = "secret";
            this.secret.PasswordChar = '\0';
            this.secret.PromptText = "Secret";
            this.secret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secret.SelectedText = "";
            this.secret.SelectionLength = 0;
            this.secret.SelectionStart = 0;
            this.secret.ShortcutsEnabled = true;
            this.secret.Size = new System.Drawing.Size(429, 23);
            this.secret.TabIndex = 2;
            this.secret.UseSelectable = true;
            this.secret.WaterMark = "Secret";
            this.secret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ToolTip1
            // 
            this.ToolTip1.Style = MetroFramework.MetroColorStyle.Teal;
            this.ToolTip1.StyleManager = null;
            this.ToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(377, 172);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(75, 23);
            this.st.TabIndex = 3;
            this.st.Text = "Start";
            this.st.UseSelectable = true;
            this.st.Click += new System.EventHandler(this.st_Click);
            // 
            // backlog
            // 
            // 
            // 
            // 
            this.backlog.CustomButton.Image = null;
            this.backlog.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.backlog.CustomButton.Name = "";
            this.backlog.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.backlog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.backlog.CustomButton.TabIndex = 1;
            this.backlog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backlog.CustomButton.UseSelectable = true;
            this.backlog.CustomButton.Visible = false;
            this.backlog.Lines = new string[0];
            this.backlog.Location = new System.Drawing.Point(23, 138);
            this.backlog.MaxLength = 32767;
            this.backlog.Name = "backlog";
            this.backlog.PasswordChar = '\0';
            this.backlog.PromptText = "Back log";
            this.backlog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.backlog.SelectedText = "";
            this.backlog.SelectionLength = 0;
            this.backlog.SelectionStart = 0;
            this.backlog.ShortcutsEnabled = true;
            this.backlog.Size = new System.Drawing.Size(146, 23);
            this.backlog.TabIndex = 4;
            this.backlog.UseSelectable = true;
            this.backlog.WaterMark = "Back log";
            this.backlog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.backlog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox
            // 
            // 
            // 
            // 
            this.textbox.CustomButton.Image = null;
            this.textbox.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.textbox.CustomButton.Name = "";
            this.textbox.CustomButton.Size = new System.Drawing.Size(221, 221);
            this.textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox.CustomButton.TabIndex = 1;
            this.textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox.CustomButton.UseSelectable = true;
            this.textbox.CustomButton.Visible = false;
            this.textbox.Lines = new string[0];
            this.textbox.Location = new System.Drawing.Point(23, 201);
            this.textbox.MaxLength = 32767;
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.PasswordChar = '\0';
            this.textbox.PromptText = "LOG";
            this.textbox.ReadOnly = true;
            this.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox.SelectedText = "";
            this.textbox.SelectionLength = 0;
            this.textbox.SelectionStart = 0;
            this.textbox.ShortcutsEnabled = true;
            this.textbox.Size = new System.Drawing.Size(429, 223);
            this.textbox.TabIndex = 5;
            this.textbox.UseSelectable = true;
            this.textbox.WaterMark = "LOG";
            this.textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(296, 172);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(215, 172);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 7;
            this.load.Text = "Load";
            this.load.UseSelectable = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(111, 172);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(98, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Channel Sponsor";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 447);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.backlog);
            this.Controls.Add(this.st);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.port);
            this.MaximizeBox = false;
            this.Name = "FrmTemplate";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MTProtoProxy Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox port;
        private MetroFramework.Controls.MetroTextBox ip;
        private MetroFramework.Controls.MetroTextBox secret;
        private MetroFramework.Components.MetroToolTip ToolTip1;
        private MetroFramework.Controls.MetroButton st;
        private MetroFramework.Controls.MetroTextBox backlog;
        private MetroFramework.Controls.MetroTextBox textbox;
        private MetroFramework.Controls.MetroButton save;
        private MetroFramework.Controls.MetroButton load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

