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
    public partial class fAddCategory : Form
    {
        #region Variables for resource
        ResourceManager objResourceManager;
        CultureInfo objCulInfo;
        #endregion

        private fImportData fImportForm;
        public fImportData FImportForm
        {
            get { return fImportForm; }
            set { fImportForm = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="fAddCategory"/> class.
        /// </summary>
        public fAddCategory(fImportData fIForm)
        {
            InitializeComponent();
            fImportForm = fIForm;
        }

        /// <summary>
        /// Handles the Click event of the Exit button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the OK button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.Compare(txtCat_Name.Text, "") == 0)
                {
                    Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_CAT_NAME_EMPTY_NAME,
                                            Constants.RES_CAT_NAME_EMPTY_VALUE);
                    return;
                }
                //Add new category
                DTO_Category cat = new DTO_Category(txtCat_Name.Text, txtCat_Desc.Text);
                BUS_Category catBus = new BUS_Category(FImportForm.getS3GTDBFile());
                if (catBus.AddNewCategory(cat))
                {
                    Common.ShowInfoMsg(objCulInfo, objResourceManager, Constants.RES_ADD_CAT_SUCESSFULL_NAME,
                            Constants.RES_ADD_CAT_SUCESSFULL_VALUE);
                    FImportForm.getCategories(FImportForm.getS3GTDBFile());
                    this.Close();
                }
                else
                {
                    Common.ShowWarningMsg(objCulInfo, objResourceManager, Constants.RES_ADD_CAT_FAIL_NAME,
                                            Constants.RES_ADD_CAT_FAIL_VALUE);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
            }
        }

        public void SetDisplayLabel()
        {
            // Create a resource manager to retrieve resources.
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fCLesson).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
        }
    }
}
