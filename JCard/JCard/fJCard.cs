using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.IO;
using System.Resources;
using System.Globalization;

namespace JCard
{
    public partial class fJCard : Form
    {
        #region Variables for resource
        ResourceManager objResourceManager;
        CultureInfo objCulInfo;
        #endregion

        // Declare global variable
        //  int iTimeMoDan = 0; // Thoi gian lam form mo dan
        int _iTimeDisplayNewWord = 0; // thoi gian hien thi 1 tu
        int _iWatingTime = 0;  //thoi gian cho doi de load tu moi

        // Cac Bien Luu tru cac gia tri da setting o form Setting
        //  int _setTimeMoDan;
        //int _setTimeDisplayNewWord = 3; // Gia tri mac dinh la 5
        //int _setWatingTime = 3; // Set thoi gian cho de load tu moi( doc tu file xml)
        //string _strPosition = "";//"BR";
        //int _iFontsizeKanji = 0; //19
        //int _iFontsizeHira = 0; //16
        //int _iFontsizeImi = 0;// 13
        //int _iPreData = 0; 

        DTO_Setting rSetting = new DTO_Setting();



        // Variable of flag, using to control timer
        int _iFlagChooseLesson = 0; // 0 :  program is stopped now,  1 : OK  run other timers

        // Mang chua Danh sach cac tu vung lay duoc
        ArrayList arrVocabulary = new ArrayList();
        // Mang chua cac tu da hien thi ( se remove ra khoi mang arrVocabulary) neu mang nay full
        // Se tien hanh hien thi ran dom cac tu vung trong mang nay sau do remove cac phan tu ra khoi mang nay
        // SAu do add tro lai mang arrVocabulary ---> loop lai den khi nao exit chuong trinh thi thoi
        ArrayList arrVocabularyTemp = new ArrayList();
        // Mang chua cac thong tin setting
        ArrayList arrSetting = new ArrayList();

        int pos = 0; //Vi tri cua tu vung hien tai
        int VocCount = 0; // So luong tu vung load duoc

        // Parent form used when back to Parent form
        fCLesson frmParent;

        //public fJCard(int iFlag, ArrayList arrVoc)
        public fJCard(int iFlag, ArrayList arrVoc, fCLesson frmParent)
        {
            this.frmParent = frmParent;     // set parent form

            InitializeComponent();
            // Set vi tri hien thi form o goc duoi ben phai
            // Sau nay se doc tu file setting len
            SetDisplayLabel();
            _iFlagChooseLesson = iFlag;
            arrVocabulary = arrVoc;
            //Lay du lieu tu setting ben form main
            SetSettingValue();
            // Set start position
            SetStartPosition(rSetting.PositionVOC);
        }

        public void SetDisplayLabel()
        {
            // Create a resource manager to retrieve resources.
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fJCard).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
            this.Text = Common.GetResourceValue(Constants.RES_VOCABULARY_NAME, objCulInfo, objResourceManager, Constants.RES_VOCABULARY_VALUE);
            notifyIcon1.Text = Common.GetResourceValue(Constants.RES_PROGRAM_NAME, objCulInfo, objResourceManager, Constants.RES_PROGRAM_VALUE);
            vocabularyToolStripMenuItem.Text = Common.GetResourceValue(Constants.RES_MAINSCREEN_NAME, objCulInfo, objResourceManager, Constants.RES_MAINSCREEN_VALUE);
            aboutToolStripMenuItem.Text = Common.GetResourceValue(Constants.RES_ABOUT_NAME, objCulInfo, objResourceManager, Constants.RES_ABOUT_VALUE);
            exitToolStripMenuItem.Text = Common.GetResourceValue(Constants.RES_EXIT_NAME, objCulInfo, objResourceManager, Constants.RES_EXIT_VALUE);
        }

