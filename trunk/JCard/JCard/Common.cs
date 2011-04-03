using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Resources;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

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

            string title = GetResourceValue(Constants.RES_CONFIRM_TITLE_NAME, ci, rm, Constants.RES_CONFIRM_TITLE_VALUE);

            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
        }
        #endregion

        #region Xử lý Tooltip
        /// <summary>
        /// Draw ellipsis text on Label
        /// </summary>
        /// <param name="lbl">Label</param>
        /// <param name="g">Graphics</param>
        public static void DrawEllipsisText(Label lbl, Graphics g)
        {
            SolidBrush br = new SolidBrush(lbl.ForeColor);
            StringFormat sf = new StringFormat();

            switch (lbl.TextAlign)
            {
                case ContentAlignment.TopLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
            }

            sf.Trimming = StringTrimming.EllipsisCharacter;
            sf.FormatFlags = StringFormatFlags.LineLimit;

            g.Clear(lbl.BackColor);
            g.DrawString(lbl.Text, lbl.Font, br, lbl.DisplayRectangle, sf);
        }

        /// <summary>
        /// Get Height Position of Tooltip
        /// </summary>
        /// <param name="tooltip">string of tooltip</param>
        /// <param name="control">control of tooltip</param>
        /// <returns>Top Position</returns>
        public static int GetTopPosOfTooltip(string tooltip, Control control)
        {
            int line = CountNewLineChar(tooltip);
            if (tooltip.LastIndexOf("\n") == tooltip.Length - 1) line--;
            int height = 20 + line * 15;
            int res = -height;

            Point pnt = control.PointToScreen(new Point(0, 0));
            if (pnt.Y < height)
            {
                res = control.Height;
            }

            return res;
        }

        /// <summary>
        /// Count number of NewLine Character
        /// </summary>
        /// <param name="str">String for counting</param>
        /// <returns>Number of Newline Character</returns>
        public static int CountNewLineChar(string str)
        {
            int res = 0;
            int idx = str.IndexOf("\n", 0);
            if (idx != -1)
            {
                res++;
                res += CountNewLineChar(str.Substring(idx + 1));
            }

            return res;
        }
        #endregion
    }
}
