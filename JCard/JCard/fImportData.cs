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
    public partial class fImportData : Form
    {
        #region Variables for resource
        ResourceManager objResourceManager;
        CultureInfo objCulInfo;
        #endregion

        private string strParentDB;
        private bool isUpdatedDB = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="fImportData"/> class.
        /// </summary>
        public fImportData()
        {
            InitializeComponent();
        }

        public fImportData(string strCurDatabase)
        {
            InitializeComponent();

            strParentDB = strCurDatabase;
            txtS3GTDB.Text = strCurDatabase;
        }
        
        /// <summary>
        /// Handles the Click event of the butExcel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void butExcel_Click(object sender, EventArgs e)
        {
            openFileDialog_Excel.Title = Common.GetResourceValue(Constants.RES_EXCEL_OPEN_TITLE_NAME, objCulInfo,
                objResourceManager, Constants.RES_EXCEL_OPEN_TITLE_VALUE);
            openFileDialog_Excel.FileName = "";
            openFileDialog_Excel.Filter = "Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
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
            openFileDialog_S3GTDB.Title = Common.GetResourceValue(Constants.RES_S3GT_OPEN_TITLE_NAME, objCulInfo,
                objResourceManager, Constants.RES_S3GT_OPEN_TITLE_VALUE);
            openFileDialog_S3GTDB.FileName = "";
            openFileDialog_S3GTDB.Filter = "S3GT DB (*.mdb)|*.mdb";
            openFileDialog_S3GTDB.InitialDirectory = System.IO.Directory.GetCurrentDirectory().ToString() + "\\datasource\\";
            if (openFileDialog_S3GTDB.ShowDialog() == DialogResult.OK)
            {
                txtS3GTDB.Text = openFileDialog_S3GTDB.FileName;
                getCategories(txtS3GTDB.Text);
            }
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
                Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_SELECT_EXCEL_FILE_NAME,
                        Constants.RES_SELECT_EXCEL_FILE_VALUE);
                return;
            }
            if (txtS3GTDB.Text == "")
            {
                Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_SELECT_S3GT_FILE_NAME,
                        Constants.RES_SELECT_S3GT_FILE_VALUE);
                return;
            }
                        
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                //Read data from Excel file                
                BUS_Grammar busGram = new BUS_Grammar(txtS3GTDB.Text);
                DTO_Grammar[] gramCards = busGram.ReadExcelFile(txtExcel.Text);
                if (gramCards.Length == 0)
                {
                    Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_EMPTY_EXCEL_FILE_NAME, 
                        Constants.RES_EMPTY_EXCEL_FILE_VALUE);
                }
                else
                {
                    //Import to S3GT_DB    
                    //Get the category
                    DTO_Category selectedCat = (DTO_Category)cbCategory.SelectedValue;
                    int catID = (int)selectedCat.LCAT_ID;
                    ////Get the methods of add
                    if (radDelete.Checked)
                        busGram.DeleteGrammarCards(catID);
                    if (!busGram.InsertGrammarCards(gramCards, catID))
                    {
                        Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_IMPORT_FAIL_NAME, 
                            Constants.RES_IMPORT_FAIL_VALUE);
                    }
                    else
                    {                        
                        Common.ShowInfoMsg(objCulInfo, objResourceManager, Constants.RES_IMPORT_SUCESSFULL_NAME,
                            Constants.RES_IMPORT_SUCESSFULL_VALUE);
                        if (strParentDB.CompareTo(txtS3GTDB.Text) == 0)
                        {
                            isUpdatedDB = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.Enabled = true;
            }
        }

        /// <summary>
        /// Gets the s3 GTDB file.
        /// </summary>
        /// <returns></returns>
        public String getS3GTDBFile()
        {
            return txtS3GTDB.Text;
        }

        /// <summary>
        /// Gets the categories in the specific database file
        /// </summary>
        public void getCategories(String dbFile)
        {
            try
            {
                BUS_Category busCat = new BUS_Category(dbFile);
                ArrayList catList = busCat.GetAllCats();

                //Insert to combo-box                
                cbCategory.DataSource = catList;
                cbCategory.DisplayMember = "strName";
            }
            catch (Exception ex)
            {
                Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAddCategory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtS3GTDB.Text, "") == 0)
            {
                Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_SELECT_S3GT_FILE_NAME,
                    Constants.RES_SELECT_S3GT_FILE_VALUE);
                return;
            }
            fAddCategory addCatForm = new fAddCategory(this);
            addCatForm.Location = this.Location;
            addCatForm.ShowDialog(this);
        }

        private void fImportData_Load(object sender, EventArgs e)
        {
            // Default file path.
            //string dbFilePath = Application.StartupPath;
            //txtS3GTDB.Text = dbFilePath + "\\" + Constants.DATABASE_PATH;
            getCategories(txtS3GTDB.Text);

            SetDisplayLabel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetDisplayLabel()
        {
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fCLesson).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
            this.Text = Common.GetResourceValue(Constants.RES_IMPORTDATA_NAME, objCulInfo, objResourceManager, Constants.RES_IMPORTDATA_VALUE);
            label1.Text = Common.GetResourceValue(Constants.RES_LBLDATASOURCE_NAME, objCulInfo, objResourceManager, Constants.RES_LBLDATASOURCE_VALUE);
            label2.Text = Common.GetResourceValue(Constants.RES_S3GTLABEL_NAME, objCulInfo, objResourceManager, Constants.RES_S3GTLABEL_VALUE);
            label3.Text = Common.GetResourceValue(Constants.RES_LBLCHOOSECAT_NAME, objCulInfo, objResourceManager, Constants.RES_LBLCHOOSECAT_VALUE);
            butExcel.Text = Common.GetResourceValue(Constants.RES_BTNBROWSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNBROWSE_VALUE);
            butS3GTDB.Text = Common.GetResourceValue(Constants.RES_BTNBROWSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNBROWSE_VALUE);
            btnAddCategory.Text = Common.GetResourceValue(Constants.RES_BTNADDCAT_NAME, objCulInfo, objResourceManager, Constants.RES_BTNADDCAT_VALUE);
            radDelete.Text = Common.GetResourceValue(Constants.RES_RADDEL_NAME, objCulInfo, objResourceManager, Constants.RES_RADDEL_VALUE);
            radKeep.Text = Common.GetResourceValue(Constants.RES_RADKEEP_NAME,objCulInfo,objResourceManager,Constants.RES_RADKEEP_VALUE);
            butConvert.Text = Common.GetResourceValue(Constants.RES_BTNIMPORT_NAME, objCulInfo, objResourceManager, Constants.RES_BTNIMPORT_VALUE);
            btnCancel.Text = Common.GetResourceValue(Constants.RES_BTNCLOSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCLOSE_VALUE);
        }

        private void fImportData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isUpdatedDB)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}