        // Ham xu li viec gan gia tri can hien thi cho nguoi dung 
        private void SetContent(int count)
        {
            DTO_VOC dtoVoc = new DTO_VOC();
            dtoVoc = (DTO_VOC)arrVocabulary[count];
            int iDecrease = 0;
            //Check Empty String            
            //Kanji
            if (String.Compare(dtoVoc.Kanji, "") == 0)
            {
                pnlKanji.Visible = false;
                iDecrease += pnlKanji.Height;
                pnlKanji.Height = 0;
            }
            else
            {
                txtKanji.Text = dtoVoc.Kanji;
            }
            //Hiragana
            if (String.Compare(dtoVoc.Hiragana, "") == 0)
            {
                pnlHiragana.Visible = false;
                iDecrease += pnlHiragana.Height;
                pnlHiragana.Height = 0;
            }
            else
            {
                txtHiragana.Text = dtoVoc.Hiragana;
            }
            //Meaning
            if (String.Compare(dtoVoc.Meaning, "") == 0)
            {
                pnlKanji.Visible = false;
                iDecrease += pnlKanji.Height;
                pnlKanji.Height = 0;
            }
            else
            {
                txtMeaning.Text = dtoVoc.Meaning;
            }
            //                     
            this.Top += iDecrease;
            this.Height = pnlKanji.Height + pnlHiragana.Height + pnlMeaning.Height;
        }

        private void FJCardLoad(object sender, EventArgs e)
        {
            // Show form load choose lesson first
            //++20100903 Edit code cho nay, bo show form chon bai hoc truoc[ start]
            // fCLesson fCL = new fCLesson();
            // fCL.sendData = new fCLesson.SendData(GetValueFromChooseLessonForm);
            //fCL.ShowDialog();  
            //++20100903 Edit code cho nay, bo show form chon bai hoc truoc[ end]
            this.Hide(); // an form

            notifyIcon1.Visible = true; // show notify Icon		
            VocCount = arrVocabulary.Count; // count tong so luong tu vung                       
        }

        // Ham su dung de get value tu form chon lesson fCLesson , tham so co the thay doi tuy theo so luong muon lay
        private void GetValueFromChooseLessonForm(int flag, ArrayList arrVoc)
        {
            _iFlagChooseLesson = flag; // bat co cho timer control chay
            arrVocabulary = arrVoc; // lay duoc danh sach cac tu vung da chon ben form fCLesson
        }


