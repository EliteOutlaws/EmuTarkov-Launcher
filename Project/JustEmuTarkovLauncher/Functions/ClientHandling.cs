using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEmuTarkovLauncher.Functions
{
    class ClientHandling
    {
        private string clientPath = "";
        private dynamic configConfigData;

        private tools TOOL = new tools();
        private RWJson rwj = new RWJson();

        #region MAIN
            #region SET
            public void main_SetClientConfigData()
            {
                if (clientPath != "")
                configConfigData = rwj.ReadJObjectFile(clientPath + @"\client.config.json");
            }
            public void main_SetClientPath(string s)
            {
                clientPath = s;
            }
            #endregion
            #region GET
            public string main_GetClientPath()
            {
                return clientPath;
            }
        #endregion
        #endregion

        public void setBackendUrl(string backendUrl)
        {
            main_SetClientConfigData();
            configConfigData.BackendUrl = backendUrl;
            SaveConfig();
        }
        private void SaveConfig()
        {
            rwj.WriteJsonFile(clientPath + @"\client.config.json", configConfigData);
        }


    }
}
