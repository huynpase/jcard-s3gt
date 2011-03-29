using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using System.Globalization;

namespace JCard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isNewIns;
            using (Mutex mt = new Mutex(true,"JCard.exe",out isNewIns))
            {
                if(isNewIns)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new fCLesson());
                }
                else
                {
                    ResourceManager objRM = new ResourceManager("JCard.Resources", typeof(fCLesson).Assembly);
                    CultureInfo objCI = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));

                    Common.ShowInfoMsg(objCI, objRM, Constants.RES_START_PROGRAM_NAME, Constants.RES_START_PROGRAM_VALUE);
                    return;
                }
            }
            
                
           
            
        }
    }
}