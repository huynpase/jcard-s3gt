using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using JCard;


namespace JCard
{
    public partial class fSplash : Form
    {
        static fSplash splashScreen = null;
        static Thread thread = null;
        private double OpacityInc = .05;
        private double OpacityDec = .1;

        public fSplash()
        {
            InitializeComponent();
            this.ClientSize = this.BackgroundImage.Size;
            this.Opacity = .0;
            timer1.Interval = 50;
            timer1.Start();
        }

        static private void ShowForm()
        {
            splashScreen = new fSplash();
            Application.Run(splashScreen);
        }

        static public void CloseForm()
        {
            if (splashScreen != null)
            {
                //Make it blur and going away
                splashScreen.OpacityInc = -splashScreen.OpacityDec;
            }
            thread = null;
            splashScreen = null;
        }

        static public fSplash SplashForm
        {
            get
            {
                return splashScreen;
            }
        }

        // A static method to create the thread and launch the SplashScreen.

        static public void ShowSplashScreen()
        {
            if (splashScreen != null)
                return;
            thread = new Thread(new ThreadStart(fSplash.ShowForm));
            thread.IsBackground = true;
            thread.ApartmentState = ApartmentState.STA;
            thread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (OpacityInc > 0)
            {
                if (this.Opacity < 1)
                    this.Opacity += OpacityInc;
            }
            else
            {
                if (this.Opacity > 0)
                    this.Opacity += OpacityInc;
                else
                    this.Close();
            }
        }

    }
}
