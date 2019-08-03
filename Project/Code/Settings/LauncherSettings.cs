﻿using Launcher.Code.Data;

namespace Launcher.Code.Settings
{
    public class LauncherSettings : SettingsBase<LauncherConfig>
    {
        public LauncherSettings() : base("./data/", "launcher.config.json")
        {
            // for calling base constructor
        }
        #region EMAIL
        public string GetEmail()
        {
            return base.config.email;
        }

        public void SetEmail(string value)
        {
            base.config.email = value;
            base.SaveSettings();
        }
        #endregion
        #region Password
        public string GetPassword()
        {
            return base.config.password;
        }

        public void SetPassword(string value)
        {
            base.config.password = value;
            base.SaveSettings();
        }
        #endregion
        #region CLIENT DATA
        public string GetClientLocation()
        {
            return base.config.clientLocation;
        }
        public string GetClientFilename()
        {
            return base.config.clientFilename;
        }
        public int GetScreenMode()
        {
            return base.config.screenMode;
        }
        public void SetClientLocation(string value)
        {
            base.config.clientLocation = value;
            base.SaveSettings();
        }
        public void SetClientFilename(string value)
        {
            base.config.clientFilename = value;
            base.SaveSettings();
        }
        public void SetScreenMode(int value) {
            base.config.screenMode = value;
            base.SaveSettings();
        }

        #endregion
        #region SERVER DATA
        public string GetServerLocation()
        {
            return base.config.serverLocation;
        }
        public string GetServerFilename()
        {
            return base.config.serverFilename;
        }

        public void SetServerLocation(string value)
        {
            base.config.serverLocation = value;
            base.SaveSettings();
        }

        public void SetServerFilename(string value)
        {
            base.config.serverFilename = value;
            base.SaveSettings();
        }
        #endregion
        #region BACKEND URL
        public void SavePort(int value) {
            base.config.port = value;
            base.SaveSettings();
        }
        public string LoadPort() {
            return base.config.port.ToString();
        }
        public void SaveIP(string value) {
            base.config.ip = value;
            base.SaveSettings();
        }
        public string LoadIP() {
            return base.config.ip;
        }
        public string PrepareBackendURL(bool secured = false)
        {
            if (secured)
                return "https://" + LoadIP() + ":" + LoadPort();
            else
                return "http://" + LoadIP() + ":" + LoadPort();
        }
        #endregion
    }
}
