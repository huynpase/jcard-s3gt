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
        DTO_Setting dtoSetting = new DTO_Setting();
        BUS_Setting busSetting = new BUS_Setting();
        BUS_Setting bus = new BUS_Setting();
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
            try
            {
                dtoSetting.PositionVOC = CheckValueRadioButton();
                dtoSetting.DisplayTimeVOC = int.Parse(numDisTime.Text);
                dtoSetting.WaitingTimeVOC = int.Parse(numDelayTime.Text);
                //Kanji
                dtoSetting.Kanji_Fontsize = int.Parse(numKanjiFontsize.Text);
                dtoSetting.Kanji_BackColor = pnlKanjiBgClr.BackColor.ToArgb();
                dtoSetting.Kanji_FontColor = pnlKanjiFClr.BackColor.ToArgb();
                dtoSetting.Kanji_IsDisplayed = chkboxKanji.Checked;
                //Hiragana
                dtoSetting.Hiragana_Fontsize = int.Parse(numHiraganaFontsize.Text);
                dtoSetting.Hiragana_BackColor = pnlHiraganaBgClr.BackColor.ToArgb();
                dtoSetting.Hiragana_FontColor = pnlHiraganaFClr.BackColor.ToArgb();
                dtoSetting.Hiragana_IsDisplayed = chkboxHiragana.Checked;
                //Meaning
                dtoSetting.Meaning_Fontsize = int.Parse(numMeaningFontsize.Text);
                dtoSetting.Meaning_BackColor = pnlMeaningBgClr.BackColor.ToArgb();
                dtoSetting.Meaning_FontColor = pnlMeaningFClr.BackColor.ToArgb();
                dtoSetting.Meaning_IsDisplayed = chkboxMeaning.Checked;
                //
                busSetting.SaveSetting(dtoSetting, strFileSettingPath);
            }
            catch (Exception ex)
            {
                Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
            }

            Common.ShowInfoMsg(objCulInfo, objResourceManager, Constants.RES_SAVE_SETTING_SUCESSFULL_NAME,
                Constants.RES_SAVE_SETTING_SUCESSFULL_VALUE);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitValue()
        {
            dtoSetting = bus.ReadSetting(strFileSettingPath);
            //
            AssignValueRadioButton();
            numDisTime.Text = dtoSetting.DisplayTimeVOC.ToString();
            numDelayTime.Text = dtoSetting.WaitingTimeVOC.ToString();
            //Kanji
            pnlKanjiBgClr.BackColor = Color.FromArgb(dtoSetting.Kanji_BackColor);
            pnlKanjiFClr.BackColor = Color.FromArgb(dtoSetting.Kanji_FontColor);
            chkboxKanji.Checked = dtoSetting.Kanji_IsDisplayed;
            numKanjiFontsize.Text = dtoSetting.Kanji_Fontsize.ToString();
            //Hiragana
            pnlHiraganaBgClr.BackColor = Color.FromArgb(dtoSetting.Hiragana_BackColor);
            pnlHiraganaFClr.BackColor = Color.FromArgb(dtoSetting.Hiragana_FontColor);
            chkboxHiragana.Checked = dtoSetting.Hiragana_IsDisplayed;
            numHiraganaFontsize.Text = dtoSetting.Hiragana_Fontsize.ToString();
            //Meaning
            pnlMeaningBgClr.BackColor = Color.FromArgb(dtoSetting.Meaning_BackColor);
            pnlMeaningFClr.BackColor = Color.FromArgb(dtoSetting.Meaning_FontColor);
            chkboxMeaning.Checked = dtoSetting.Meaning_IsDisplayed;
            numMeaningFontsize.Text = dtoSetting.Meaning_Fontsize.ToString();
        }

        private void fSetting_Load(object sender, EventArgs e)
        {
            InitValue();
        }

        public void SetDisplayLabel()
        {
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fSetting).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
            this.Text = Common.GetResourceValue(Constants.RES_VOCABSETT_NAME, objCulInfo, objResourceManager, Constants.RES_VOCABSETT_VALUE);
            groupBox1.Text = Common.GetResourceValue(Constants.RES_GRBGEN_NAME, objCulInfo, objResourceManager, Constants.RES_GRBGEN_VALUE);
            grbMeaning.Text = Common.GetResourceValue(Constants.RES_GRBPROP_NAME, objCulInfo, objResourceManager, Constants.RES_GRBPROP_VALUE);
            radTopLeft.Text = Common.GetResourceValue(Constants.RES_RADTL_NAME, objCulInfo, objResourceManager, Constants.RES_RADTL_VALUE);
            radBottLeft.Text = Common.GetResourceValue(Constants.RES_RADBL_NAME, objCulInfo, objResourceManager, Constants.RES_RADBL_VALUE);
            radTopRight.Text = Common.GetResourceValue(Constants.RES_RADTR_NAME, objCulInfo, objResourceManager, Constants.RES_RADTR_VALUE);
            radBottRight.Text = Common.GetResourceValue(Constants.RES_RADBR_NAME, objCulInfo, objResourceManager, Constants.RES_RADBR_VALUE);
            label2.Text = Common.GetResourceValue(Constants.RES_LBLDISPLAY_NAME, objCulInfo, objResourceManager, Constants.RES_LBLDISPLAY_VALUE);
            label3.Text = Common.GetResourceValue(Constants.RES_LBLDELAY_NAME, objCulInfo, objResourceManager, Constants.RES_LBLDELAY_VALUE);
            lblKanjiFontsize.Text = Common.GetResourceValue(Constants.RES_FONTSIZE_NAME, objCulInfo, objResourceManager, Constants.RES_FONTSIZE_VALUE);
            lblHiraganaFontsize.Text = Common.GetResourceValue(Constants.RES_FONTSIZE_NAME, objCulInfo, objResourceManager, Constants.RES_FONTSIZE_VALUE);
            lblMeaningFColor.Text = Common.GetResourceValue(Constants.RES_FONTSIZE_NAME, objCulInfo, objResourceManager, Constants.RES_FONTSIZE_VALUE);
            lblMeaningFontsize.Text = Common.GetResourceValue(Constants.RES_FONTSIZE_NAME, objCulInfo, objResourceManager, Constants.RES_FONTSIZE_VALUE);
            button1.Text = Common.GetResourceValue(Constants.RES_BTNSAVE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSAVE_VALUE);
            button2.Text = Common.GetResourceValue(Constants.RES_BTNCANCEL_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCANCEL_VALUE);
            lblKanjiBgColor.Text = Common.GetResourceValue(Constants.RES_LBLBGCLR_NAME, objCulInfo, objResourceManager, Constants.RES_LBLBGCLR_VALUE);
            lblKanjiFColor.Text = Common.GetResourceValue(Constants.RES_LBLFCLR_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFCLR_VALUE);
            lblHiraganaBgColor.Text = Common.GetResourceValue(Constants.RES_LBLBGCLR_NAME, objCulInfo, objResourceManager, Constants.RES_LBLBGCLR_VALUE);
            lblHiraganaFColor.Text = Common.GetResourceValue(Constants.RES_LBLFCLR_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFCLR_VALUE);
            lblMeaningBgColor.Text = Common.GetResourceValue(Constants.RES_LBLBGCLR_NAME, objCulInfo, objResourceManager, Constants.RES_LBLBGCLR_VALUE);
            lblMeaningFColor.Text = Common.GetResourceValue(Constants.RES_LBLFCLR_NAME, objCulInfo, objResourceManager, Constants.RES_LBLFCLR_VALUE);
            chkboxKanji.Text = Common.GetResourceValue(Constants.RES_CHKBOXISDISPLAYED_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXISDISPLAYED_VALUE);
            chkboxHiragana.Text = Common.GetResourceValue(Constants.RES_CHKBOXISDISPLAYED_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXISDISPLAYED_VALUE);
            chkboxMeaning.Text = Common.GetResourceValue(Constants.RES_CHKBOXISDISPLAYED_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXISDISPLAYED_VALUE);
        }

        #region Kanji
        private void pnlKanjiBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlKanjiBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlKanjiBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlKanjiFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlKanjiFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlKanjiFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion

        #region Hiragana

        private void pnlHiraganaBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlHiraganaBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlHiraganaBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlHiraganaFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlHiraganaFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlHiraganaFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion

        #region Meaning
        private void pnlMeaningBgClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlMeaningBgClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlMeaningBgClr.BackColor = colorDialog.Color;
            }
        }

        private void pnlMeaningFClr_DoubleClick(object sender, EventArgs e)
        {
            //Create a ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = pnlMeaningFClr.BackColor;
            //Change the color
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnlMeaningFClr.BackColor = colorDialog.Color;
            }
        }
        #endregion

        #region RadioButton
        private string CheckValueRadioButton()
        {
            if (radTopLeft.Checked == true)
                return "TL";
            else if (radTopRight.Checked == true)
                return "TR";
            else if (radBottLeft.Checked == true)
                return "BL";
            else
                return "BR";
        }

        private void AssignValueRadioButton()
        {
            switch (dtoSetting.PositionVOC)
            {
                case "TL":
                    radTopLeft.Checked = true;
                    break;
                case "TR":
                    radTopRight.Checked = true;
                    break;
                case "BL":
                    radBottLeft.Checked = true;
                    break;
                default:
                    radBottRight.Checked = true;
                    break;
            }
        }
        #endregion
    }
}