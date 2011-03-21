using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Resources;
using System.Globalization;

namespace JCard
{
    public class Common
    {
        public static  bool checkSingleInstance(string appName)
        {
            bool isNewIns;
            using (Mutex mt = new Mutex(true, appName, out isNewIns))
            {
                if (isNewIns)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Get value from App.Config file
        /// </summary>
        /// <param name="strKey">Config Key</param>
        /// <param name="strDefault">Default Config Value</param>
        /// <returns>Config value</returns>
        public static string GetConfigValue(string strKey, string strDefault)
        {
            try
            {
                #pragma warning disable 618,612
                if (ConfigurationSettings.AppSettings != null)
                {
                    string value = ConfigurationSettings.AppSettings[strKey];
                    if (value == null)
                        return strDefault;
                    return
                        value;
                }
                #pragma warning restore 618,612

                return String.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get value from resource file by Resource Name
        /// </summary>
        /// <param name="strMsgID">Rresource Name</param>
        /// <param name="ci">Cuture Info</param>
        /// <param name="rm">Object of Resource Manager</param>
        /// <returns>Resource Value</returns>
        public static string GetResourceValue(string strResName, CultureInfo ci, ResourceManager rm)
        {
            try
            {
                return rm.GetString(strResName, ci);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
