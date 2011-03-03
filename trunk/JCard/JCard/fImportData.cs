using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fImportData : Form
    {
        public fImportData()
        {
            InitializeComponent();
        }

        private void butExcel_Click(object sender, EventArgs e)
        {
            openFileDialog_Excel.Title = "Please choose excel data source file";
            openFileDialog_Excel.FileName = "";
            openFileDialog_Excel.Filter = "*.xls|*.xls";  
            if(openFileDialog_Excel.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void butS3GTDB_Click(object sender, EventArgs e)
        {
            openFileDialog_S3GTDB.Title = "Please choose database of S3GT";
            openFileDialog_S3GTDB.FileName = "";
            openFileDialog_S3GTDB.Filter = "s3gt_db*.mdb|*.mdb";
            openFileDialog_S3GTDB.InitialDirectory = "C:\\Program Files\\S3_JCD\\S3GT\\datasource\\"; // default path
            if(openFileDialog_S3GTDB.ShowDialog()== DialogResult.OK)
            {
                
            }

        }

        private void butConvert_Click(object sender, EventArgs e)
        {

        }
    }
}