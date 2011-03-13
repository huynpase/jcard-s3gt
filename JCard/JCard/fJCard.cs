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


namespace JCard
{
    public partial class fJCard : Form
    {
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

    
        public fJCard(int iFlag, ArrayList arrVoc)
        {
            InitializeComponent();
            // Set vi tri hien thi form o goc duoi ben phai
            // Sau nay se doc tu file setting len

            _iFlagChooseLesson = iFlag;
            arrVocabulary = arrVoc;


            //Lay du lieu tu setting ben form main
            SetSettingValue();
            setFormPosAtBottomRight();
                       
        }

        private void setFormPosAtBottomRight()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        // Ham xu li viec gan gia tri can hien thi cho nguoi dung 
        private void SetContent(int count) 
         {
             DTO_VOC dtoVoc = new DTO_VOC();
             dtoVoc = (DTO_VOC)arrVocabulary[count];
             txtKanji.Text = dtoVoc.Kanji;
             txtHiragana.Text = dtoVoc.Hiragana;
             txtHanNom.Text = dtoVoc.Hannom;
            txtMeaning.Text = dtoVoc.Meaning;
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

            this.FormBorderStyle = FormBorderStyle.None;

            notifyIcon1.Visible = true; // show notify Icon		
            VocCount = arrVocabulary.Count; // count tong so luong tu vung 
                    
                      
        }

        // Ham su dung de get value tu form chon lesson fCLesson , tham so co the thay doi tuy theo so luong muon lay
        private void GetValueFromChooseLessonForm(int flag,ArrayList arrVoc)
        {
            _iFlagChooseLesson = flag; // bat co cho timer control chay
            arrVocabulary  = arrVoc; // lay duoc danh sach cac tu vung da chon ben form fCLesson
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
        private void SetSettingValue()
        {
            ////Dung XML
            //// Call Function Read XML file
            //arrSetting = GetSettingInfoFromXML();
            
            // Tien hanh gan cac gia tri khoi tao ban dau 
            //setStartPosition(strPosition);
        	//this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //Nguyen
            //Dung file .ini
            //Co the khai bao them thuoc tinh trong DTO_Setting
            //-> Neu them thi nho khai bao them thuoc tinh o dau file nay
            string startupPath = Application.StartupPath;
            startupPath += @"\Setting.ini";
            rSetting = new DTO_Setting();
            rSetting = ReadIniSetting(startupPath);            

            //_strPosition = rSetting.PositionVOC;
            //_setTimeDisplayNewWord = rSetting.DisplayTimeVOC;
            //_setWatingTime = rSetting.WaitingTimeVOC;
            txtKanji.Font = ChangeFontSize(txtKanji.Font, rSetting.FontSizeKanjiVOC);
            txtHiragana.Font = ChangeFontSize(txtKanji.Font, rSetting.FontSizeKanaVOC);
            txtMeaning.Font = ChangeFontSize(txtKanji.Font, rSetting.FontSizeImiVOC);
            txtHanNom.Font = ChangeFontSize(txtKanji.Font, rSetting.FontSizeHanNom);
            //_iPreData = ?? //chua hieu dung cai nay de lam gi

        }
        
        private void setStartPosition(string strStartPos)
        {
            //if(_strPosition == "BR") // Botton Right
            //{
            //    setFormPosAtBottomRight(); 
            //}
            //else if(_strPosition == "TR") // Top Right
            //{
        		
            //}
            //else if(_strPosition == "TL") // Top Left
            //{
        		
            //}
            //else if(_strPosition == "BL") // Botton Left
            //{
        		
            //}
            //else // Default is Top Right
        		setFormPosAtBottomRight();
        	
        }
        // Khoi dong cac timer dieu khien khi nhan duoc delegate 
        private void timer_Flag_Tick(object sender, EventArgs e)
        {
            if (_iFlagChooseLesson == 1)
            {               
                timer3.Enabled = true;
                timer3_Tick(sender,e);
                 this.TopMost = true; // Set form alway on top ++ fix bug hidden when click Window + D
                timer_Flag.Enabled = false;
                _iFlagChooseLesson = 0;
            }
        }
                
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    pos = ran.Next(pos,VocCount-1);
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


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void settingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
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

       
        void FJCardMouseHover(object sender, EventArgs e)
        {
            
        	
        }
        
        void FJCardMouseLeave(object sender, EventArgs e)
        {         
          
        }



        #region //Read setting file from file setting.ini
        private DTO_Setting ReadIniSetting(string filePath)
        {
            BUS_Setting busSetting = new BUS_Setting();
            DTO_Setting dtoSetting = new DTO_Setting();
            dtoSetting = busSetting.ReadSetting(filePath);
            return dtoSetting;
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

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this program ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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

        private void settingToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            fCLesson.showTabSetting();
        }

        private void vocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Restart();
        }
       



    }
}