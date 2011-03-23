using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace JCard
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            SetDisplayLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetDisplayLabel()
        {
            // Create a resource manager to retrieve resources.
            ResourceManager objResourceManager = new ResourceManager("JCard.Resources", typeof(About).Assembly);
            CultureInfo objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));

            if (objResourceManager != null)
            {
                this.Text = Common.GetResourceValue(Constants.RES_ABOUT_NAME, objCulInfo, objResourceManager, Constants.RES_ABOUT_VALUE);
                label1.Text = Common.GetResourceValue(Constants.RES_COPYRIGHT_NAME, objCulInfo, objResourceManager, Constants.RES_COPYRIGHT_VALUE);
                label2.Text = Common.GetResourceValue(Constants.RES_MEMBERS_NAME, objCulInfo, objResourceManager, Constants.RES_MEMBERS_VALUE);
                button1.Text = Common.GetResourceValue(Constants.RES_BTNCLOSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCLOSE_VALUE);
            }
        }
    }
}