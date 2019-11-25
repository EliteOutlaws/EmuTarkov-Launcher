﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace EFT_Launcher_12
{
    public partial class MainWindow : Form
    {
        string serverFolder = "Y:/tarkov/EmuTarkov Server dev"; //string serverFolder = Environment.CurrentDirectory
        string gameFolder = "";
        Profile[] profiles = null;

        public MainWindow()
        {
            InitializeComponent();
            
            startButton.Enabled = false;
            profileEditButton.Enabled = false;
            profilesListBox.SelectedIndex = 0;
            gamePathTextBox.Text = Properties.Settings.Default.gamePath;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(Path.Combine(serverFolder, "appdata/profiles/profiles.json")))
            {  
                this.profiles = JsonConvert.DeserializeObject<Profile[]>( r.ReadToEnd() );

                foreach(Profile someProfile in profiles)
                {
                    profilesListBox.Items.Add(someProfile.email);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if(profilesListBox.SelectedIndex == 0)
            {
                MessageBox.Show("select a profile before starting !");
            }
            else
            {
                int select = profilesListBox.SelectedIndex - 1;

                string filePath = Path.Combine(gamePathTextBox.Text, "./EscapeFromTarkov.exe");
                string launchArgs = "-bC5vLmcuaS5u=eyBlbWFpbDogInVzZXIwQGpldC5jb20iLCBwYXNzd29yZDogInBhc3N3b3JkIiwgdG9nZ2xlOiB0cnVlLCB0aW1lc3RhbXA6IDEzMjE3ODA5NzYzNTM2MTQ4M30= -token="+select+" -screenmode=fullscreen";

                Process.Start(filePath, launchArgs);
            }
            
        }

        private void gamePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if( File.Exists(Path.Combine(gamePathTextBox.Text, "./EscapeFromTarkov.exe")) == true )
            {
                startButton.Enabled = true;
                gamePathTextBox.ForeColor = Color.White;

                Properties.Settings.Default.gamePath = gamePathTextBox.Text;
                Properties.Settings.Default.Save();

                gameFolder = gamePathTextBox.Text;
            }
            else
            {
                startButton.Enabled = false;
                gamePathTextBox.ForeColor = Color.Red;
            }
        }

        private void profilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(profilesListBox.SelectedIndex != 0)
            {
                profileEditButton.Enabled = true;
            }
            else
            {
                profileEditButton.Enabled = false;
            }
        }

        private void profileEditButton_Click(object sender, EventArgs e)
        {
            EditProfileForm edit = new EditProfileForm(profilesListBox.SelectedIndex - 1);
            edit.Show();
        }
    }

    internal class Profile
    {
        public string email { get; set; }
        public string password { get; set; }
        public string password_md5 { get; set; }
        public int id { get; set; }
        public int timestamp { get; set; }
        public bool online { get; set; }
    }
}