        //Viet ham Change Font Size
        static public Font ChangeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize,
                        font.Style, font.Unit,
                        font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            return font;
        }
        // set cac thong setting da load duoc tu file setting.xml
        /// <summary>
        /// Sets the setting value.
        /// </summary>
        private void SetSettingValue()
        {
            // Read config
            string startupPath = Application.StartupPath;
            startupPath += @"\Setting.ini";
            rSetting = new DTO_Setting();
            rSetting = ReadIniSetting(startupPath);

            //Set config 
            //Kanji
            if (rSetting.Kanji_IsDisplayed)
            {
                pnlKanji.BackColor = Color.FromArgb(rSetting.Kanji_BackColor);
                pnlKanji.ForeColor = Color.FromArgb(rSetting.Kanji_FontColor);
                txtKanji.Font = ChangeFontSize(txtKanji.Font, rSetting.Kanji_Fontsize);
                txtKanji.Height += (int)txtKanji.Font.Size - Constants.MinFontSizeVOC;
                //pnlKanji.Width += (int)txtKanji.Font.Size - Constants.MinFontSizeVOC;

                pnlKanji.Height = txtKanji.Height + 2 * Constants.TOP_BOTTOM_SPACE_LABEL_PANEL;
                txtKanji.Left = Constants.LEFT_RIGHT_SPACE_LABEL_PANEL;
                txtKanji.Top = Constants.TOP_BOTTOM_SPACE_LABEL_PANEL;
                txtKanji.Width = rSetting.Width - 2 * Constants.LEFT_RIGHT_SPACE_LABEL_PANEL;
            }
            else
            {
                pnlKanji.Visible = false;
                pnlKanji.Height = 0;
            }
            //Hiragana
            if (rSetting.Hiragana_IsDisplayed)
            {
                pnlHiragana.BackColor = Color.FromArgb(rSetting.Hiragana_BackColor);
                pnlHiragana.ForeColor = Color.FromArgb(rSetting.Hiragana_FontColor);
                txtHiragana.Font = ChangeFontSize(txtHiragana.Font, rSetting.Hiragana_Fontsize);
                txtHiragana.Height += (int)txtHiragana.Font.Size - Constants.MinFontSizeVOC;
                //pnlHiragana.Width += (int)txtHiragana.Font.Size - Constants.MinFontSizeVOC;

                pnlHiragana.Height = txtHiragana.Height + 2 * Constants.TOP_BOTTOM_SPACE_LABEL_PANEL;
                txtHiragana.Left = Constants.LEFT_RIGHT_SPACE_LABEL_PANEL;
                txtHiragana.Top = Constants.TOP_BOTTOM_SPACE_LABEL_PANEL;
                txtHiragana.Width = rSetting.Width - 2 * Constants.LEFT_RIGHT_SPACE_LABEL_PANEL;
            }
            else
            {
                pnlHiragana.Visible = false;
                pnlHiragana.Height = 0;
            }
            //Meaning
            if (rSetting.Meaning_IsDisplayed)
            {
                pnlMeaning.BackColor = Color.FromArgb(rSetting.Meaning_BackColor);
                pnlMeaning.ForeColor = Color.FromArgb(rSetting.Meaning_FontColor);
                txtMeaning.Font = ChangeFontSize(txtMeaning.Font, rSetting.Meaning_Fontsize);
                txtMeaning.Height += (int)txtMeaning.Font.Size - Constants.MinFontSizeVOC;
                //pnlMeaning.Width += (int)txtMeaning.Font.Size - Constants.MinFontSizeVOC;    

                pnlMeaning.Height = txtMeaning.Height + 2 * Constants.TOP_BOTTOM_SPACE_LABEL_PANEL;
                txtMeaning.Left = Constants.LEFT_RIGHT_SPACE_LABEL_PANEL;
                txtMeaning.Top = Constants.TOP_BOTTOM_SPACE_LABEL_PANEL;
                txtMeaning.Width = rSetting.Width - 2 * Constants.LEFT_RIGHT_SPACE_LABEL_PANEL;
            }
            else
            {
                pnlMeaning.Visible = false;
                pnlMeaning.Height = 0;
            }

            // Set width            
            this.Width = rSetting.Width;
            this.Height = pnlKanji.Height + pnlHiragana.Height + pnlMeaning.Height;
        }

        #region Set Start Position
        private void SetStartPosition(string strStartPos)
        {
            if (strStartPos.Equals("BR")) // Bottom Right
            {
                pnlKanji_Right.Visible = false;
                pnlHiragana_Right.Visible = false;
                pnlImi_Right.Visible = false;
                SetFormPosAtBottomRight();
            }
            else if (strStartPos.Equals("TR")) // Top Right
            {
                pnlKanji_Right.Visible = false;
                pnlHiragana_Right.Visible = false;
                pnlImi_Right.Visible = false;
                SetFormPosAtTopRight();
            }
            else if (strStartPos.Equals("TL")) // Top Left
            {
                pnlKanji_Left.Visible = false;
                pnlHiragana_Left.Visible = false;
                pnlImi_Left.Visible = false;
                SetFormPosAtTopLeft();
            }
            else if (strStartPos.Equals("BL")) // Bottom Left
            {
                pnlKanji_Left.Visible = false;
                pnlHiragana_Left.Visible = false;
                pnlImi_Left.Visible = false;
                SetFormPosAtBottomLeft();
            }
        }

        private void SetFormPosAtBottomRight()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void SetFormPosAtTopRight()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void SetFormPosAtBottomLeft()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void SetFormPosAtTopLeft()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }
        #endregion

        #region Read & Save setting file from file setting.ini
        private DTO_Setting ReadIniSetting(string filePath)
        {
            BUS_Setting busSetting = new BUS_Setting();
            DTO_Setting dtoSetting = new DTO_Setting();
            dtoSetting = busSetting.ReadSetting(filePath);
            return dtoSetting;
        }

        // Save settings when closing
        private void SaveSettings(string filePath)
        {
            // Save settings
            BUS_Setting busSetting = new BUS_Setting();
            busSetting.SaveSetting(rSetting, filePath);
        }
        #endregion

        #region Xử lý Timer
        // Khoi dong cac timer dieu khien khi nhan duoc delegate 
        private void timer_Flag_Tick(object sender, EventArgs e)
        {
            if (_iFlagChooseLesson == 1)
            {
                timer3.Enabled = true;
                timer3_Tick(sender, e);
                this.TopMost = true; // Set form alway on top ++ fix bug hidden when click Window + D
                timer_Flag.Enabled = false;
                _iFlagChooseLesson = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e) // Dieu Khien Thoi Gian Cho Doi De Load Tu Moi
        {
            _iWatingTime++;
            if (_iWatingTime == rSetting.WaitingTimeVOC) // Co the thay doi gia tri sau nay trong phan setting thoi gian cho doi hien thi tu moi
            {
                timer4.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                _iWatingTime = 0;
                // Hien thi tu vung moi
                // Chua xu li hien thi ramdom ko bi trung lam
                if (pos <= VocCount - 1)
                {
                    Random ran = new Random();
                    pos = ran.Next(pos, VocCount - 1);
                    SetContent(pos);
                }
                else
                {
                    pos = 0;
                    SetContent(pos);
                }
                pos++;

            }
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            this.Opacity += 0.02; // Lam Form sang dan
            if (this.Opacity == 1)
            {
                timer1.Enabled = true;  // dieu khien thoi gian hien thi tu
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.Opacity -= 0.01; // Lam Form Mo dan;
            if (this.Opacity == 0)
            {
                timer3.Enabled = true;
                timer2.Enabled = false;
                timer1.Enabled = false;
                timer4.Enabled = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Thoi gian hien thi mot tu vung moi

            _iTimeDisplayNewWord++;
            //if (_iTimeDisplayNewWord == _setTimeDisplayNewWord)
            if (_iTimeDisplayNewWord == rSetting.DisplayTimeVOC)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                _iTimeDisplayNewWord = 0;
            }
        }
        #endregion

        #region  Xu li hieu ung mouse over, mouse leave
        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Opacity = 0;
        }

        private void txtKanji_MouseHover(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Opacity = 1;
        }

        private void txtKanji_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtHiragana_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtHiragana_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtHanNom_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtMeaning_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtMeaning_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Xử Context Menu
        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            DialogResult dr = Common.ShowConfirmMsg(objCulInfo, objResourceManager, Constants.RES_CLOSE_PROGRAM_NAME,
                Constants.RES_CLOSE_PROGRAM_VALUE);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fabout = new About();
            fabout.ShowDialog();
        }

        private void vocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //Application.Restart();
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer_Flag.Enabled = false;
            frmParent.ReShow();
            this.Close();
        }
        #endregion

        #region Change Width
        private bool bClick;
        private Point PastPoint;
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            bClick = true;
            PastPoint.X = e.X;
            PastPoint.Y = e.Y;
            Invalidate();
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            bClick = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (bClick)
            {
                int delWidth = e.X - PastPoint.X;
                int temp = this.Width + delWidth;
                if (temp >= Constants.MIN_WIDTH && temp <= Constants.MAX_WIDTH)
                {
                    txtKanji.Width += delWidth;
                    txtHiragana.Width += delWidth;
                    txtMeaning.Width += delWidth;
                    this.Width += delWidth;
                }
            }
        }

        private void panel5_MouseMove2(object sender, MouseEventArgs e)
        {
            if (bClick)
            {
                int delWidth = e.X - PastPoint.X;
                int temp = this.Width - delWidth;
                if (temp >= Constants.MIN_WIDTH && temp <= Constants.MAX_WIDTH)
                {
                    txtKanji.Width -= delWidth;
                    txtHiragana.Width -= delWidth;
                    txtMeaning.Width -= delWidth;
                    this.Left += delWidth;
                    this.Width -= delWidth;
                }
            }
        }
        #endregion

        #region Paint Ellipsis Text of Label
        private void Ellipsis_Label_Paint(object sender, PaintEventArgs e)
        {
            Common.DrawEllipsisText((Label)sender, e.Graphics);
        }
        #endregion

        #region Xử lý cho Tooltip
        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            /* Support tooltip visible tu khi mouse move cho den khi mouse leave */
            string str = toolTip.GetToolTip(lbl);
            if (string.IsNullOrEmpty(str))// kiem tra co dang show tooltip hay khong
            {
                BringToFront();

                int Y = Common.GetTopPosOfTooltip(lbl.Text, lbl);
                toolTip.Show(lbl.Text, lbl, e.X, Y);
            }
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide((Label)sender);
        }
        #endregion

        #region Xử lý khi close
        private void fJCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save config
            string startupPath = Application.StartupPath;
            startupPath += @"\Setting.ini";
            rSetting.Width = this.Width;
            SaveSettings(startupPath);
        }
        #endregion
    }
}