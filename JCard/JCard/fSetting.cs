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
    public partial class fSetting : Form
    {
        string strFileSettingPath = Application.StartupPath + @"\Setting.ini";
        ResourceManager objResourceManager;
        CultureInfo objCulInfo;
        public fSetting()
        {
            InitializeComponent();
           // strFilePath = fPath;
            SetDisplayLabel();
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

        public void SetDisplayLabel()
        {
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fSetting).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
            if (objResourceManager != null)
            {
                this.Text = Common.GetResourceValue(Constants.RES_VOCABSETT_NAME, objCulInfo, objResourceManager, Constants.RES_VOCABSETT_VALUE);
                groupBox1.Text = Common.GetResourceValue(Constants.RES_GRBPOS_NAME, objCulInfo, objResourceManager, Constants.RES_GRBPOS_VALUE);
                groupBox2.Text = Common.GetResourceValue(Constants.RES_GRBPROP_NAME, objCulInfo, objResourceManager, Constants.RES_GRBPROP_VALUE);
                radioButton1.Text = Common.GetResourceValue(Constants.RES_RADTR_NAME, objCulInfo, objResourceManager, Constants.RES_RADTR_VALUE);
                radioButton2.Text = Common.GetResourceValue(Constants.RES_RADBL_NAME, objCulInfo, objResourceManager, Constants.RES_RADBL_VALUE);
                radioButton4.Text = Common.GetResourceValue(Constants.RES_RADTR_NAME, objCulInfo, objResourceManager, Constants.RES_RADTR_VALUE);
                radBottRight.Text = Common.GetResourceValue(Constants.RES_RADBR_NAME, objCulInfo, objResourceManager, Constants.RES_RADBR_VALUE);
                label2.Text = Common.GetResourceValue(Constants.RES_LBLDISPLAY_NAME, objCulInfo, objResourceManager, Constants.RES_LBLDISPLAY_VALUE);
                label3.Text = Common.GetResourceValue(Constants.RES_LBLDELAY_NAME, objCulInfo, objResourceManager, Constants.RES_LBLDELAY_VALUE);
                label1.Text = Common.GetResourceValue(Constants.RES_LBLFKANJI_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFKANJI_VALUE);
                label4.Text = Common.GetResourceValue(Constants.RES_LBLFKANA_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFKANA_VALUE);
                label7.Text = Common.GetResourceValue(Constants.RES_LBLFHAN_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFHAN_VALUE);
                label8.Text = Common.GetResourceValue(Constants.RES_LBLFMEANING_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFMEANING_VALUE);
                button1.Text = Common.GetResourceValue(Constants.RES_BTNSAVE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSAVE_VALUE);
                button2.Text = Common.GetResourceValue(Constants.RES_BTNCANCEL_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCANCEL_VALUE);
            }
        }
    }
}