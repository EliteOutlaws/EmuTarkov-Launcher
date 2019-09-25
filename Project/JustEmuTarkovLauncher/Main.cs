using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JustEmuTarkovLauncher.Functions;
using JustEmuTarkovLauncher;
namespace JustEmuTarkovLauncher
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
       LauncherConfig l_conf = new LauncherConfig();
       StartMechanism M_StartGame;
       public Main()
        {
            mainInstance = this;
            InitializeComponent();
            M_StartGame = new StartMechanism();
            l_conf = new LauncherConfig();
            s_conf = new ServerHandling();
            c_conf = new ClientHandling();
            inp_gameLocation.Text = l_conf.getGameDirectory();
            inp_serverLocation.Text = l_conf.getServerDirectory();
        }
        #pragma warning disable CS0414
         private readonly string infos = "Its not optimised at all - code is pure junk";
        #pragma warning restore CS0414
        private bool InitialTest_gameDir = false, InitialTest_serverDir = false;
        public static Main mainInstance;
        private bool GameIsOK = false;
        private bool ServerIsOK = false;
        private tools TOOL = new tools();
        private RWJson rwj = new RWJson();
        #pragma warning disable CS0649
         private ServerHandling s_conf;
         private ClientHandling c_conf;
        #pragma warning restore CS0649

        public void MessageBox(string Message, string Title = "", MessageBoxIcon Type = MessageBoxIcon.Information, MessageBoxButtons Buttons = MessageBoxButtons.OK) {
            MetroFramework.MetroMessageBox.Show(
                this,
                "\n" + Message, Title,
                Buttons,
                Type
            );
        }

        private void InputChanged_TextBoxGame(object sender, EventArgs e)
        {
            string InputItem = ((MetroTextBox)sender).Name;
            string text = ((MetroTextBox)sender).Text, MessageString = "";
            if (text.Length > 1)
            {
                string testLastCharacter = text.Substring(text.Length - 1, 1);
                text = TOOL.removeLastSlash(text);
                string executableToCheck = "";
                string configToCheck = "";
                executableToCheck = "EscapeFromTarkov.exe";
                configToCheck = "client.config.json";
                MessageString = "Game destinition is correct\nDestinition: " + text;
                if (TOOL.IsExist(text, executableToCheck, configToCheck))
                {
                    GameIsOK = true;
                    btn_restartClientConfig.Enabled = true;
                    l_conf.setGameDirectory(text);
                    if (GameIsOK && ServerIsOK)
                        btn_startgame.Enabled = true;
                    if (InitialTest_gameDir)
                    {
                        MessageBox(MessageString, "Information");
                        InitialTest_gameDir = true;
                    }
                }
                else
                {
                    btn_restartClientConfig.Enabled = false;
                    btn_startgame.Enabled = false;
                }
            }
        }
        private void InputChanged_TextBoxServer(object sender, EventArgs e)
        {
            string InputItem = ((MetroTextBox)sender).Name;
            string text = ((MetroTextBox)sender).Text, MessageString = "";
            if (text.Length > 1)
            {
                string testLastCharacter = text.Substring(text.Length - 1, 1);
                text = TOOL.removeLastSlash(text);

                string executableToCheck = "";
                string configToCheck = "";
                text = ((MetroTextBox)sender).Text;
                executableToCheck = "JustEmuTarkov-Server.exe";
                configToCheck = "server.config.json";
                MessageString = "Server destinition is correct\nDestinition: " + text;
                if (TOOL.IsExist(text, executableToCheck, configToCheck))
                {
                    ServerIsOK = true;
                    inp_portChange.Enabled = true;
                    btn_loginIn.Enabled = true;
                    l_conf.setServerDirectory(text);
                    string ServerPath = TOOL.removeLastSlash(inp_serverLocation.Text);
                    dynamic data_server = rwj.ReadJObjectFile(ServerPath + @"\server.config.json");
                    inp_portChange.Text = (string)data_server.server.port;
                    lbl_portChange.Text = "Port";
                    if (GameIsOK && ServerIsOK)
                        btn_startgame.Enabled = true;
                    if (InitialTest_serverDir)
                    {
                        MessageBox(MessageString, "Information");
                        InitialTest_serverDir = true;
                    }
                }
                else
                {
                    inp_portChange.Enabled = false;
                    btn_startgame.Enabled = false;
                    btn_loginIn.Enabled = false;
                }

            }
        }
        private void Click_btn_startgame(object sender, EventArgs e)
        {
            /* its addon will add that later
                Dim procs = Process.GetProcesses()
                Dim flashRunning = procs.Any(Function(x) x.ProcessName.StartsWith("flashplayerplugin"))
             */
            string login = inp_login.Text;
            string passw = inp_password.Text;
            s_conf.main_SetServerPath(TOOL.removeLastSlash(inp_serverLocation.Text));
            int Found_ID = s_conf.CheckUserExistance(login, passw);
            if (Found_ID == -1) {
                MessageBox("User not found\nAborting...", "Error", MessageBoxIcon.Error, MessageBoxButtons.OK);
                return;
            }
            c_conf.main_SetClientPath(TOOL.removeLastSlash(inp_gameLocation.Text));
            string ServerFile = @"\JustEmuTarkov-Server.exe";
            string GameFile = @"\EscapeFromTarkov.exe";
            string argument = M_StartGame.CreateAttributes(login, passw, Found_ID);
            TOOL.StartProcess(s_conf.main_GetServerPath(), ServerFile);
             c_conf.setBackendUrl(s_conf.getBackendUrl());
             s_conf.setGameDir(c_conf.main_GetClientPath());
            System.Threading.Thread.Sleep(2000);
            TOOL.StartProcess(c_conf.main_GetClientPath(), GameFile, argument);
        }

        private void Click_RestartClient(object sender, EventArgs e)
        {
            if (c_conf.main_GetClientPath() == "")
            {
                c_conf.main_SetClientPath(TOOL.removeLastSlash(inp_gameLocation.Text));
            }
            c_conf.setBackendUrl("https://prod.escapefromtarkov.com");
        }

        private void TextChanged_portChange(object sender, EventArgs e)
        {
            if (inp_portChange.Text != "")
            {
                if (s_conf.main_GetServerPath() == "")
                {
                    s_conf.main_SetServerPath(l_conf.getServerDirectory());
                    s_conf.main_SetServerConfigData();
                }
                s_conf.setPort(inp_portChange.Text);
            }
        }

        private void Click_btn_loginIn(object sender, EventArgs e)
        {
            s_conf.main_SetServerPath(TOOL.removeLastSlash(inp_serverLocation.Text));
            int Found_id = s_conf.CheckUserExistance(inp_login.Text, inp_password.Text);
            if (Found_id != -1)
            { // we passing ID login password and client/server configuration
                AccountEditor AccountEditor = new AccountEditor(Found_id, inp_login.Text, inp_password.Text, c_conf.main_GetClientPath(), s_conf.main_GetServerPath());
                AccountEditor.Show();
            }
            else
            {
                MessageBox("Unable to find profile.", "Profile Error", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }

    }
}
