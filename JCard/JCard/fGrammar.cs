using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fGrammar : Form
    {
        public fGrammar()
        {
            InitializeComponent();
            setFormPosAtBottomRight();
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

        private void fGrammar_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
           // setFormPosAtBottomRight();
            txtFocus.Focus();
            this.TopMost = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}