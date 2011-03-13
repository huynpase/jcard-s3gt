using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fSetting : Form
    {
        string strFileSettingPath = Application.StartupPath + @"\Setting.ini";
        public fSetting()
        {
            InitializeComponent();
           // strFilePath = fPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ghi gia tri xuong file setting.ini
            //PhuongHD add code 20110312
            DTO_Setting dtoSetting = new DTO_Setting();
            BUS_Setting busSetting = new BUS_Setting();
            // postition display from hien tai set mot vi tri la bottom right
            try
            {
                dtoSetting.PositionVOC = "BR";
                dtoSetting.DisplayTimeVOC = int.Parse(comDisTime.Text);
                dtoSetting.WaitingTimeVOC = int.Parse(comDeplayTime.Text);
                dtoSetting.FontSizeKanjiVOC = int.Parse(comFontKanji.Text);
                dtoSetting.FontSizeKanaVOC = int.Parse(comFontKana.Text);
                dtoSetting.FontSizeHanNom = int.Parse(comFontHanNom.Text);
                dtoSetting.FontSizeImiVOC = int.Parse(comFontMeaning.Text);

                
                busSetting.SaveSetting(dtoSetting,strFileSettingPath);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not save setting to file");
            }
           
            

            MessageBox.Show("Save Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitValue()
        {
            DTO_Setting dtoSetting = new DTO_Setting();
            BUS_Setting bus = new BUS_Setting();
            try
            {
                dtoSetting = bus.ReadSetting(strFileSettingPath);
                comDisTime.Text = dtoSetting.DisplayTimeVOC.ToString();
                comDeplayTime.Text = dtoSetting.WaitingTimeVOC.ToString();
                comFontKanji.Text = dtoSetting.FontSizeKanjiVOC.ToString();
                comFontKana.Text = dtoSetting.FontSizeKanaVOC.ToString();
                comFontHanNom.Text = dtoSetting.FontSizeHanNom.ToString();
                comFontMeaning.Text = dtoSetting.FontSizeImiVOC.ToString();
            }
            catch
            {

                MessageBox.Show("Error when read file setting");
            }
            
        }

        private void fSetting_Load(object sender, EventArgs e)
        {
            InitValue();
        }
    }
}