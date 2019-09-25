using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JustEmuTarkovLauncher;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace JustEmuTarkovLauncher.Functions
{
    class tools
    {

        public string toMD5(string input)
        { // its just simple md5 incase we will need that in future
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public bool IsExist(string text, string executableToCheck, string configToCheck)
        {
            if (File.Exists(text + @"\" + executableToCheck))
            {
                if (File.Exists(text + @"\" + configToCheck))
                {
                    return true;
                }
            }
            return false;
        }

        public void StartProcess(string filepath, string executable, string arguments = "")
        {
            ProcessStartInfo process = new ProcessStartInfo
            {
                FileName = filepath + executable,
                UseShellExecute = true,
                WorkingDirectory = filepath
            };

            if (arguments != "")
                process.Arguments = arguments;

            if (File.Exists(process.FileName))
            {
                Process gameProcess = Process.Start(process);
            }
            else
            {
                Main.mainInstance.MessageBox("Cannot start process from some reason\nTried to start:'" + process.FileName + " -" + arguments + "'", "Error", MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
        }

        public string removeLastSlash(string text)
        {
            if (text.Length > 1)
            { // incase someone put too short string
                string testLastCharacter = text.Substring(text.Length - 1, 1);

                if (testLastCharacter == @"\" || testLastCharacter == "\\")
                {
                    text = text.Substring(0, text.Length - 1);
                }
            }
            return text;
        }
    }
}
