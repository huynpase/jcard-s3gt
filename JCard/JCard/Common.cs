using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Resources;
using System.Globalization;
using System.Windows.Forms;

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

                return strDefault;
            }
            catch (Exception)
            {
                return strDefault;
            }
        }

        /// <summary>
        /// Get value from resource file by Resource Name
        /// </summary>
        /// <param name="strMsgID">Rresource Name</param>
        /// <param name="ci">Cuture Info</param>
        /// <param name="rm">Object of Resource Manager</param>
        /// <returns>Resource Value</returns>
        public static string GetResourceValue(string strResName, CultureInfo ci, ResourceManager rm, string strDefault)
        {
            try
            {
                return rm.GetString(strResName, ci);
            }
            catch (Exception)
            {
                return strDefault;
            }
        }

        #region Xử lý hiển thị message
        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="rm"></param>
        /// <param name="strError"></param>
        public static void ShowErrorMsg(CultureInfo ci, ResourceManager rm, string strError)
        {
            string msg = GetResourceValue(Constants.RES_ERROR_NAME, ci, rm, Constants.RES_ERROR_VALUE) +
                            Environment.NewLine + Environment.NewLine + strError;
            string title = GetResourceValue(Constants.RES_ERROR_TITLE_NAME, ci, rm, Constants.RES_ERROR_TITLE_VALUE);

            if (MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Application.Exit();
                return;
            }
        }

        /// <summary>
        /// Show info message
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="rm"></param>
        /// <param name="strMsg"></param>
        /// <param name="strDefMsg"></param>
        public static void ShowInfoMsg(CultureInfo ci, ResourceManager rm, string strMsg, string strDefMsg)
        {
            string msg = GetResourceValue(strMsg, ci, rm, strDefMsg);
            
            string title = GetResourceValue(Constants.RES_INFO_TITLE_NAME, ci, rm, Constants.RES_INFO_TITLE_VALUE);

            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Show warning message
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="rm"></param>
        /// <param name="strMsg"></param>
        /// <param name="strDefMsg"></param>
        public static void ShowWarningMsg(CultureInfo ci, ResourceManager rm, string strMsg, string strDefMsg)
        {
            string msg = GetResourceValue(strMsg, ci, rm, strDefMsg);

            string title = GetResourceValue(Constants.RES_WARN_TITLE_NAME, ci, rm, Constants.RES_WARN_TITLE_VALUE);

            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Show confirm message
        /// </summary>
        /// <param name="ci"></param>
        /// <param name="rm"></param>
        /// <param name="strMsg"></param>
        /// <param name="strDefMsg"></param>
        /// <returns></returns>
        public static DialogResult ShowConfirmMsg(CultureInfo ci, ResourceManager rm, string strMsg, string strDefMsg)
        {
            string msg = GetResourceValue(strMsg, ci, rm, strDefMsg);

            string title = GetResourceValue(Constants.RES_INFO_TITLE_NAME, ci, rm, Constants.RES_INFO_TITLE_VALUE);

            return MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Question);  
        }
        #endregion
    }
}
