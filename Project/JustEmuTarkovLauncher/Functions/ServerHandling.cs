using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEmuTarkovLauncher.Functions
{
    class ServerHandling
    {
        //public ServerHandling() { }

        private string serverPath = "";
        private dynamic serverConfigData;
        private dynamic serverProfilesData;

        private tools TOOL = new tools();
        private RWJson rwj = new RWJson();

        public void ServerDataSave()
        {

        }
        #region MAIN
        #region SET
        public void main_SetServerConfigData()
        {
            if(serverPath != "")
                serverConfigData = rwj.ReadJObjectFile(serverPath + @"\server.config.json");
        }
        public void main_SetServerProfileData()
        {
            if (serverPath != "")
                serverProfilesData = rwj.ReadJArrayFile(serverPath + @"\data\profiles\profiles.json");
        }
        public void main_SetServerPath(string s)
        {
            serverPath = s;
        }
        #endregion
        #region GET
        public string main_GetServerPath()
        {
            return serverPath;
        }
        #endregion
        #endregion
        public string getBackendUrl()
        {
            return serverConfigData.server.backendUrl;
        }
        public void setGameDir(string path)
        {
            main_SetServerProfileData();
            serverConfigData.game = path;
            SaveConfig();
        }
        public void setPort(string num)
        {
            main_SetServerProfileData();
            serverConfigData.server.port = Int32.Parse(num);
            SaveConfig();
        }
        public int CheckUserExistance(string l, string p)
        { //
            main_SetServerProfileData(); // make sure first time accessing edit page it will load profile file
            for (int i = 0; i < serverProfilesData.Count; i++)
            {
                if (serverProfilesData[i].email == l && serverProfilesData[i].password == p)
                {
                    return (int)serverProfilesData[i].id;
                }
            }
            return -1;
        }

        private void SaveConfig()
        {
            rwj.WriteJsonFile(serverPath + @"\server.config.json", serverConfigData);
        }
        private void SaveProfiles()
        {
            rwj.WriteJsonFile(serverPath + @"\data\profiles\profiles.json", serverProfilesData);
        }
    }
}
