using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fAddCategory : Form
    {
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
                    MessageBox.Show("The category's name can not empty!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Add new category
                DTO_Category cat = new DTO_Category(txtCat_Name.Text, txtCat_Desc.Text);
                BUS_Category catBus = new BUS_Category(FImportForm.getS3GTDBFile());
                if (catBus.addNewCategory(cat))
                {
                    MessageBox.Show("Add category sucessfull!!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FImportForm.getCategories(FImportForm.getS3GTDBFile());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add category fail!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
