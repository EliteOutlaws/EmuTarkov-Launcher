using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EFT_Launcher_12
{
	public partial class MainWindow : Form
	{
	
		private Profile[] profiles = null;
		private delegate void SetTextCallback(string text);
		private delegate void ResetLauncherCallback();
		private string serverProcessName;
        
		public MainWindow()
		{
			InitializeComponent();
			this.FormClosing += MainWindow_FormClosing;
			startButton.Enabled = false;
			profileEditButton.Enabled = false;
			profilesListBox.SelectedIndex = 0;
			this.gamePathTextBox.Text = Globals.gameFolder;
			LoadProfiles();

		}

		public void LoadProfiles()
		{
			if (!File.Exists(Path.Combine(Globals.profilesFolder, "list.json")))
			{
				MessageBox.Show("unable to find profile folder, make sure the launcher is in Emutarkov server folder");
				return;
			}

			using (StreamReader r = new StreamReader(Path.Combine(Globals.profilesFolder, "list.json")))
			{
				profiles = JsonConvert.DeserializeObject<Profile[]>(r.ReadToEnd());

				foreach (Profile someProfile in profiles)
				{
					if (File.Exists(Path.Combine(Globals.profilesFolder, someProfile.id + @"\character.json")) && !profilesListBox.Items.Contains(someProfile.email))
					{
						profilesListBox.Items.Add(someProfile.email);
					}
				}
			}
		}

		// we need to check absolutely everything.
		// if there is one thing we learned from the 0.8.0-alpha,
		// it's that people don't or can't read.
		//baliston : people can read, they are just lazy as F, so make the launcher as simple as possible
		private void validateValues()
		{
			bool gameExists = false;
			bool profileExists = false;

			// game
			if ( File.Exists(Path.Combine(gamePathTextBox.Text, "EscapeFromTarkov.exe")) )
			{
				if( File.Exists(Path.Combine(gamePathTextBox.Text, "client.config.json")) == false )
				{
					MessageBox.Show("gameFolder has been found but Client.config.json is missing");
					backendUrlLabel.Text = "Backend URL : ?";
				}
				else
				{
					gameExists = true;
					gamePathTextBox.ForeColor = Color.White;
					Globals.gameFolder = gamePathTextBox.Text;
					Properties.Settings.Default.gameFolder = Globals.gameFolder;
					Properties.Settings.Default.Save();

					string json = File.ReadAllText(Path.Combine(Globals.gameFolder, "client.config.json"));

					Globals.clientConfig = JsonConvert.DeserializeObject<ClientConfig>(json);
					backendUrlLabel.Text = "Backend URL : " + Globals.clientConfig.BackendUrl;
				}
			}
			else
			{
				gamePathTextBox.ForeColor = Color.Red;
				backendUrlLabel.Text = "Backend URL : ?";
			}

			// profile
			if (profilesListBox.SelectedIndex > 0)
			{
				profileExists = true;
				profileEditButton.Enabled = true;
			}
			else
			{
				profileEditButton.Enabled = false;
			}
			
			// start button
			if (gameExists && profileExists)
			{
				startButton.Enabled = true;
			}
			else
			{
				startButton.Enabled = false;
			}
		}


		private void gamePathTextBox_TextChanged(object sender, EventArgs e)
		{
			validateValues();
		}

		private void backendUrlTextBox_TextChanged(object sender, EventArgs e)
		{
			validateValues();
		}

		private void profilesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			validateValues();
		}

		private void profileEditButton_Click(object sender, EventArgs e)
		{
			int select = profiles[profilesListBox.SelectedIndex - 1].id;
			EditProfileForm edit = new EditProfileForm(select);

			edit.Show();
		}

		private string GenerateToken(string email, string password)
		{
			LoginToken token = new LoginToken(email, password);
			string beginKey = "-bC5vLmcuaS5u=";
			string endKey = "=";

			// serialize login token
			string serialized = JsonConvert.SerializeObject(token);

			// encode login token to base64
			string result = Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized));

			// add begin and end part of the token
			return beginKey + result + endKey;
		}


		//**************************************************//
		//					PROCESS FUNCTIONS				//
		//**************************************************//
		private void startButton_Click(object sender, EventArgs e)
		{
			int select = profiles[profilesListBox.SelectedIndex - 1].id;

			if (Globals.launchServer)
			{
				// no need for this.member, we're accessing members inside the class
				this.Height = 377;
				LaunchServer();
			}

			// start game
			ProcessStartInfo startGame = new ProcessStartInfo(Path.Combine(Globals.gameFolder, "EscapeFromTarkov.exe"));
			startGame.Arguments = GenerateToken(profiles[select].email, profiles[select].password) + " -token=" + select + " -screenmode=fullscreen";
			startGame.UseShellExecute = false;
			startGame.WorkingDirectory = Globals.gameFolder;
			Process.Start(startGame);
		}

		// package-private doesn't benefit from the optimizations that private has
		private void LaunchServer()
		{
			// We know we're creating a new process, don't use var.
			// It's incredibly expensive to use and vague.
			Process proc = new Process();

			// normal properties
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.WorkingDirectory = Globals.serverFolder;
			proc.StartInfo.FileName = Path.Combine(Globals.serverFolder, "EmuTarkov-Server.exe");
			
			// stdout
			proc.StartInfo.RedirectStandardError = true;
			proc.StartInfo.RedirectStandardInput = true;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
			proc.EnableRaisingEvents = true;
			proc.Exited += ServerTerminated;

			proc.Start();

			proc.BeginOutputReadLine();
			proc.OutputDataReceived += proc_OutputDataReceived;
			serverProcessName = proc.ProcessName;
		}

		private void killServer()
		{
			// what is the point of throw-catch if you're not going to use it?
			Process[] procs = Process.GetProcessesByName(serverProcessName);

			if (procs.Length > 0)
			{
				procs[0].Kill();
			}
		}

		private void ServerTerminated(object sender, EventArgs e)
		{
			resetLauncherSize();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			killServer();
		}

		void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			string res = e.Data;
			
			// get line color here
			
			res = res.Replace(@"(\\e\[[0-1];3[0-9])m", ""); // it should replace all \e[0;32m things
			res = res.Replace(@"\e[0;0m", "");
			
			// make sure to modify this so it can handle colors!
			SetConsoleOutputText(res + "\n");
		}

		private void SetConsoleOutputText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (serverOutputRichBox.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetConsoleOutputText);
				Invoke(d, new object[] { text });
			}
			else
			{
				serverOutputRichBox.Text += text;
				serverOutputRichBox.SelectionStart = serverOutputRichBox.Text.Length;
				serverOutputRichBox.ScrollToCaret();
			}
		}

		private void resetLauncherSize()
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (serverOutputRichBox.InvokeRequired)
			{
				ResetLauncherCallback d = new ResetLauncherCallback(resetLauncherSize);
				Invoke(d, new object[] { });
			}
			else
			{
				this.Height = 162;
				serverOutputRichBox.Text = "";
			}
		}

	}

	internal class Profile
	{
		public string email;
		public string password;
		public int id;
	}

	internal class LoginToken
	{
		public string email;
		public string password;
		public bool toggle;
		public long timestamp;

		public LoginToken(string email, string password)
		{
			this.email = email;
			this.password = password;
			this.toggle = true;
			this.timestamp = 132178097635361483;
		}
	}
}
