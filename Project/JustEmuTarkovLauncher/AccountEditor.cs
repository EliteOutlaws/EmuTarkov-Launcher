using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustEmuTarkovLauncher.Functions;
using JustEmuTarkovLauncher.Properties;
using MetroFramework.Controls;

namespace JustEmuTarkovLauncher
{
    public partial class AccountEditor : MetroFramework.Forms.MetroForm
    {
        private RWJson rwj = new RWJson();
        LauncherConfig l_conf;
        ClientHandling c_conf;
        ServerHandling s_conf;
        private int Found_ID = -1;
        #region Appeariance
        private string[] Head = { "bear_head", "bear_head_1", "head_boss_killa", "usec_head", "usec_head_1", "wild_dealmaker_head", "wild_head", "wild_head_1", "wild_head_2", "wild_head_3" };
        private string[] Hand = { "bear_hands_skin", "usec_hands_skin", "wild_body_1_firsthands", "wild_body_2_firsthands", "wild_body_3_firsthands", "wild_body_firsthands" };
        private string[] Legs = { "bear_feet", "bear_feet_1", "pant_boss_killa", "pants_wild_scavelite", "usec_feet", "wild_dealmaker_feet", "wild_feet", "wild_feet_1", "wild_feet_2", "wild_security_feet_1" };
        private string[] Body = { "bear_body", "top_boss_killa", "top_wild_scavelite", "usec_body", "wild_body", "wild_body_1", "wild_body_2", "wild_body_3", "wild_dealmaker_body", "wild_security_body_1", "wild_security_body_2" };
        #endregion
        private string login;
        private string password;
        #region Select Options - class
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        #endregion
        private void MessageBox(string Message, string Title = "", MessageBoxIcon Type = MessageBoxIcon.Information, MessageBoxButtons Buttons = MessageBoxButtons.OK)
        {
            MetroFramework.MetroMessageBox.Show(
                this,
                "\n" + Message, Title,
                Buttons,
                Type
            );
        }
         public AccountEditor(int FID, string l, string p, string cConfig, string sConfig)
        {
            this.Found_ID = FID;
            if (this.Found_ID != -1)
            {
                // inicializators
                this.login = l;
                this.password = p;
                this.s_conf = new ServerHandling();
                this.c_conf = new ClientHandling();
                this.l_conf = new LauncherConfig();
                this.c_conf.main_SetClientPath(cConfig);
                this.s_conf.main_SetServerPath(sConfig);
                this.l_conf.setGameDirectory(c_conf.main_GetClientPath());
                this.l_conf.setServerDirectory(s_conf.main_GetServerPath());

                InitializeComponent();
                PrepareSelectors();
                LoadProfile();

            }

        }
        #region Load Profile Data
        private void LoadProfile()
        {
            dynamic data_server_profile = rwj.ReadJArrayFile(l_conf.getServerDirectory() + @"\data\profiles\profiles.json");
            for (int i = 0; i < data_server_profile.Count; i++)
            {
                if (data_server_profile[i].email == login && data_server_profile[i].password == password)
                {
                    Found_ID = data_server_profile[i].id;
                }
            }
            dynamic data_load_profile = rwj.ReadJObjectFile(l_conf.getServerDirectory() + @"\data\profiles\character_" + Found_ID + ".json");
            // later update this ;)
            string char_head = (data_load_profile.Customization.Head.path).ToString().Split('/')[5].Replace(".bundle", "");
            string char_body = (data_load_profile.Customization.Body.path).ToString().Split('/')[5].Replace(".bundle", "");
            string char_legs = (data_load_profile.Customization.Feet.path).ToString().Split('/')[5].Replace(".bundle", "");
            string char_hand = (data_load_profile.Customization.Hands.path).ToString().Split('/')[4].Replace(".bundle", "");
            for (int i = 0; i < Body.Length; i++)
            {
                if (char_body == Body[i])
                    sel_body.SelectedIndex = i;
            }
            for (int i = 0; i < Head.Length; i++)
            {
                if (char_head == Head[i])
                    sel_head.SelectedIndex = i;
            }
            for (int i = 0; i < Hand.Length; i++)
            {
                if (char_hand == Hand[i])
                    sel_hands.SelectedIndex = i;
            }
            for (int i = 0; i < Legs.Length; i++)
            {
                if (char_legs == Legs[i])
                    sel_legs.SelectedIndex = i;
            }
            ipt_nicknameEdit.Text = (data_load_profile.Info.Nickname).ToString();
            ipt_emailEdit.Text = (data_server_profile[Found_ID].email).ToString();
            ipt_passwordEdit.Text = (data_server_profile[Found_ID].password).ToString();
            // initial done
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.body." + Body[sel_body.SelectedIndex] + ".png");
            image_body.BackgroundImage = Image.FromStream(stream);
            stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.head." + Head[sel_head.SelectedIndex] + ".png");
            image_head.BackgroundImage = Image.FromStream(stream);
            stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.hands." + Hand[sel_hands.SelectedIndex] + ".png");
            image_hands.BackgroundImage = Image.FromStream(stream);
            stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.legs." + Legs[sel_legs.SelectedIndex] + ".png");
            image_legs.BackgroundImage = Image.FromStream(stream);
            image_body.BackgroundImageLayout = ImageLayout.Zoom;
            image_head.BackgroundImageLayout = ImageLayout.Zoom;
            image_hands.BackgroundImageLayout = ImageLayout.Zoom;
            image_legs.BackgroundImageLayout = ImageLayout.Zoom;
        }
        #endregion
        #region Prepare Selectors
        private void PrepareSelectors()
        {
            for (int i = 0; i < Body.Length; i++)
            {
                sel_body.Items.Add(new Item(Body[i], i));
            }
            for (int i = 0; i < Head.Length; i++)
            {
                sel_head.Items.Add(new Item(Head[i], i));
            }
            for (int i = 0; i < Hand.Length; i++)
            {
                sel_hands.Items.Add(new Item(Hand[i], i));
            }
            for (int i = 0; i < Legs.Length; i++)
            {
                sel_legs.Items.Add(new Item(Legs[i], i));
            }
        }
        #endregion
        #region Close Form button
        private void btn_goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Save Profile
        private void SaveProfile_Click(object sender, EventArgs e)
        {
            dynamic data_server_profile = rwj.ReadJArrayFile(l_conf.getServerDirectory() + @"\data\profiles\profiles.json");
            data_server_profile[Found_ID].email = ipt_emailEdit.Text;
            data_server_profile[Found_ID].password = ipt_passwordEdit.Text;
            dynamic data_load_profile = rwj.ReadJObjectFile(l_conf.getServerDirectory() + @"\data\profiles\character_" + Found_ID + ".json");
            data_load_profile.Info.Nickname = ipt_nicknameEdit.Text;
            rwj.WriteJsonFile(l_conf.getServerDirectory() + @"\data\profiles\profiles.json", data_server_profile);
            rwj.WriteJsonFile(l_conf.getServerDirectory() + @"\data\profiles\character_" + Found_ID + ".json", data_load_profile);
            MessageBox("Profile data saved Succesfully", "Profile", MessageBoxIcon.Information, MessageBoxButtons.OK);
        }
        #endregion
        #region Save Appeariance
        private void SaveAppeariance_Click(object sender, EventArgs e)
        {
            string toChange_legs = "assets/content/characters/character/prefabs/" + sel_legs.SelectedItem.ToString() + ".bundle";
            string toChange_head = "assets/content/characters/character/prefabs/" + sel_head.SelectedItem.ToString() + ".bundle";
            string toChange_body = "assets/content/characters/character/prefabs/" + sel_body.SelectedItem.ToString() + ".bundle";
            string toChange_hands = "assets/content/hands/" + sel_hands.SelectedItem.ToString().Substring(0, 4) + "/" + sel_hands.SelectedItem.ToString() + ".bundle";

            dynamic data_load_profile = rwj.ReadJObjectFile(l_conf.getServerDirectory() + @"\data\profiles\character_" + Found_ID + ".json");

            data_load_profile.Customization.Head.path = toChange_head;
            data_load_profile.Customization.Body.path = toChange_body;
            data_load_profile.Customization.Feet.path = toChange_legs;
            data_load_profile.Customization.Hands.path = toChange_hands;

            rwj.WriteJsonFile(l_conf.getServerDirectory() + @"\data\profiles\character_" + Found_ID + ".json", data_load_profile);

            MessageBox("Appeariance Saved Succesfully", "Appeariance", MessageBoxIcon.Information, MessageBoxButtons.OK);
        }
        #endregion
        private void SelectedIndexChanged_ApearianceSelector(object sender, EventArgs e)
        {
            string InputItem = ((MetroComboBox)sender).Name;
            int choosed_option = (int)((MetroComboBox)sender).SelectedIndex;
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream stream;
            switch (InputItem)
            {
                case "sel_head":
                    stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.head." + Head[choosed_option] + ".png");
                    image_head.BackgroundImage = Image.FromStream(stream);
                    break;
                case "sel_body":
                    stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.body." + Body[choosed_option] + ".png");
                    image_body.BackgroundImage = Image.FromStream(stream);
                    break;
                case "sel_hands":
                    stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.hands." + Hand[choosed_option] + ".png");
                    image_hands.BackgroundImage = Image.FromStream(stream);
                    break;
                case "sel_legs":
                    stream = assembly.GetManifestResourceStream("JustEmuTarkovLauncher.Ressources.character.legs." + Legs[choosed_option] + ".png");
                    image_legs.BackgroundImage = Image.FromStream(stream);
                    break;
            }
        }
        private void sel_head_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
