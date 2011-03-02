using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fGramSetting : Form
    {
        public fGramSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Save settings
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlSampleBgColor_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // TODO: Update selected Color
            }
        }
    }
}