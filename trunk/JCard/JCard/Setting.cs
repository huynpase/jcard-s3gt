using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class rdbBR : UserControl
    {
        DTO_Setting changeSetting = new DTO_Setting();
        BUS_Setting bSaveSetting = new BUS_Setting();       
            
        public rdbBR()
        {
            InitializeComponent();
            string filePath = Application.StartupPath;
            filePath += @"\Setting.ini";
            changeSetting = bSaveSetting.ReadSetting(filePath);
            cmbDelayTime.Text = changeSetting.WaitingTimeVOC.ToString();
            cmbDisplayTime.Text = changeSetting.DisplayTimeVOC.ToString();            
            cmbImiFontSize.Text = changeSetting.FontSizeImiVOC.ToString();
            cmbKanaFontSize.Text = changeSetting.FontSizeKanaVOC.ToString();
            cmbKanjiFontSize.Text = changeSetting.FontSizeKanjiVOC.ToString();
        }               

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath;
            filePath += @"\Setting.ini";
            if(rdbBL.Checked == true)
                changeSetting.PositionVOC = "BL";
            else if(rdbTL.Checked == true)
                changeSetting.PositionVOC = "TL";
            else if(rdbTL.Checked == true)
                changeSetting.PositionVOC = "TL";
            else if(rdbBR2.Checked == true)//dat BR2 vi bi trung ten
                changeSetting.PositionVOC = "BR";
            changeSetting.DisplayTimeVOC = float.Parse(cmbDisplayTime.Text);
            changeSetting.WaitingTimeVOC = float.Parse(cmbDelayTime.Text);
            changeSetting.FontSizeKanjiVOC = float.Parse(cmbKanjiFontSize.Text);
            changeSetting.FontSizeKanaVOC = float.Parse(cmbKanaFontSize.Text);
            changeSetting.FontSizeImiVOC = float.Parse(cmbImiFontSize.Text);
            bSaveSetting.SaveSetting(changeSetting, filePath);
            MessageBox.Show("Save successful.");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this program ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }          
        }

        //Chi cho phep nhap so
        private void cmbKanjiFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void cmbKanaFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void cmbImiFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void cmbDelayTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void cmbDisplayTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

    }
}
