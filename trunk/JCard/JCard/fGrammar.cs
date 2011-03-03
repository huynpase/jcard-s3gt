using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fGrammar : Form
    {
        /* Dong ho do dac thoi gian display va delay */
        private Timer timer;
        /* Bien flag cho biet dang o trang thai delay hay display
         * flag = true  : Delay
         * flag = false : Display
         */
        private bool flag;

        // Grammar setting
        private DTO_GramSetting dto_gramSetting;
                
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

        /* Lay random 1 mau grammar card hoac 1 example bat ky */
        private Random rand;

        /* List luu giu cac grammar card truoc do */
        ArrayList arr_CardForward = new ArrayList();
        /* List luu giu cac example truoc do */
        ArrayList arr_ExampleForward = new ArrayList();
        
        public fGrammar()
        {
            InitializeComponent();
            setFormPosAtBottomRight();

            /* Khoi tao dong ho de do luong thoi gian hien thi grammar card */
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            flag = false;

            /* Set gia tri cung cho gramSetting */
            dto_gramSetting = new DTO_GramSetting();
            dto_gramSetting.Ex_DisplayTime = 5;
            dto_gramSetting.Ex_DelayTime = 6;
            dto_gramSetting.JP_Isdisplayed = true;
            dto_gramSetting.IsDisplayed = true;
            
            ///* Get grammar cards frm database
            BUS_Grammar buGram = new BUS_Grammar(Constants.DATABASE_PATH);
            arr_Entry = buGram.GetGrammarCarByLevel("2");
            //*/

            /* So example duoc phep hien thi trong moi grammar card: Set cung */
            example_ini = 3;

            rand = new Random();
            index_entry = rand.Next(0, arr_Entry.Count - 1);
            arr_CardForward.Add(index_entry);
            max_example = ((DTO_Grammar)arr_Entry[index_entry]).ArrExample.Count;
            count_example = 0;
            index_example = rand.Next(0, max_example - 1);
            arr_ExampleForward.Add(index_example);
            if (example_ini < max_example)
            {
                sum_of_display_example = example_ini;
            }
            else
            {
                sum_of_display_example = max_example;
            }
            max_entry = arr_Entry.Count;

            /* Khoi tao, hien thi grammar card dau tien khi load ung dung len */
            SetControlValues();
            textBox1.Text = ((DTO_Grammar)arr_Entry[index_entry]).ArrExample[index_example].ToString();
            toolTip4.SetToolTip(textBox1, textBox1.Text);
        }

        // Set vi tri ban dau cua form
        private void setFormPosAtBottomRight()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        // Ham xu ly sau moi tick dong ho
        public void timer_Tick(object o, EventArgs e)
        {
            if (flag)
            {// Control sang dan va hien thi cac grammar cards
                if (this.Opacity == 1)
                {
                    flag = false;
                }
                else
                {
                    if (this.Opacity == 0)
                    {
                        Display();
                    }
                    this.Opacity += (double) 1/(dto_gramSetting.Ex_DisplayTime*10);
                }
            }
            else
            {// Control mo dan va o trang thai delay
                if (this.Opacity == 0)
                {
                    flag = true;
                }
                else
                {
                    this.Opacity -= (double) 1/(dto_gramSetting.Ex_DelayTime*10);
                }
            }
        }

        /* Set gia tri Sample, Meaning_JP, Meaning_VN, Examples */
        private void SetControlValues()
        {
            label1.Text = ((DTO_Grammar)arr_Entry[index_entry]).STR_Sample;
            toolTip1.SetToolTip(panel1, label1.Text);
            toolTip1.SetToolTip(label1, label1.Text);
            if (dto_gramSetting.JP_Isdisplayed)
            {
                label3.Text = ((DTO_Grammar)arr_Entry[index_entry]).STR_Meaning_JP;
                toolTip2.SetToolTip(panel2, label3.Text);
                toolTip2.SetToolTip(label3, label3.Text);
                if (!dto_gramSetting.IsDisplayed)
                {
                    label4.Text = label3.Text;
                    toolTip3.SetToolTip(panel4, label4.Text);
                    toolTip3.SetToolTip(label4, label4.Text);
                }
            }
            if(dto_gramSetting.IsDisplayed)
            {
                label4.Text = ((DTO_Grammar)arr_Entry[index_entry]).STR_Meaning_VN;
                toolTip3.SetToolTip(panel4, label4.Text);
                toolTip3.SetToolTip(label4, label4.Text);
                if (!dto_gramSetting.JP_Isdisplayed)
                {
                    label3.Text = label4.Text;
                    toolTip2.SetToolTip(panel2, label3.Text);
                    toolTip2.SetToolTip(label3, label3.Text);
                }
            }
        }
        /* Display */
        private void Display()
        {
            arr_CardForward.Add(index_entry);
            arr_ExampleForward.Add(index_example);

            count_example++;
            if (count_example == sum_of_display_example)
            {
                // Lay random grammar card tiep theo
                index_entry = rand.Next(0, max_entry - 1);

                count_example = 0;
                max_example = ((DTO_Grammar)arr_Entry[index_entry]).ArrExample.Count;
                if (example_ini < max_example)
                {
                    sum_of_display_example = example_ini;
                }
                else
                {
                    sum_of_display_example = max_example;
                }

                SetControlValues();
            }

            // Lay random example tiep theo
            index_example = rand.Next(0, max_example - 1);
            textBox1.Text = ((DTO_Grammar)arr_Entry[index_entry]).ArrExample[index_example].ToString();
            toolTip4.SetToolTip(textBox1, textBox1.Text);
        }

        //Form fGrammar duoc load len
        private void fGrammar_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            txtFocus.Focus();
            this.TopMost = true;
            timer.Start();
        }

        #region  Exit chuong trinh
        // Khi click exit tren contextMenuStrip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this program ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        // Khi tien hanh close chuong trinh bang cach righ-click len icon cua ch/tr tren taskbar va click [x]
        private void fGrammar_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            timer.Enabled = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void btnPrevious_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void btnNext_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
            this.Opacity = 1;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
        #endregion

        #region Next&Forward
        // Hien thi grammar card truoc do
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(arr_ExampleForward.Count > 1)
            {
                index_entry = (int)arr_CardForward[arr_CardForward.Count - 1];
                index_example = (int)arr_ExampleForward[arr_ExampleForward.Count - 1];
                SetControlValues();
                textBox1.Text = ((DTO_Grammar)arr_Entry[index_entry]).ArrExample[index_example].ToString();
                toolTip4.SetToolTip(textBox1, textBox1.Text);

                arr_CardForward.RemoveAt(arr_CardForward.Count - 1);
                arr_ExampleForward.RemoveAt(arr_ExampleForward.Count - 1);

                count_example = 0;
                max_example = ((DTO_Grammar)arr_Entry[index_entry]).ArrExample.Count;
                if (example_ini < max_example)
                {
                    sum_of_display_example = example_ini;
                }
                else
                {
                    sum_of_display_example = max_example;
                }
            }
        }

        // Hien thi grammar card tiep theo
        private void btnNext_Click(object sender, EventArgs e)
        {
            Display();
        }
        #endregion

        // Tro ve man hinh chinh
        private void backToMainScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            timer.Enabled = true;
        }
        #endregion
    }
}