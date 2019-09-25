namespace JustEmuTarkovLauncher
{
    partial class AccountEditor
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
            this.btn_goBack = new MetroFramework.Controls.MetroButton();
            this.panel_accountData = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ipt_emailEdit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ipt_passwordEdit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ipt_nicknameEdit = new MetroFramework.Controls.MetroTextBox();
            this.btn_saveProfile = new MetroFramework.Controls.MetroButton();
            this.panel_editAppeariance = new MetroFramework.Controls.MetroPanel();
            this.image_legs = new MetroFramework.Controls.MetroLink();
            this.image_hands = new MetroFramework.Controls.MetroLink();
            this.image_body = new MetroFramework.Controls.MetroLink();
            this.image_head = new MetroFramework.Controls.MetroLink();
            this.btn_saveAppeariance = new MetroFramework.Controls.MetroButton();
            this.lbl_legs = new MetroFramework.Controls.MetroLabel();
            this.sel_legs = new MetroFramework.Controls.MetroComboBox();
            this.lbl_hands = new MetroFramework.Controls.MetroLabel();
            this.sel_hands = new MetroFramework.Controls.MetroComboBox();
            this.lbl_body = new MetroFramework.Controls.MetroLabel();
            this.sel_body = new MetroFramework.Controls.MetroComboBox();
            this.lbl_head = new MetroFramework.Controls.MetroLabel();
            this.sel_head = new MetroFramework.Controls.MetroComboBox();
            this.panel_accountData.SuspendLayout();
            this.panel_editAppeariance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(586, 41);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(95, 35);
            this.btn_goBack.TabIndex = 0;
            this.btn_goBack.Text = "Go Back >";
            this.btn_goBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_goBack.UseSelectable = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // panel_accountData
            // 
            this.panel_accountData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_accountData.Controls.Add(this.metroLabel3);
            this.panel_accountData.Controls.Add(this.ipt_emailEdit);
            this.panel_accountData.Controls.Add(this.metroLabel2);
            this.panel_accountData.Controls.Add(this.ipt_passwordEdit);
            this.panel_accountData.Controls.Add(this.metroLabel1);
            this.panel_accountData.Controls.Add(this.ipt_nicknameEdit);
            this.panel_accountData.Controls.Add(this.btn_saveProfile);
            this.panel_accountData.HorizontalScrollbarBarColor = true;
            this.panel_accountData.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_accountData.HorizontalScrollbarSize = 10;
            this.panel_accountData.Location = new System.Drawing.Point(23, 83);
            this.panel_accountData.Name = "panel_accountData";
            this.panel_accountData.Size = new System.Drawing.Size(263, 151);
            this.panel_accountData.TabIndex = 1;
            this.panel_accountData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_accountData.VerticalScrollbarBarColor = true;
            this.panel_accountData.VerticalScrollbarHighlightOnWheel = false;
            this.panel_accountData.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Login(email)";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ipt_emailEdit
            // 
            // 
            // 
            // 
            this.ipt_emailEdit.CustomButton.Image = null;
            this.ipt_emailEdit.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.ipt_emailEdit.CustomButton.Name = "";
            this.ipt_emailEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ipt_emailEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ipt_emailEdit.CustomButton.TabIndex = 1;
            this.ipt_emailEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ipt_emailEdit.CustomButton.UseSelectable = true;
            this.ipt_emailEdit.CustomButton.Visible = false;
            this.ipt_emailEdit.Lines = new string[0];
            this.ipt_emailEdit.Location = new System.Drawing.Point(99, 70);
            this.ipt_emailEdit.MaxLength = 32767;
            this.ipt_emailEdit.Name = "ipt_emailEdit";
            this.ipt_emailEdit.PasswordChar = '\0';
            this.ipt_emailEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipt_emailEdit.SelectedText = "";
            this.ipt_emailEdit.SelectionLength = 0;
            this.ipt_emailEdit.SelectionStart = 0;
            this.ipt_emailEdit.ShortcutsEnabled = true;
            this.ipt_emailEdit.Size = new System.Drawing.Size(144, 23);
            this.ipt_emailEdit.TabIndex = 7;
            this.ipt_emailEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ipt_emailEdit.UseSelectable = true;
            this.ipt_emailEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipt_emailEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ipt_passwordEdit
            // 
            // 
            // 
            // 
            this.ipt_passwordEdit.CustomButton.Image = null;
            this.ipt_passwordEdit.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.ipt_passwordEdit.CustomButton.Name = "";
            this.ipt_passwordEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ipt_passwordEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ipt_passwordEdit.CustomButton.TabIndex = 1;
            this.ipt_passwordEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ipt_passwordEdit.CustomButton.UseSelectable = true;
            this.ipt_passwordEdit.CustomButton.Visible = false;
            this.ipt_passwordEdit.Lines = new string[0];
            this.ipt_passwordEdit.Location = new System.Drawing.Point(99, 41);
            this.ipt_passwordEdit.MaxLength = 32767;
            this.ipt_passwordEdit.Name = "ipt_passwordEdit";
            this.ipt_passwordEdit.PasswordChar = '\0';
            this.ipt_passwordEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipt_passwordEdit.SelectedText = "";
            this.ipt_passwordEdit.SelectionLength = 0;
            this.ipt_passwordEdit.SelectionStart = 0;
            this.ipt_passwordEdit.ShortcutsEnabled = true;
            this.ipt_passwordEdit.Size = new System.Drawing.Size(144, 23);
            this.ipt_passwordEdit.TabIndex = 5;
            this.ipt_passwordEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ipt_passwordEdit.UseSelectable = true;
            this.ipt_passwordEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipt_passwordEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nickname";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ipt_nicknameEdit
            // 
            // 
            // 
            // 
            this.ipt_nicknameEdit.CustomButton.Image = null;
            this.ipt_nicknameEdit.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.ipt_nicknameEdit.CustomButton.Name = "";
            this.ipt_nicknameEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ipt_nicknameEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ipt_nicknameEdit.CustomButton.TabIndex = 1;
            this.ipt_nicknameEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ipt_nicknameEdit.CustomButton.UseSelectable = true;
            this.ipt_nicknameEdit.CustomButton.Visible = false;
            this.ipt_nicknameEdit.Lines = new string[0];
            this.ipt_nicknameEdit.Location = new System.Drawing.Point(99, 12);
            this.ipt_nicknameEdit.MaxLength = 32767;
            this.ipt_nicknameEdit.Name = "ipt_nicknameEdit";
            this.ipt_nicknameEdit.PasswordChar = '\0';
            this.ipt_nicknameEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipt_nicknameEdit.SelectedText = "";
            this.ipt_nicknameEdit.SelectionLength = 0;
            this.ipt_nicknameEdit.SelectionStart = 0;
            this.ipt_nicknameEdit.ShortcutsEnabled = true;
            this.ipt_nicknameEdit.Size = new System.Drawing.Size(144, 23);
            this.ipt_nicknameEdit.TabIndex = 3;
            this.ipt_nicknameEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ipt_nicknameEdit.UseSelectable = true;
            this.ipt_nicknameEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipt_nicknameEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_saveProfile
            // 
            this.btn_saveProfile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_saveProfile.Location = new System.Drawing.Point(84, 106);
            this.btn_saveProfile.Name = "btn_saveProfile";
            this.btn_saveProfile.Size = new System.Drawing.Size(94, 29);
            this.btn_saveProfile.TabIndex = 2;
            this.btn_saveProfile.Text = "Save Data";
            this.btn_saveProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_saveProfile.UseSelectable = true;
            this.btn_saveProfile.Click += new System.EventHandler(this.SaveProfile_Click);
            // 
            // panel_editAppeariance
            // 
            this.panel_editAppeariance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_editAppeariance.Controls.Add(this.image_legs);
            this.panel_editAppeariance.Controls.Add(this.image_hands);
            this.panel_editAppeariance.Controls.Add(this.image_body);
            this.panel_editAppeariance.Controls.Add(this.image_head);
            this.panel_editAppeariance.Controls.Add(this.btn_saveAppeariance);
            this.panel_editAppeariance.Controls.Add(this.lbl_legs);
            this.panel_editAppeariance.Controls.Add(this.sel_legs);
            this.panel_editAppeariance.Controls.Add(this.lbl_hands);
            this.panel_editAppeariance.Controls.Add(this.sel_hands);
            this.panel_editAppeariance.Controls.Add(this.lbl_body);
            this.panel_editAppeariance.Controls.Add(this.sel_body);
            this.panel_editAppeariance.Controls.Add(this.lbl_head);
            this.panel_editAppeariance.Controls.Add(this.sel_head);
            this.panel_editAppeariance.HorizontalScrollbarBarColor = true;
            this.panel_editAppeariance.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_editAppeariance.HorizontalScrollbarSize = 10;
            this.panel_editAppeariance.Location = new System.Drawing.Point(292, 83);
            this.panel_editAppeariance.Name = "panel_editAppeariance";
            this.panel_editAppeariance.Size = new System.Drawing.Size(389, 314);
            this.panel_editAppeariance.TabIndex = 3;
            this.panel_editAppeariance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_editAppeariance.VerticalScrollbarBarColor = true;
            this.panel_editAppeariance.VerticalScrollbarHighlightOnWheel = false;
            this.panel_editAppeariance.VerticalScrollbarSize = 10;
            // 
            // image_legs
            // 
            this.image_legs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_legs.Location = new System.Drawing.Point(255, 167);
            this.image_legs.Name = "image_legs";
            this.image_legs.Size = new System.Drawing.Size(121, 81);
            this.image_legs.TabIndex = 15;
            this.image_legs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.image_legs.UseSelectable = true;
            // 
            // image_hands
            // 
            this.image_hands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_hands.Location = new System.Drawing.Point(53, 167);
            this.image_hands.Name = "image_hands";
            this.image_hands.Size = new System.Drawing.Size(121, 81);
            this.image_hands.TabIndex = 14;
            this.image_hands.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.image_hands.UseSelectable = true;
            // 
            // image_body
            // 
            this.image_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_body.Location = new System.Drawing.Point(255, 45);
            this.image_body.Name = "image_body";
            this.image_body.Size = new System.Drawing.Size(121, 81);
            this.image_body.TabIndex = 13;
            this.image_body.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.image_body.UseSelectable = true;
            // 
            // image_head
            // 
            this.image_head.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_head.Location = new System.Drawing.Point(53, 41);
            this.image_head.Name = "image_head";
            this.image_head.Size = new System.Drawing.Size(121, 81);
            this.image_head.TabIndex = 12;
            this.image_head.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.image_head.UseSelectable = true;
            // 
            // btn_saveAppeariance
            // 
            this.btn_saveAppeariance.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_saveAppeariance.Location = new System.Drawing.Point(146, 276);
            this.btn_saveAppeariance.Name = "btn_saveAppeariance";
            this.btn_saveAppeariance.Size = new System.Drawing.Size(94, 29);
            this.btn_saveAppeariance.TabIndex = 11;
            this.btn_saveAppeariance.Text = "Save Data";
            this.btn_saveAppeariance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_saveAppeariance.UseSelectable = true;
            this.btn_saveAppeariance.Click += new System.EventHandler(this.SaveAppeariance_Click);
            // 
            // lbl_legs
            // 
            this.lbl_legs.AutoSize = true;
            this.lbl_legs.Location = new System.Drawing.Point(215, 137);
            this.lbl_legs.Name = "lbl_legs";
            this.lbl_legs.Size = new System.Drawing.Size(35, 19);
            this.lbl_legs.TabIndex = 10;
            this.lbl_legs.Text = "Legs";
            this.lbl_legs.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sel_legs
            // 
            this.sel_legs.FormattingEnabled = true;
            this.sel_legs.ItemHeight = 23;
            this.sel_legs.Location = new System.Drawing.Point(255, 132);
            this.sel_legs.Name = "sel_legs";
            this.sel_legs.Size = new System.Drawing.Size(121, 29);
            this.sel_legs.TabIndex = 9;
            this.sel_legs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sel_legs.UseSelectable = true;
            this.sel_legs.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_ApearianceSelector);
            // 
            // lbl_hands
            // 
            this.lbl_hands.AutoSize = true;
            this.lbl_hands.Location = new System.Drawing.Point(3, 137);
            this.lbl_hands.Name = "lbl_hands";
            this.lbl_hands.Size = new System.Drawing.Size(45, 19);
            this.lbl_hands.TabIndex = 8;
            this.lbl_hands.Text = "Hands";
            this.lbl_hands.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sel_hands
            // 
            this.sel_hands.FormattingEnabled = true;
            this.sel_hands.ItemHeight = 23;
            this.sel_hands.Location = new System.Drawing.Point(53, 132);
            this.sel_hands.Name = "sel_hands";
            this.sel_hands.Size = new System.Drawing.Size(121, 29);
            this.sel_hands.TabIndex = 7;
            this.sel_hands.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sel_hands.UseSelectable = true;
            this.sel_hands.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_ApearianceSelector);
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Location = new System.Drawing.Point(211, 15);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(39, 19);
            this.lbl_body.TabIndex = 6;
            this.lbl_body.Text = "Body";
            this.lbl_body.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sel_body
            // 
            this.sel_body.FormattingEnabled = true;
            this.sel_body.ItemHeight = 23;
            this.sel_body.Location = new System.Drawing.Point(255, 10);
            this.sel_body.Name = "sel_body";
            this.sel_body.Size = new System.Drawing.Size(121, 29);
            this.sel_body.TabIndex = 5;
            this.sel_body.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sel_body.UseSelectable = true;
            this.sel_body.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_ApearianceSelector);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Location = new System.Drawing.Point(8, 15);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(40, 19);
            this.lbl_head.TabIndex = 4;
            this.lbl_head.Text = "Head";
            this.lbl_head.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // sel_head
            // 
            this.sel_head.FormattingEnabled = true;
            this.sel_head.ItemHeight = 23;
            this.sel_head.Location = new System.Drawing.Point(53, 10);
            this.sel_head.Name = "sel_head";
            this.sel_head.Size = new System.Drawing.Size(121, 29);
            this.sel_head.TabIndex = 3;
            this.sel_head.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sel_head.UseSelectable = true;
            this.sel_head.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_ApearianceSelector);
            // 
            // AccountEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 415);
            this.Controls.Add(this.panel_editAppeariance);
            this.Controls.Add(this.panel_accountData);
            this.Controls.Add(this.btn_goBack);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 415);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 415);
            this.Name = "AccountEditor";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "AccountEditor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel_accountData.ResumeLayout(false);
            this.panel_accountData.PerformLayout();
            this.panel_editAppeariance.ResumeLayout(false);
            this.panel_editAppeariance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_goBack;
        private MetroFramework.Controls.MetroPanel panel_accountData;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox ipt_emailEdit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ipt_passwordEdit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ipt_nicknameEdit;
        private MetroFramework.Controls.MetroButton btn_saveProfile;
        private MetroFramework.Controls.MetroPanel panel_editAppeariance;
        private MetroFramework.Controls.MetroLink image_legs;
        private MetroFramework.Controls.MetroLink image_hands;
        private MetroFramework.Controls.MetroLink image_body;
        private MetroFramework.Controls.MetroLink image_head;
        private MetroFramework.Controls.MetroButton btn_saveAppeariance;
        private MetroFramework.Controls.MetroLabel lbl_legs;
        private MetroFramework.Controls.MetroComboBox sel_legs;
        private MetroFramework.Controls.MetroLabel lbl_hands;
        private MetroFramework.Controls.MetroComboBox sel_hands;
        private MetroFramework.Controls.MetroLabel lbl_body;
        private MetroFramework.Controls.MetroComboBox sel_body;
        private MetroFramework.Controls.MetroLabel lbl_head;
        private MetroFramework.Controls.MetroComboBox sel_head;
    }
}