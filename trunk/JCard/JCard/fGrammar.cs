using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace JCard
{
    public partial class fGrammar : Form
    {
        #region Variables for resource
        ResourceManager objResourceManager;
        CultureInfo objCulInfo;
        #endregion

        /* Dong ho do dac thoi gian display va delay */
        private Timer timer;
        private Timer timer_wait;
        /* Bien flag cho biet dang o trang thai delay hay display
         * flag = true  : Delay
         * flag = false : Display
         */
        private bool flag;

        /* Grammar setting */
        private DTO_GramSetting dto_gramSetting;
        /* file path of grammar setting file */
        private string strSettingFile = @"\GramSettings.ini";

        /* So example da duoc hien thi */
        private int count_example;
        /* Vi tri example trong 1 list example cua 1 mau grammar card */
        private int index_example;
        /* So example toi da trong 1 mau grammar card */
        private int max_example;
        /* Tong example can duoc hien thi voi grammar card hien tai */
        private int sum_of_display_example;
        /* So example toi da duoc phep hien thi voi moi grammar card */
        private int example_ini;
        /* Vi tri Grammar card duoc hien thi */
        private int index_entry;
        /* So grammar card duoc hien thi */
        private int max_entry;
        private ArrayList arr_Entry;
        private ArrayList arr_tempEntry;

        /* Lay random 1 mau grammar card hoac 1 example bat ky */
        private Random rand;

        /* Xu ly get back grammar */
        ArrayList arr_CardForward = new ArrayList(); // List luu giu cac grammar card truoc do

        /* Xu ly get Back-Next example */
        ArrayList arr_CardExampleForward = new ArrayList(); // List luu giu cac grammar card truoc do - 
        // Xu ly trong truong hop da hien thi het vi du truoc do
        // cua grammar card hien tai
        ArrayList arr_ExampleForward = new ArrayList(); // List luu giu cac example truoc do

        public fGrammar(ArrayList arr_GramCards)
        {
            InitializeComponent();
            //setFormPosAtBottomRight();

            SetDisplayLabel();

            /* Khoi tao dong ho de do luong thoi gian hien thi grammar card */
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer_wait = new Timer();
            timer_wait.Tick += new EventHandler(timer_wait_Tick);
            flag = true;

            ///* Get Gram Setting        
            // Đọc setting values
            strSettingFile = Application.StartupPath + strSettingFile;
            BUS_GramSetting buGramSett = new BUS_GramSetting();
            dto_gramSetting = buGramSett.ReadGramSetting(strSettingFile);

            // Set thuộc tính hiển thị
            SetDisplayProperties();
            //*/           

            ///* Tạo một bản Copy của arr_Entry
            arr_Entry = arr_GramCards;
            arr_tempEntry = new ArrayList();
            DTO_Grammar dto;
            for (int i = 0; i < arr_Entry.Count; i++)
            {
                dto = new DTO_Grammar((DTO_Grammar)arr_Entry[i]);
                arr_tempEntry.Add(dto);
            }
            //*/

            /* So example duoc phep hien thi trong moi grammar card: Set cung */
            example_ini = dto_gramSetting.Ex_NoOfDisplay;

            /* Display grammar card va example dau tien khi vua moi load chuong trinh len */
            rand = new Random();
            if (arr_Entry.Count >= 1)
            {
                index_entry = rand.Next(0, arr_Entry.Count - 1);
                arr_CardForward.Add(index_entry);
                arr_CardExampleForward.Add(index_entry);
                max_entry = arr_Entry.Count;
                max_example = ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP.Count;
                if (example_ini < max_example)
                {
                    sum_of_display_example = example_ini;
                }
                else
                {
                    sum_of_display_example = max_example;
                }

                /* Khoi tao, hien thi grammar card dau tien khi load ung dung len */
                SetControlValues(arr_Entry, index_entry);
                count_example = 0;
                if (sum_of_display_example >= 1)
                {
                    index_example = rand.Next(0, max_example - 1);
                    arr_ExampleForward.Add(index_example);
                    // lblExample.Text = ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP[index_example].ToString();
                    // toolTip4.SetToolTip(lblExample, lblExample.Text);
                    lblExample.Text = ((DTO_Grammar)arr_Entry[index_entry]).GetExample(
                        index_example, dto_gramSetting.Ex_VN_IsDisplayed, true);
                    toolTip4.SetToolTip(lblExample, ((DTO_Grammar)arr_Entry[index_entry]).GetExample(
                        index_example, dto_gramSetting.Ex_VN_IsDisplayed, false));
                    ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP.RemoveAt(index_example);
                    ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleVN.RemoveAt(index_example);
                    max_example--;
                }
            }
        }

        public void SetDisplayLabel()
        {
            // Create a resource manager to retrieve resources.
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fGrammar).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
            backToMainScreenToolStripMenuItem.Text = Common.GetResourceValue(Constants.RES_MAINSCREEN_NAME, objCulInfo, objResourceManager, Constants.RES_MAINSCREEN_VALUE);
            aboutToolStripMenuItem.Text = Common.GetResourceValue(Constants.RES_ABOUT_NAME, objCulInfo, objResourceManager, Constants.RES_ABOUT_VALUE);
            exitToolStripMenuItem.Text = Common.GetResourceValue(Constants.RES_EXIT_NAME, objCulInfo, objResourceManager, Constants.RES_EXIT_VALUE);
        }

        // Set vi tri ban dau cua form
        private void setFormPosAtBottomRight()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        // Set thuộc tính hiển thị cho các area.
        private void SetDisplayProperties()
        {
            // Display position
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(dto_gramSetting.Left, dto_gramSetting.Top);

            // Sample area
            pnlSample.BackColor = Color.FromArgb(dto_gramSetting.BackColor);
            pnlSample.ForeColor = Color.FromArgb(dto_gramSetting.ForeColor);

            // JP Meaning area
            pnlJPMeaning.BackColor = Color.FromArgb(dto_gramSetting.JP_BackColor);
            pnlJPMeaning.ForeColor = Color.FromArgb(dto_gramSetting.JP_ForeColor);

            // VN Meaning area
            pnlVNMeaning.BackColor = Color.FromArgb(dto_gramSetting.VN_BackColor);
            pnlVNMeaning.ForeColor = Color.FromArgb(dto_gramSetting.VN_ForeColor);

            // Example area
            pnlExample.BackColor = Color.FromArgb(dto_gramSetting.Ex_BackColor);
            pnlExample.ForeColor = Color.FromArgb(dto_gramSetting.Ex_ForeColor);


            // Set top, left and height of Meaning            
            lblJPMeaning.Top = (pnlJPMeaning.Height - lblJPMeaning.Height) / 2;
            lblJPMeaning.Left = 2;

            lblVNMeaning.Top = lblJPMeaning.Top;
            lblVNMeaning.Left = lblJPMeaning.Left;

            // Resize
            if ((!dto_gramSetting.JP_Isdisplayed || !dto_gramSetting.VN_IsDisplayed))
            {
                if (!dto_gramSetting.Ex_VN_IsDisplayed || dto_gramSetting.Ex_NoOfDisplay == 0)
                {
                    this.Height = 38;

                    btnExampleNxt.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                    btnExampleNxt.Height = this.Height / 2;

                    btnExamplePrev.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                    btnExamplePrev.Height = this.Height / 2;

                    btnNext.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                    btnNext.Height = this.Height / 2;

                    btnPrevious.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                    btnPrevious.Height = this.Height / 2;

                    pnlSample.Height = this.Height;
                    pnlExample.Height = this.Height;
                    pnlJPMeaning.Height = pnlVNMeaning.Height = this.Height;
                }
                else
                {
                    // Display or Non-Display JP/VN Meaning area
                    if (dto_gramSetting.VN_IsDisplayed)
                    {
                        pnlVNMeaning.Height = pnlVNMeaning.Height * 2;
                        lblVNMeaning.Height = lblVNMeaning.Height * 2;
                        lblVNMeaning.Top = (pnlVNMeaning.Height - lblVNMeaning.Height) / 2;
                    }
                    else if (dto_gramSetting.JP_Isdisplayed)
                    {
                        pnlJPMeaning.Height = pnlJPMeaning.Height * 2;
                        lblJPMeaning.Height = lblJPMeaning.Height * 2;
                        lblJPMeaning.Top = (pnlJPMeaning.Height - lblJPMeaning.Height) / 2;
                    }
                }
            }

            // Set width
            SetWidthOfArea();
        }

        private void SetWidthOfArea()
        {
            // Sample area            
            pnlSample.Width = dto_gramSetting.Width;
            lblSample.Width = pnlSample.Width - 4;
            lblSample.Top = (pnlSample.Height - lblSample.Height) / 2;
            lblSample.Left = 2;

            // JP Meaning area           
            pnlJPMeaning.Width = dto_gramSetting.JP_Width;
            pnlJPMeaning.Left = pnlSample.Left + pnlSample.Width;
            lblJPMeaning.Width = pnlJPMeaning.Width - 4;

            // VN Meaning area            
            pnlVNMeaning.Width = dto_gramSetting.VN_Width;
            pnlVNMeaning.Left = pnlJPMeaning.Left;
            lblVNMeaning.Width = lblJPMeaning.Width;

            // Example area
            pnlExample.Width = dto_gramSetting.Ex_Width;

            // Display or Non-Display JP/VN Meaning area
            if (!dto_gramSetting.JP_Isdisplayed && !dto_gramSetting.VN_IsDisplayed)
            {
                pnlJPMeaning.Visible = false;
                pnlVNMeaning.Visible = false;
                pnlJPMeanWidth.Visible = false;
                pnlExample.Left = pnlSample.Left + pnlSample.Width;

                // Check no of display.
                if (dto_gramSetting.Ex_NoOfDisplay == 0)
                {
                    pnlExample.Visible = false;

                    // Set with of screen
                    this.Width = pnlTitle.Width + pnlButtons.Width + pnlButtons2.Width + pnlSample.Width;
                }
                else
                {
                    // Set with of screen
                    this.Width = pnlTitle.Width + pnlButtons.Width + pnlButtons2.Width + pnlSample.Width + pnlExample.Width;
                }
            }
            else
            {
                if (!dto_gramSetting.JP_Isdisplayed)
                {
                    pnlJPMeaning.Visible = false;
                    pnlVNMeaning.Visible = true;
                    pnlVNMeaning.Top = 0;                    
                }
                else if (!dto_gramSetting.VN_IsDisplayed)
                {
                    pnlJPMeaning.Visible = true;
                    pnlVNMeaning.Visible = false;
                }

                pnlExample.Left = pnlJPMeaning.Left + pnlJPMeaning.Width;

                // Check no of display.
                if (dto_gramSetting.Ex_NoOfDisplay == 0)
                {
                    pnlExample.Visible = false;

                    // Set with of screen
                    this.Width = pnlTitle.Width + pnlButtons.Width + pnlButtons2.Width +
                                pnlSample.Width + pnlJPMeaning.Width;
                }
                else
                {
                    // Set with of screen
                    this.Width = pnlTitle.Width + pnlButtons.Width + pnlButtons2.Width +
                                pnlSample.Width + pnlJPMeaning.Width +
                                pnlExample.Width;
                }
            }
        }

        // Save settings when closing
        private void SaveSettings()
        {
            // Save settings
            BUS_GramSetting buGramSett = new BUS_GramSetting();
            dto_gramSetting.Top = this.Top;
            dto_gramSetting.Left = this.Left;
            buGramSett.SaveGramSetting(dto_gramSetting, strSettingFile);
        }

        // Ham xu ly sau moi tick dong ho
        public void timer_Tick(object o, EventArgs e)
        {
            if (flag)
            {// Control sang dan va hien thi cac grammar cards
                if (this.Opacity == 1)
                {
                    flag = false;
                    timer.Enabled = false;
                    timer_wait.Interval = dto_gramSetting.Ex_DisplayTime * 1000;
                    timer_wait.Start();
                }
                else
                {
                    if (this.Opacity == 0)
                    {
                        Display();
                    }
                    this.Opacity += 0.1;
                }
            }
            else
            {// Control mo dan va o trang thai delay
                if (this.Opacity == 0)
                {
                    flag = true;
                    timer.Enabled = false;
                    timer_wait.Interval = dto_gramSetting.Ex_DelayTime * 1000;
                    timer_wait.Start();
                }
                else
                {
                    this.Opacity -= 0.1;
                }
            }
        }
        // Doi cho het thoi gian Display/Delay
        public void timer_wait_Tick(object o, EventArgs e)
        {
            timer.Enabled = true;
            timer_wait.Stop();
        }

        /* Set gia tri Sample, Meaning_JP, Meaning_VN, Examples */
        private void SetControlValues(ArrayList arr_gram, int index)
        {
            lblSample.Text = ((DTO_Grammar)arr_gram[index]).STR_Sample;
            toolTip1.SetToolTip(pnlSample, lblSample.Text);
            toolTip1.SetToolTip(lblSample, lblSample.Text);
            if (dto_gramSetting.JP_Isdisplayed)
            {
                lblJPMeaning.Text = ((DTO_Grammar)arr_gram[index]).STR_Meaning_JP;
                string strTooltipMeaningJP = ((DTO_Grammar)arr_gram[index]).GetMeaningJP();
                toolTip2.SetToolTip(pnlJPMeaning, strTooltipMeaningJP);
                toolTip2.SetToolTip(lblJPMeaning, strTooltipMeaningJP);
                if (!dto_gramSetting.VN_IsDisplayed)
                {
                    lblVNMeaning.Text = lblJPMeaning.Text;
                    toolTip3.SetToolTip(pnlVNMeaning, strTooltipMeaningJP);
                    toolTip3.SetToolTip(lblVNMeaning, strTooltipMeaningJP);
                }
            }
            if (dto_gramSetting.VN_IsDisplayed)
            {
                lblVNMeaning.Text = ((DTO_Grammar)arr_gram[index]).STR_Meaning_VN;
                string strTooltipMeaningVN = ((DTO_Grammar)arr_gram[index]).GetMeaningVN();
                toolTip3.SetToolTip(pnlVNMeaning, strTooltipMeaningVN);
                toolTip3.SetToolTip(lblVNMeaning, strTooltipMeaningVN);
                if (!dto_gramSetting.JP_Isdisplayed)
                {
                    lblJPMeaning.Text = lblVNMeaning.Text;
                    toolTip2.SetToolTip(pnlJPMeaning, strTooltipMeaningVN);
                    toolTip2.SetToolTip(lblJPMeaning, strTooltipMeaningVN);
                }
            }
        }
        /* Ham xu ly chinh dung de hien thi grammar card va example */
        private void Display()
        {
            int i = 0, j = 0;
            count_example++;
            if (count_example == sum_of_display_example || sum_of_display_example == 0 || count_example_forward != 1)
            {// Truong hop da hien thi het example tuong voi mau grammar card hien tai
                if (max_entry > 1)
                {
                    // Lay random grammar card tiep theo
                    if (count_example == sum_of_display_example || sum_of_display_example == 0)
                    {
                        for (i = 0; i < arr_tempEntry.Count; i++)
                            if (((DTO_Grammar)arr_tempEntry[i]).LGR_ID == ((DTO_Grammar)arr_Entry[index_entry]).LGR_ID)
                                break;
                        arr_CardForward.Add(i);

                        count_forward = 0;
                        arr_Entry.RemoveAt(index_entry);
                        max_entry--;
                        index_entry = rand.Next(0, max_entry - 1);

                        count_example = 0;
                        max_example = ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP.Count;
                        if (example_ini < max_example)
                        {
                            sum_of_display_example = example_ini;
                        }
                        else
                        {
                            sum_of_display_example = max_example;
                        }
                    }

                    count_example_forward = 1;
                    SetControlValues(arr_Entry, index_entry);
                }
                else
                {// Truong hop da hien thi het tat ca grammar card
                    if (!(count_example == sum_of_display_example || sum_of_display_example == 0))
                    {
                        count_example_forward = 1;
                        SetControlValues(arr_Entry, index_entry);
                    }
                    else
                    {
                        this.Dispose();
                        Application.Restart();
                    }
                }
            }

            if (max_example >= 1 && sum_of_display_example >= 1)
            {
                /* Xu ly get back example */
                for (j = 0; j < arr_tempEntry.Count; j++)
                    if (((DTO_Grammar)arr_tempEntry[j]).LGR_ID == ((DTO_Grammar)arr_Entry[index_entry]).LGR_ID)
                        break;
                arr_CardExampleForward.Add(j);

                // Lay random example tiep theo
                index_example = rand.Next(0, max_example - 1);
                //lblExample.Text = ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP[index_example].ToString();
                //toolTip4.SetToolTip(lblExample, lblExample.Text);
                lblExample.Text = ((DTO_Grammar)arr_Entry[index_entry]).GetExample(
                        index_example, dto_gramSetting.Ex_VN_IsDisplayed, true);
                toolTip4.SetToolTip(lblExample, ((DTO_Grammar)arr_Entry[index_entry]).GetExample(
                        index_example, dto_gramSetting.Ex_VN_IsDisplayed, false));
                /* Xu ly get back example */
                for (i = 0; i < ((DTO_Grammar)arr_tempEntry[j]).ArrExampleJP.Count; i++)
                    if (((DTO_Grammar)arr_tempEntry[j]).ArrExampleJP[i].ToString().Equals(((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP[index_example].ToString()))
                    {
                        arr_ExampleForward.Add(i);
                        break;
                    }
                ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleJP.RemoveAt(index_example);
                ((DTO_Grammar)arr_Entry[index_entry]).ArrExampleVN.RemoveAt(index_example);
                max_example--; // Do vua display 1 example nen phai giam bien nay xuong 1
            }
            else
            {
                lblExample.Text = string.Empty;
                toolTip4.SetToolTip(lblExample, lblExample.Text);
            }
        }

        //Form fGrammar duoc load len
        private void fGrammar_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            timer.Start();
        }

        #region  Exit chuong trinh
        // Khi click exit tren contextMenuStrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = Common.ShowConfirmMsg(objCulInfo, objResourceManager, 
                Constants.RES_CLOSE_PROGRAM_NAME, Constants.RES_CLOSE_PROGRAM_VALUE);
            if (dr == DialogResult.Yes)
            {
                // Save settings
                SaveSettings();

                this.Dispose();
                Application.Exit();
            }
        }

        // Khi tien hanh close chuong trinh bang cach righ-click len icon cua ch/tr tren taskbar va click [x]
        private void fGrammar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings
            SaveSettings();

            this.Dispose();
            Application.Exit();
        }
        #endregion

        #region  Xu li hieu ung mouse over, mouse leave
        private void fGrammar_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void fGrammar_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void btnPrevious_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void btnNext_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void btnDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnDisplay_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void btnExamplePrev_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        private void btnExamplePrev_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnExampleNxt_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnExampleNxt_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }
        #endregion

        #region Next&Forward
        private int count_forward = 0; // Dem so lan back/lui cua grammar card
        // Hien thi grammar card truoc do
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (arr_CardForward.Count > 1 && count_forward < arr_CardForward.Count)
            {
                count_forward++;
                int temp_index_entry = (int)arr_CardForward[arr_CardForward.Count - count_forward];
                SetControlValues(arr_tempEntry, temp_index_entry);
                int temp_max_example = ((DTO_Grammar)arr_tempEntry[temp_index_entry]).ArrExampleJP.Count;
                if (temp_max_example >= 1 && example_ini >= 1)
                {
                    int temp_index_example = rand.Next(0, temp_max_example - 1);
                    //lblExample.Text = ((DTO_Grammar)arr_tempEntry[temp_index_entry]).ArrExampleJP[temp_index_example].ToString();
                    //toolTip4.SetToolTip(lblExample, lblExample.Text);
                    lblExample.Text = ((DTO_Grammar)arr_tempEntry[temp_index_entry]).GetExample(
                        temp_index_example, dto_gramSetting.Ex_VN_IsDisplayed, true);
                    toolTip4.SetToolTip(lblExample, ((DTO_Grammar)arr_tempEntry[temp_index_entry]).GetExample(
                        temp_index_example, dto_gramSetting.Ex_VN_IsDisplayed, false));
                }
                else
                {
                    lblExample.Text = string.Empty;
                    toolTip4.SetToolTip(lblExample, lblExample.Text);
                }

                //arr_CardForward.RemoveAt(arr_CardForward.Count - 1);
                count_example = sum_of_display_example - 1;
            }
        }

        // Hien thi grammar card tiep theo
        private void btnNext_Click(object sender, EventArgs e)
        {
            count_example = sum_of_display_example - 1;
            Display();
        }

        // Hien thi lai vi du truoc do. Neu da hien thi het vi du truoc do thi hien thi mau ngu phap truoc do.
        private int count_example_forward = 1; // Dem so lan back/lui cua example
        private void btnExamplePrev_Click(object sender, EventArgs e)
        {
            if (arr_CardExampleForward.Count > 1 && count_example_forward < arr_CardExampleForward.Count)
            {
                count_example_forward++;
                int temp_index_entry = (int)arr_CardExampleForward[arr_CardExampleForward.Count - count_example_forward];
                int temp_index_example = (int)arr_ExampleForward[arr_ExampleForward.Count - count_example_forward];
                SetControlValues(arr_tempEntry, temp_index_entry);
                //lblExample.Text = ((DTO_Grammar)arr_tempEntry[temp_index_entry]).ArrExampleJP[temp_index_example].ToString();
                //toolTip4.SetToolTip(lblExample, lblExample.Text);
                lblExample.Text = ((DTO_Grammar)arr_tempEntry[temp_index_entry]).GetExample(
                        temp_index_example, dto_gramSetting.Ex_VN_IsDisplayed, true);
                toolTip4.SetToolTip(lblExample, ((DTO_Grammar)arr_tempEntry[temp_index_entry]).GetExample(
                        temp_index_example, dto_gramSetting.Ex_VN_IsDisplayed, false));
            }
        }

        // Hien thi vi du tiep theo. Neu tat ca vi du da duoc hien thi thi hien thi grammar moi.
        private void btnExampleNxt_Click(object sender, EventArgs e)
        {
            Display();
        }
        #endregion

        // Tro ve man hinh chinh
        private void backToMainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save settings
            SaveSettings();

            this.Dispose();
            Application.Restart();
        }

        #region  Xu li Drag&Drop
        private bool bClick;
        private Point pDelta;
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
            timer.Enabled = false;
            this.Opacity = 1;

            if (bClick)
            {
                pDelta.X = e.X - PastPoint.X;
                pDelta.Y = e.Y - PastPoint.Y;
                int x = this.Location.X + pDelta.X;
                int y = this.Location.Y + pDelta.Y;
                this.Location = new Point(x, y);
            }
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            if (!bool_display)
                timer.Enabled = true;
        }

        #region Change Width
        private void pnlExWidth_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;

            if (bClick)
            {
                pDelta.X = e.X - PastPoint.X;
                pDelta.Y = e.Y - PastPoint.Y;

                bool flUpdate = false;
                int temp;

                if ((Panel)sender == pnlExWidth)
                {
                    temp = dto_gramSetting.Ex_Width + pDelta.X;
                    if (temp >= Constants.MIN_WIDTH && temp <= Constants.MAX_WIDTH)
                    {
                        dto_gramSetting.Ex_Width = temp;
                        flUpdate = true;
                    }
                }
                else if ((Panel)sender == pnlSamWidth)
                {
                    temp = dto_gramSetting.Width + pDelta.X;
                    if (temp >= Constants.MIN_WIDTH && temp <= Constants.MAX_WIDTH)
                    {
                        dto_gramSetting.Width = temp;
                        flUpdate = true;
                    }
                }
                else if ((Panel)sender == pnlJPMeanWidth || (Panel)sender == pnlVnMeanWidth)
                {
                    temp = dto_gramSetting.JP_Width + pDelta.X;
                    if (temp >= Constants.MIN_WIDTH && temp <= Constants.MAX_WIDTH)
                    {
                        dto_gramSetting.JP_Width = temp;
                        dto_gramSetting.VN_Width = temp;
                        flUpdate = true;
                    }
                }

                if (flUpdate) SetWidthOfArea();
            }
        }
        #endregion
        #endregion

        // Cho phep display/nondisplay vung hien thi sample, meaning, example
        private bool bool_display = false;
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!bool_display)
            {
                bool_display = true;
                pnlSample.Visible = false;
                pnlSamWidth.Visible = false;
                pnlJPMeaning.Visible = false;
                pnlVNMeaning.Visible = false;
                pnlJPMeanWidth.Visible = false;
                pnlExample.Visible = false;
                pnlExWidth.Visible = false;
                this.Width = pnlTitle.Width + pnlButtons.Width * 2;
                timer.Enabled = false;
                this.Opacity = 1;
            }
            else
            {
                bool_display = false;
                pnlSample.Visible = true;
                pnlSamWidth.Visible = true;
                pnlJPMeaning.Visible = true;
                pnlVNMeaning.Visible = true;
                pnlJPMeanWidth.Visible = true;
                pnlExample.Visible = true;
                pnlExWidth.Visible = true;
                this.Width = pnlTitle.Width + pnlButtons.Width +
                                pnlSample.Width + pnlJPMeaning.Width +
                                pnlExample.Width;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fabout = new About();
            fabout.ShowDialog();
        }

    }
}