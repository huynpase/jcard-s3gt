using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace J_Card_ImportData
{
    public partial class fImportData : Form
    {
        private Timer proTimer = new Timer();
        /// <summary>
        /// Initializes a new instance of the <see cref="fImportData"/> class.
        /// </summary>
        public fImportData()
        {
            InitializeComponent();
            progBarImport.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the butExcel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void butExcel_Click(object sender, EventArgs e)
        {
            //txtExcel.Clear();
            openFileDialog_Excel.Title = "Please choose excel data source file";
            openFileDialog_Excel.FileName = "";
            openFileDialog_Excel.Filter = "*.xls|*.xls";
            if (openFileDialog_Excel.ShowDialog() == DialogResult.OK)
                txtExcel.Text = openFileDialog_Excel.FileName;
        }

        /// <summary>
        /// Handles the Click event of the butS3GTDB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void butS3GTDB_Click(object sender, EventArgs e)
        {
            //txtS3GTDB.Clear();
            openFileDialog_S3GTDB.Title = "Please choose database of S3GT";
            openFileDialog_S3GTDB.FileName = "";
            openFileDialog_S3GTDB.Filter = "s3gt_db*.mdb|*.mdb";
            //openFileDialog_S3GTDB.InitialDirectory = "C:\\Program Files\\S3_JCD\\S3GT\\datasource\\"; // default path
            openFileDialog_S3GTDB.InitialDirectory = System.IO.Directory.GetCurrentDirectory().ToString() + "\\datasource\\";
            if (openFileDialog_S3GTDB.ShowDialog() == DialogResult.OK)
                txtS3GTDB.Text = openFileDialog_S3GTDB.FileName;
        }

        /// <summary>
        /// Progresses the bar handle.
        /// </summary>
        private void progressBarHandle()
        {
            //start PrgressBar
            progBarImport.Visible = true;
            int i = 0;
            for (; i < progBarImport.Maximum; i++)
                progBarImport.Increment(progBarImport.Step);
        }
        /// <summary>
        /// Handles the Click event of the butConvert control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void butConvert_Click(object sender, EventArgs e)
        {
            if (txtExcel.Text == "")
            {
                MessageBox.Show("Excel file is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtS3GTDB.Text == "")
            {
                MessageBox.Show("S3GT_DB File is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Read data from Excel file
                progressBarHandle();
                BUS_Grammar busGram = new BUS_Grammar(Constants.DATABASE_PATH);
                DTO_Grammar[] gramCards = busGram.ReadExcelFile(txtExcel.Text);
                if (gramCards == null)
                {
                    if (MessageBox.Show("Ivalid Excel data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        progBarImport.Value = 0;
                        progBarImport.Visible = false;
                    }
                }
                else
                {
                    //Import to S3GT_DB    
                    //Get the kyu
                    int iKyu = 0;
                    if (rad1kyu.Checked)
                        iKyu = 1;
                    else if (rad2kyu.Checked)
                        iKyu = 2;
                    else if (rad3kyu.Checked)
                        iKyu = 3;
                    else if (rad4kyu.Checked)
                        iKyu = 4;
                    //Get the methods of add
                    if (radDelete.Checked)
                        busGram.DeleteGrammarCards(iKyu, txtS3GTDB.Text);
                    if (!busGram.InsertGrammarCards(gramCards, iKyu.ToString(), txtS3GTDB.Text))
                    {
                        if (MessageBox.Show("Import data fail!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            progBarImport.Value = 0;
                            progBarImport.Visible = false;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Import data sucessfull!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            progBarImport.Value = 0;
                            progBarImport.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}