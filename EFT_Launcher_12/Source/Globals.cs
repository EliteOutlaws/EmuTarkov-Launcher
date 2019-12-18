using System;
using System.IO;

namespace EFT_Launcher_12
{
	public class Globals
	{
		public static string gameFolder;
		public static string serverFolder;
		public static string profilesFolder;
		public static string version;
		public static bool launchServer;
		public static bool useServerPath;
		public static ClientConfig clientConfig;
		
		static Globals()
		{
			serverFolder = Environment.CurrentDirectory;
			profilesFolder = Path.Combine(Environment.CurrentDirectory, "appdata/profiles");

			//serverFolder = "Y:/tarkov/EmuTarkov Server dev";
			//profilesFolder = "Y:/tarkov/EmuTarkov Server dev/appdata/profiles";

			gameFolder = Properties.Settings.Default.gameFolder;
			version = "EmuTarkov Launcher 12";
			launchServer = true;
			clientConfig = null;
		}
	}
}