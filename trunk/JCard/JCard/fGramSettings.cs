using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fGramSetts : Form
    {
        public fGramSetts()
        {
            InitializeComponent();
        }

        //Sample GroupBox

        private void pnlSampleBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }

        }

        private void pnlSampleFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        //Japanese Meaning GroupBox

        private void pnlJapBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        private void pnlJapFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        //Vietnamese Meaning GroupBox

        private void pnlVieBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        private void pnlVieFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        //Examples Meaning GroupBox

        private void pnlExBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        private void pnlExFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TO DO
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save Settings
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlSampleBgClr_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
