namespace JCard
{
    partial class fImportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportData));
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS3GTDB = new System.Windows.Forms.TextBox();
            this.butExcel = new System.Windows.Forms.Button();
            this.butS3GTDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radKeep = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butConvert = new System.Windows.Forms.Button();
            this.openFileDialog_Excel = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_S3GTDB = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source:";
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(129, 26);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.ReadOnly = true;
            this.txtExcel.Size = new System.Drawing.Size(357, 20);
            this.txtExcel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "S3GT Database:";
            // 
            // txtS3GTDB
            // 
            this.txtS3GTDB.Location = new System.Drawing.Point(129, 67);
            this.txtS3GTDB.Name = "txtS3GTDB";
            this.txtS3GTDB.ReadOnly = true;
            this.txtS3GTDB.Size = new System.Drawing.Size(357, 20);
            this.txtS3GTDB.TabIndex = 1;
            // 
            // butExcel
            // 
            this.butExcel.Location = new System.Drawing.Point(492, 27);
            this.butExcel.Name = "butExcel";
            this.butExcel.Size = new System.Drawing.Size(75, 23);
            this.butExcel.TabIndex = 3;
            this.butExcel.Text = "Browse...";
            this.butExcel.UseVisualStyleBackColor = true;
            this.butExcel.Click += new System.EventHandler(this.butExcel_Click);
            // 
            // butS3GTDB
            // 
            this.butS3GTDB.Location = new System.Drawing.Point(492, 64);
            this.butS3GTDB.Name = "butS3GTDB";
            this.butS3GTDB.Size = new System.Drawing.Size(75, 23);
            this.butS3GTDB.TabIndex = 3;
            this.butS3GTDB.Text = "Browse...";
            this.butS3GTDB.UseVisualStyleBackColor = true;
            this.butS3GTDB.Click += new System.EventHandler(this.butS3GTDB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose Category:";
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Checked = true;
            this.radDelete.Location = new System.Drawing.Point(15, 15);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(316, 17);
            this.radDelete.TabIndex = 4;
            this.radDelete.TabStop = true;
            this.radDelete.Text = "Delete existing grammars of this category and insert new data.";
            this.radDelete.UseVisualStyleBackColor = true;
            // 
            // radKeep
            // 
            this.radKeep.AutoSize = true;
            this.radKeep.Location = new System.Drawing.Point(15, 47);
            this.radKeep.Name = "radKeep";
            this.radKeep.Size = new System.Drawing.Size(310, 17);
            this.radKeep.TabIndex = 4;
            this.radKeep.Text = "Keep existing grammars of this category and insert new data.";
            this.radKeep.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radDelete);
            this.panel1.Controls.Add(this.radKeep);
            this.panel1.Location = new System.Drawing.Point(129, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 84);
            this.panel1.TabIndex = 6;
            // 
            // butConvert
            // 
            this.butConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConvert.ForeColor = System.Drawing.Color.Black;
            this.butConvert.Location = new System.Drawing.Point(190, 234);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(95, 31);
            this.butConvert.TabIndex = 7;
            this.butConvert.Text = "&Import";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click);
            // 
            // openFileDialog_Excel
            // 
            this.openFileDialog_Excel.FileName = "openFileDialog_Excel";
            // 
            // openFileDialog_S3GTDB
            // 
            this.openFileDialog_S3GTDB.FileName = "openFileDialog_S3GTDB";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(308, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(129, 107);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(181, 21);
            this.cbCategory.TabIndex = 10;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(316, 107);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.Text = "Add New";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // fImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.ClientSize = new System.Drawing.Size(594, 278);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.butConvert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butS3GTDB);
            this.Controls.Add(this.butExcel);
            this.Controls.Add(this.txtS3GTDB);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fImportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Data From Excel";
            this.Load += new System.EventHandler(this.fImportData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS3GTDB;
        private System.Windows.Forms.Button butExcel;
        private System.Windows.Forms.Button butS3GTDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radKeep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Excel;
        private System.Windows.Forms.OpenFileDialog openFileDialog_S3GTDB;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAddCategory;
    }
}