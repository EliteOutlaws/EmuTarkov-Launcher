

namespace JustEmuTarkovLauncher
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btn_loginIn = new MetroFramework.Controls.MetroButton();
            this.btn_restartClientConfig = new MetroFramework.Controls.MetroButton();
            this.btn_startgame = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.inp_password = new MetroFramework.Controls.MetroTextBox();
            this.inp_login = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_portChange = new MetroFramework.Controls.MetroLabel();
            this.inp_portChange = new MetroFramework.Controls.MetroTextBox();
            this.lbl_serverLocation = new MetroFramework.Controls.MetroLabel();
            this.inp_serverLocation = new MetroFramework.Controls.MetroTextBox();
            this.inp_gameLocation = new MetroFramework.Controls.MetroTextBox();
            this.lbl_gameLocation = new MetroFramework.Controls.MetroLabel();
            this.Link_1 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(98, 318);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(475, 19);
            this.label.TabIndex = 17;
            this.label.Text = "And why you do this? Do you really want to broke it? Greetings from TheMaoci. ";
            this.label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.Black;
            this.metroPanel3.Controls.Add(this.btn_loginIn);
            this.metroPanel3.Controls.Add(this.btn_restartClientConfig);
            this.metroPanel3.Controls.Add(this.btn_startgame);
            this.metroPanel3.Controls.Add(this.metroPanel2);
            this.metroPanel3.Controls.Add(this.metroPanel1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 4;
            this.metroPanel3.Location = new System.Drawing.Point(11, 74);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(589, 237);
            this.metroPanel3.TabIndex = 21;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 5;
            // 
            // btn_loginIn
            // 
            this.btn_loginIn.Enabled = false;
            this.btn_loginIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_loginIn.Location = new System.Drawing.Point(252, 7);
            this.btn_loginIn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_loginIn.Name = "btn_loginIn";
            this.btn_loginIn.Size = new System.Drawing.Size(114, 40);
            this.btn_loginIn.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_loginIn.TabIndex = 27;
            this.btn_loginIn.Text = "Edit Profile";
            this.btn_loginIn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_loginIn.UseSelectable = true;
            this.btn_loginIn.Click += new System.EventHandler(this.Click_btn_loginIn);
            // 
            // btn_restartClientConfig
            // 
            this.btn_restartClientConfig.Enabled = false;
            this.btn_restartClientConfig.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_restartClientConfig.Location = new System.Drawing.Point(370, 7);
            this.btn_restartClientConfig.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_restartClientConfig.Name = "btn_restartClientConfig";
            this.btn_restartClientConfig.Size = new System.Drawing.Size(210, 40);
            this.btn_restartClientConfig.TabIndex = 24;
            this.btn_restartClientConfig.Text = "Reverse Client Changes";
            this.btn_restartClientConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_restartClientConfig.UseSelectable = true;
            this.btn_restartClientConfig.Click += new System.EventHandler(this.Click_RestartClient);
            // 
            // btn_startgame
            // 
            this.btn_startgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_startgame.Enabled = false;
            this.btn_startgame.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_startgame.Location = new System.Drawing.Point(38, 160);
            this.btn_startgame.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_startgame.Name = "btn_startgame";
            this.btn_startgame.Size = new System.Drawing.Size(161, 51);
            this.btn_startgame.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_startgame.TabIndex = 23;
            this.btn_startgame.Text = "Start Game";
            this.btn_startgame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_startgame.UseSelectable = true;
            this.btn_startgame.Click += new System.EventHandler(this.Click_btn_startgame);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.inp_password);
            this.metroPanel2.Controls.Add(this.inp_login);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 7;
            this.metroPanel2.Location = new System.Drawing.Point(14, 52);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(208, 83);
            this.metroPanel2.TabIndex = 22;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 45);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Password:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 17);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Login:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inp_password
            // 
            // 
            // 
            // 
            this.inp_password.CustomButton.Image = null;
            this.inp_password.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.inp_password.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_password.CustomButton.Name = "";
            this.inp_password.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.inp_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inp_password.CustomButton.TabIndex = 1;
            this.inp_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inp_password.CustomButton.UseSelectable = true;
            this.inp_password.CustomButton.Visible = false;
            this.inp_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.inp_password.Lines = new string[] {
        "password"};
            this.inp_password.Location = new System.Drawing.Point(80, 43);
            this.inp_password.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_password.MaxLength = 32767;
            this.inp_password.Name = "inp_password";
            this.inp_password.PasswordChar = '*';
            this.inp_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inp_password.SelectedText = "";
            this.inp_password.SelectionLength = 0;
            this.inp_password.SelectionStart = 0;
            this.inp_password.ShortcutsEnabled = true;
            this.inp_password.Size = new System.Drawing.Size(115, 25);
            this.inp_password.TabIndex = 12;
            this.inp_password.Text = "password";
            this.inp_password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inp_password.UseSelectable = true;
            this.inp_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inp_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // inp_login
            // 
            // 
            // 
            // 
            this.inp_login.CustomButton.Image = null;
            this.inp_login.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.inp_login.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_login.CustomButton.Name = "";
            this.inp_login.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.inp_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inp_login.CustomButton.TabIndex = 1;
            this.inp_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inp_login.CustomButton.UseSelectable = true;
            this.inp_login.CustomButton.Visible = false;
            this.inp_login.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.inp_login.Lines = new string[] {
        "user0@jet.com"};
            this.inp_login.Location = new System.Drawing.Point(80, 14);
            this.inp_login.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_login.MaxLength = 32767;
            this.inp_login.Name = "inp_login";
            this.inp_login.PasswordChar = '\0';
            this.inp_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inp_login.SelectedText = "";
            this.inp_login.SelectionLength = 0;
            this.inp_login.SelectionStart = 0;
            this.inp_login.ShortcutsEnabled = true;
            this.inp_login.Size = new System.Drawing.Size(115, 25);
            this.inp_login.TabIndex = 11;
            this.inp_login.Text = "user0@jet.com";
            this.inp_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inp_login.UseSelectable = true;
            this.inp_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inp_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Black;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lbl_portChange);
            this.metroPanel1.Controls.Add(this.inp_portChange);
            this.metroPanel1.Controls.Add(this.lbl_serverLocation);
            this.metroPanel1.Controls.Add(this.inp_serverLocation);
            this.metroPanel1.Controls.Add(this.inp_gameLocation);
            this.metroPanel1.Controls.Add(this.lbl_gameLocation);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 7;
            this.metroPanel1.Location = new System.Drawing.Point(227, 52);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(352, 180);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 6;
            // 
            // lbl_portChange
            // 
            this.lbl_portChange.AutoSize = true;
            this.lbl_portChange.Location = new System.Drawing.Point(8, 116);
            this.lbl_portChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_portChange.Name = "lbl_portChange";
            this.lbl_portChange.Size = new System.Drawing.Size(95, 19);
            this.lbl_portChange.TabIndex = 28;
            this.lbl_portChange.Text = "Port (disabled)";
            this.lbl_portChange.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inp_portChange
            // 
            // 
            // 
            // 
            this.inp_portChange.CustomButton.Image = null;
            this.inp_portChange.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.inp_portChange.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_portChange.CustomButton.Name = "";
            this.inp_portChange.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.inp_portChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inp_portChange.CustomButton.TabIndex = 1;
            this.inp_portChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inp_portChange.CustomButton.UseSelectable = true;
            this.inp_portChange.CustomButton.Visible = false;
            this.inp_portChange.Enabled = false;
            this.inp_portChange.Lines = new string[0];
            this.inp_portChange.Location = new System.Drawing.Point(18, 136);
            this.inp_portChange.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_portChange.MaxLength = 4;
            this.inp_portChange.Name = "inp_portChange";
            this.inp_portChange.PasswordChar = '\0';
            this.inp_portChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inp_portChange.SelectedText = "";
            this.inp_portChange.SelectionLength = 0;
            this.inp_portChange.SelectionStart = 0;
            this.inp_portChange.ShortcutsEnabled = true;
            this.inp_portChange.Size = new System.Drawing.Size(60, 25);
            this.inp_portChange.TabIndex = 27;
            this.inp_portChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inp_portChange.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inp_portChange.UseSelectable = true;
            this.inp_portChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inp_portChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inp_portChange.TextChanged += new System.EventHandler(this.TextChanged_portChange);
            // 
            // lbl_serverLocation
            // 
            this.lbl_serverLocation.AutoSize = true;
            this.lbl_serverLocation.Location = new System.Drawing.Point(8, 56);
            this.lbl_serverLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_serverLocation.Name = "lbl_serverLocation";
            this.lbl_serverLocation.Size = new System.Drawing.Size(100, 19);
            this.lbl_serverLocation.TabIndex = 10;
            this.lbl_serverLocation.Text = "Server location:";
            this.lbl_serverLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inp_serverLocation
            // 
            // 
            // 
            // 
            this.inp_serverLocation.CustomButton.Image = null;
            this.inp_serverLocation.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.inp_serverLocation.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_serverLocation.CustomButton.Name = "";
            this.inp_serverLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.inp_serverLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inp_serverLocation.CustomButton.TabIndex = 1;
            this.inp_serverLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inp_serverLocation.CustomButton.UseSelectable = true;
            this.inp_serverLocation.CustomButton.Visible = false;
            this.inp_serverLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.inp_serverLocation.ForeColor = System.Drawing.Color.Black;
            this.inp_serverLocation.Lines = new string[] {
        "C:/serverdirectory/"};
            this.inp_serverLocation.Location = new System.Drawing.Point(18, 77);
            this.inp_serverLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_serverLocation.MaxLength = 32767;
            this.inp_serverLocation.Name = "inp_serverLocation";
            this.inp_serverLocation.PasswordChar = '\0';
            this.inp_serverLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inp_serverLocation.SelectedText = "";
            this.inp_serverLocation.SelectionLength = 0;
            this.inp_serverLocation.SelectionStart = 0;
            this.inp_serverLocation.ShortcutsEnabled = true;
            this.inp_serverLocation.Size = new System.Drawing.Size(316, 25);
            this.inp_serverLocation.TabIndex = 9;
            this.inp_serverLocation.Text = "C:/serverdirectory/";
            this.inp_serverLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inp_serverLocation.UseSelectable = true;
            this.inp_serverLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inp_serverLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inp_serverLocation.TextChanged += new System.EventHandler(this.InputChanged_TextBoxServer);
            // 
            // inp_gameLocation
            // 
            // 
            // 
            // 
            this.inp_gameLocation.CustomButton.Image = null;
            this.inp_gameLocation.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.inp_gameLocation.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inp_gameLocation.CustomButton.Name = "";
            this.inp_gameLocation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.inp_gameLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inp_gameLocation.CustomButton.TabIndex = 1;
            this.inp_gameLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inp_gameLocation.CustomButton.UseSelectable = true;
            this.inp_gameLocation.CustomButton.Visible = false;
            this.inp_gameLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.inp_gameLocation.ForeColor = System.Drawing.Color.Black;
            this.inp_gameLocation.Lines = new string[] {
        "C:/gamedirectory/"};
            this.inp_gameLocation.Location = new System.Drawing.Point(18, 27);
            this.inp_gameLocation.Margin = new System.Windows.Forms.Padding(6);
            this.inp_gameLocation.MaxLength = 32767;
            this.inp_gameLocation.Name = "inp_gameLocation";
            this.inp_gameLocation.PasswordChar = '\0';
            this.inp_gameLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inp_gameLocation.SelectedText = "";
            this.inp_gameLocation.SelectionLength = 0;
            this.inp_gameLocation.SelectionStart = 0;
            this.inp_gameLocation.ShortcutsEnabled = true;
            this.inp_gameLocation.Size = new System.Drawing.Size(316, 25);
            this.inp_gameLocation.TabIndex = 8;
            this.inp_gameLocation.Text = "C:/gamedirectory/";
            this.inp_gameLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inp_gameLocation.UseSelectable = true;
            this.inp_gameLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inp_gameLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inp_gameLocation.TextChanged += new System.EventHandler(this.InputChanged_TextBoxGame);
            // 
            // lbl_gameLocation
            // 
            this.lbl_gameLocation.AutoSize = true;
            this.lbl_gameLocation.Location = new System.Drawing.Point(8, 9);
            this.lbl_gameLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gameLocation.Name = "lbl_gameLocation";
            this.lbl_gameLocation.Size = new System.Drawing.Size(97, 19);
            this.lbl_gameLocation.TabIndex = 7;
            this.lbl_gameLocation.Text = "Game location:";
            this.lbl_gameLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Link_1
            // 
            this.Link_1.Enabled = false;
            this.Link_1.Location = new System.Drawing.Point(382, 51);
            this.Link_1.Name = "Link_1";
            this.Link_1.Size = new System.Drawing.Size(219, 23);
            this.Link_1.Style = MetroFramework.MetroColorStyle.Black;
            this.Link_1.TabIndex = 22;
            this.Link_1.Text = "Download Client: https://maoci.eu/eft";
            this.Link_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Link_1.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Enabled = false;
            this.metroLink1.Location = new System.Drawing.Point(11, 50);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(257, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLink1.TabIndex = 23;
            this.metroLink1.Text = "Website: https://justemutarkov.github.io";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 321);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.Link_1);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 339);
            this.MinimumSize = new System.Drawing.Size(610, 321);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(8, 61, 8, 9);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "JustEmuTarkov - Launcher 0.2.0";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.White;
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btn_restartClientConfig;
        private MetroFramework.Controls.MetroButton btn_startgame;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox inp_password;
        private MetroFramework.Controls.MetroTextBox inp_login;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_serverLocation;
        private MetroFramework.Controls.MetroTextBox inp_serverLocation;
        private MetroFramework.Controls.MetroLabel lbl_gameLocation;
        private MetroFramework.Controls.MetroTextBox inp_gameLocation;
        private MetroFramework.Controls.MetroButton btn_loginIn;
        private MetroFramework.Controls.MetroLabel lbl_portChange;
        private MetroFramework.Controls.MetroTextBox inp_portChange;
        private MetroFramework.Controls.MetroLink Link_1;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

