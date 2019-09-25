using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustEmuTarkovLauncher.Functions
{
    class RWJson
    {
        private tools TOOL = new tools();
        public JObject ReadJObjectFile(string fileName)
        { // based on ||return JObject.Parse(readFile(ServerPath + @"\server.config.json"));||
            try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        String line = sr.ReadToEnd();
                        return JObject.Parse(line);
                    }
                }
            catch (FileNotFoundException ex)
                {

                    Main.mainInstance.MessageBox(ex.Message, "Error on reading file.", MessageBoxIcon.Error, MessageBoxButtons.OK);
                    return JObject.Parse("{}");
                }
        }
        public JArray ReadJArrayFile(string fileName)
        { // based on ||return JObject.Parse(readFile(ServerPath + @"\server.config.json"));||
            try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        String line = sr.ReadToEnd();
                        return JArray.Parse(line);
                    }
                }
            catch (FileNotFoundException ex)
                {

                    Main.mainInstance.MessageBox(ex.Message, "Error on reading file.", MessageBoxIcon.Error, MessageBoxButtons.OK);
                    return JArray.Parse("{}");
                }
        }
        public void WriteJsonFile(string filename, dynamic text_dyn_object)
        {
            string text = JsonConvert.SerializeObject(text_dyn_object);
            try
            {
                File.WriteAllText(filename, text);
            }
            catch (FileNotFoundException ex)
            {
                Main.mainInstance.MessageBox(ex.Message, "Error on writing to file.", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }

    }
}
