using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JCard;

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
            // Sample
            pnlSampleBgClr.BackColor = Color.FromArgb(ChangeGramSett.BackColor);
            pnlSampleFClr.BackColor = Color.FromArgb(ChangeGramSett.ForeColor);
            //Japanese Meaning
            pnlJapBgClr.BackColor = Color.FromArgb(ChangeGramSett.JP_BackColor);
            pnlJapFClr.BackColor = Color.FromArgb(ChangeGramSett.JP_ForeColor);
            chkboxJap.Checked = ChangeGramSett.JP_Isdisplayed;
            //Vietnamese Meaning
            pnlVieBgClr.BackColor = Color.FromArgb(ChangeGramSett.VN_BackColor);
            pnlVieFClr.BackColor = Color.FromArgb(ChangeGramSett.VN_ForeColor);
            chkboxVie.Checked = ChangeGramSett.VN_IsDisplayed;
            //Example Meaning
            pnlExBgClr.BackColor = Color.FromArgb(ChangeGramSett.Ex_BackColor);
            pnlExFClr.BackColor = Color.FromArgb(ChangeGramSett.Ex_ForeColor);
            numNoDis.Text = ChangeGramSett.Ex_NoOfDisplay.ToString();
            numDisTim.Text = ChangeGramSett.Ex_DisplayTime.ToString();
            numDelayTim.Text = ChangeGramSett.Ex_DelayTime.ToString();
        }

        //Sample GroupBox
        #region Sample
        private void pnlSampleBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlSampleBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlSampleBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlSampleFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlSampleFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlSampleFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion
        //Japanese Meaning GroupBox
        #region Japanese Meaning
        private void pnlJapBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlJapBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlJapBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlJapFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlJapFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlJapFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion
        //Vietnamese Meaning GroupBox
        #region Vietnamese Meaning
        private void pnlVieBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlVieBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlVieBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlVieFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlVieFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlVieFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion
        //Examples GroupBox
        #region Examples
        private void pnlExBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlExBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlExBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlExFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlExFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlExFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangeGramSett.BackColor = pnlSampleBgClr.BackColor.ToArgb();
            ChangeGramSett.ForeColor = pnlSampleFClr.BackColor.ToArgb();
            ChangeGramSett.JP_BackColor = pnlJapBgClr.BackColor.ToArgb();
            ChangeGramSett.JP_ForeColor = pnlJapFClr.BackColor.ToArgb();
            ChangeGramSett.JP_Isdisplayed = chkboxJap.Checked;
            ChangeGramSett.VN_BackColor = pnlVieBgClr.BackColor.ToArgb();
            ChangeGramSett.VN_ForeColor = pnlVieFClr.BackColor.ToArgb();
            ChangeGramSett.VN_IsDisplayed = chkboxVie.Checked;
            ChangeGramSett.Ex_BackColor = pnlExBgClr.BackColor.ToArgb();
            ChangeGramSett.Ex_ForeColor = pnlExFClr.BackColor.ToArgb();
            ChangeGramSett.Ex_NoOfDisplay = int.Parse(numNoDis.Text);
            ChangeGramSett.Ex_DisplayTime = int.Parse(numDisTim.Text);
            ChangeGramSett.Ex_DelayTime = int.Parse(numDelayTim.Text);
            string filePath = Application.StartupPath;
            filePath += @"\GramSettings.ini";
            busGramSett.SaveGramSetting(ChangeGramSett, filePath);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal saveNumVal = 0;
        private void numNoDis_Leave(object sender, EventArgs e)
        {
            NumericUpDown nudTemp = (NumericUpDown)sender;
            if (nudTemp.Text == "" || nudTemp.Text == "-")
            {
                nudTemp.Text = saveNumVal.ToString();
            }
        }
                
        private void numNoDis_Enter(object sender, EventArgs e)
        {
            saveNumVal = ((NumericUpDown)sender).Value;
        }

    }
}
