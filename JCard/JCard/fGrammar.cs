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

        /* Vi tri example dang duoc hien thi */
        private int count_example;
        /* So example toi da trong 1 mau grammar card */
        private int max_example;
        /* So example toi da duoc phep hien thi voi moi grammar card */
        private int example_ini;
        /* Vi tri Grammar card duoc hien thi */
        private int count_entry;
        /* So grammar card duoc hien thi */
        private int max_entry;
        private ArrayList arr_Entry;
        
        public fGrammar()
        {
            InitializeComponent();
            setFormPosAtBottomRight();

            /* Khoi tao dong ho de do luong thoi gian hien thi grammar card */
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 5000;
            flag = false;

            /* Set gia tri cung */
            DTO_Grammar dto1 = new DTO_Grammar("a + b++++++++++++++++++++++++++++++++", "aaN", "aaV", 
                new ArrayList(new string[6] { "quyen" + "\n" + "quyen", "giang", "san", "toai", "giadinh", "banbe" }));
            DTO_Grammar dto2 = new DTO_Grammar("c + d", "ccN + ddN", "ccV + ddV",
                new ArrayList(new string[6] { "quyen" + "\n" + "quyen", "giang", "san", "toai", "giadinh", "banbe" }));
            DTO_Grammar dto3 = new DTO_Grammar("e + f", "eeN + ffN", "eeV + ffV",
                            new ArrayList(new string[6] { "quyen" + "\n" + "quyen", "giang", "san", "toai", "giadinh", "banbe" }));
            arr_Entry = new ArrayList();
            arr_Entry.Add(dto1);
            arr_Entry.Add(dto2);
            arr_Entry.Add(dto3);

            /* So example duoc phep hien thi trong moi grammar card: Set cung */
            example_ini = 3;

            count_example = 0;
            max_example = ((DTO_Grammar)arr_Entry[0]).ArrExample.Count;
            if (example_ini < max_example)
            {
                max_example = example_ini;
            }
            count_entry = 0;
            max_entry = arr_Entry.Count;

            /* Khoi tao, hien thi grammar card dau tien khi load ung dung len */
            Display(true);
            textBox1.Text = ((DTO_Grammar)arr_Entry[0]).ArrExample[0].ToString();
            toolTip4.SetToolTip(textBox1, textBox1.Text);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void setFormPosAtBottomRight()
        {
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        public void timer_Tick(object o, EventArgs e)
        {
            if (flag)
            {
                
                count_example++;
                if (count_example == max_example || count_entry == max_entry)
                {
                    if (count_example == max_example)
                    {
                        count_entry++;
                    }

                    if (count_entry == max_entry)
                    {
                        count_entry = 0;
                    }
                    count_example = 0;
                    max_example = ((DTO_Grammar)arr_Entry[count_entry]).ArrExample.Count;
                    if (example_ini < max_example)
                    {
                        max_example = example_ini;
                    }

                    Display(flag);
                }

                textBox1.Text = ((DTO_Grammar)arr_Entry[count_entry]).ArrExample[count_example].ToString();
                toolTip4.SetToolTip(textBox1, textBox1.Text);

                timer.Interval = 1000;
                flag = false;
            }
            else
            {
                timer.Interval = 2000;
                if (count_example + 1 == max_example)
                {
                    Display(flag);
                    textBox1.Text = "";
                    toolTip4.SetToolTip(textBox1, textBox1.Text);
                }
                else
                {
                    textBox1.Text = "";
                    toolTip4.SetToolTip(textBox1, textBox1.Text);
                }
                flag = true;
            }
        }

        private void Display(bool flag)
        {
            if (!flag)
            {
                label1.Text = "";
                toolTip1.SetToolTip(panel1, label1.Text);
                toolTip1.SetToolTip(label1, label1.Text);
                label3.Text = "";
                toolTip2.SetToolTip(panel2, label3.Text);
                toolTip2.SetToolTip(label3, label3.Text);
                label4.Text = "";
                toolTip3.SetToolTip(panel4, label4.Text);
                toolTip3.SetToolTip(label4, label4.Text);
            }
            else
            {
                label1.Text = ((DTO_Grammar)arr_Entry[count_entry]).STR_Sample;
                toolTip1.SetToolTip(panel1, label1.Text);
                toolTip1.SetToolTip(label1, label1.Text);
                label3.Text = ((DTO_Grammar)arr_Entry[count_entry]).STR_Meaning_JP;
                toolTip2.SetToolTip(panel2, label3.Text);
                toolTip2.SetToolTip(label3, label3.Text);
                label4.Text = ((DTO_Grammar)arr_Entry[count_entry]).STR_Meaning_VN;
                toolTip3.SetToolTip(panel4, label4.Text);
                toolTip3.SetToolTip(label4, label4.Text);
            }
        }

        private void fGrammar_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
           // setFormPosAtBottomRight();
            txtFocus.Focus();
            this.TopMost = true;
            timer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this program ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }  
        }

        private void fGrammar_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void fGrammar_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}