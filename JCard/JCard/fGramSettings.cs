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
        DTO_GramSetting ChangeGramSett = new DTO_GramSetting();
        BUS_GramSetting busGramSett = new BUS_GramSetting();

        public fGramSetts()
        {
            InitializeComponent();
            string filePath = Application.StartupPath;
            filePath += @"\GramSettings.ini";
            ChangeGramSett = busGramSett.ReadGramSetting(filePath);
            //Top ??
            //Left ??
            pnlSampleBgClr.BackColor = Color.FromArgb(ChangeGramSett.BackColor);
            pnlSampleFClr.BackColor = Color.FromArgb(ChangeGramSett.ForeColor);
            pnlJapBgClr.BackColor = Color.FromArgb(ChangeGramSett.JP_BackColor);
            pnlJapFClr.BackColor = Color.FromArgb(ChangeGramSett.JP_ForeColor);
            //JP Width
            chkboxJap.Checked = ChangeGramSett.JP_Isdisplayed;
            pnlVieBgClr.BackColor = Color.FromArgb(ChangeGramSett.VN_BackColor);
            pnlVieFClr.BackColor = Color.FromArgb(ChangeGramSett.VN_ForeColor);
            //VN Width
            chkboxVie.Checked = ChangeGramSett.VN_IsDisplayed;
            pnlSampleBgClr.BackColor = Color.FromArgb(ChangeGramSett.Ex_BackColor);
            pnlSampleFClr.BackColor = Color.FromArgb(ChangeGramSett.Ex_ForeColor);
            cmbNoDis.Text = ChangeGramSett.Ex_NoOfDisplay.ToString();
            cmbDisTim.Text = ChangeGramSett.Ex_DisplayTime.ToString();
            cmbDelayTim.Text = ChangeGramSett.Ex_DelayTime.ToString();
        }

        //Sample GroupBox
        #region Sample
        private void pnlSampleBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            //Show ColorDialog for user to choose the color
            if (colorDialog.ShowDialog() == DialogResult.OK)
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
        #endregion
        //Japanese Meaning GroupBox
        #region Japanese Meaning
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
        #endregion
        //Vietnamese Meaning GroupBox
        #region Vietnamese Meaning
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
        #endregion
        //Examples GroupBox
        #region Examples
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
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Top
            //Left
            ChangeGramSett.BackColor = pnlSampleBgClr.BackColor.ToArgb();
            ChangeGramSett.ForeColor = pnlSampleFClr.BackColor.ToArgb();
            ChangeGramSett.JP_BackColor = pnlJapBgClr.BackColor.ToArgb();
            ChangeGramSett.JP_ForeColor = pnlJapFClr.BackColor.ToArgb();
            //JP Width
            ChangeGramSett.JP_Isdisplayed = chkboxJap.Checked;
            ChangeGramSett.VN_BackColor = pnlVieBgClr.BackColor.ToArgb();
            ChangeGramSett.VN_ForeColor = pnlVieFClr.BackColor.ToArgb();
            //VN Width
            ChangeGramSett.VN_IsDisplayed = chkboxJap.Checked;
            ChangeGramSett.Ex_BackColor = pnlExBgClr.BackColor.ToArgb();
            ChangeGramSett.Ex_ForeColor = pnlExFClr.BackColor.ToArgb();
            ChangeGramSett.Ex_NoOfDisplay = int.Parse(cmbNoDis.Text);
            ChangeGramSett.Ex_DisplayTime = int.Parse(cmbDisTim.Text);
            ChangeGramSett.Ex_DelayTime = int.Parse(cmbDelayTim.Text);
            string filePath = Application.StartupPath;
            filePath += @"\GramSettings.ini";
            busGramSett.SaveGramSetting(ChangeGramSett, filePath);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
