using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEmuTarkovLauncher.Functions
{
    class LauncherConfig
    {
        private string configFile = "./jetl.config.json";
        private RWJson rwj = new RWJson();
        private dynamic data_inLauncher;
        public LauncherConfig() {
            this.data_inLauncher = this.rwj.ReadJObjectFile(configFile);
        }

        public string getGameDirectory()
        {
            return this.data_inLauncher.gameDirectory;
        }
        public string getServerDirectory()
        {
            return this.data_inLauncher.serverDirectory;
        }
        public void setGameDirectory(string input)
        {
            this.data_inLauncher.gameDirectory = input;
            SaveData();
        }
        public void setServerDirectory(string input)
        {
            this.data_inLauncher.serverDirectory = input;
            SaveData();
        }
        public void LoadChanges()
        {
            this.data_inLauncher = this.rwj.ReadJObjectFile(this.configFile);
        }
        private void SaveData()
        {
            this.rwj.WriteJsonFile(this.configFile, this.data_inLauncher);
        }
    }
}
