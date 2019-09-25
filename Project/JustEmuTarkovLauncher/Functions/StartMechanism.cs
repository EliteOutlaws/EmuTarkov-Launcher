using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEmuTarkovLauncher.Functions
{
    class StartMechanism
    {
        public string CreateAttributes(string login, string passw, int ID)
        {
            if (ID != -1)
            {

                string initial = Convert.ToBase64String(Encoding.UTF8.GetBytes("l.o.g.i.n"));
                long timestamp = DateTime.UtcNow.ToFileTimeUtc() ^ 698464131L;
                string jsonLogin = "{ email: \"" + login + "\", password: \"" + passw + "\", toggle: true, timestamp: " + timestamp + "}";
                string loginData = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonLogin));
                string text = string.Format("-{0}={1} -token={2} -screenmode={3}", new object[]
                {
                        initial,
                        loginData,
                        ID,
                        "fullscreen"
                });
                /* will be done after adjusting screen select
                if (1 == 2)
                {
                    text += " -popupwindow";
                }*/
                return text;
            }
            return "";
        }
        public void CreateLauncherToken()
        {

        }
    }
}
