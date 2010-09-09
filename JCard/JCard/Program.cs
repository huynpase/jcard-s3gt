using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

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
                    MessageBox.Show("JCard is running. Please check program on taskbar!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }
            
                
           
            
        }
    }
}