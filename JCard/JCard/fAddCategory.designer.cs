namespace JCard
{
    partial class fAddCategory
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCat_Name = new System.Windows.Forms.TextBox();
            this.txtCat_Desc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // txtCat_Name
            // 
            this.txtCat_Name.Location = new System.Drawing.Point(97, 23);
            this.txtCat_Name.Name = "txtCat_Name";
            this.txtCat_Name.Size = new System.Drawing.Size(163, 20);
            this.txtCat_Name.TabIndex = 4;
            // 
            // txtCat_Desc
            // 
            this.txtCat_Desc.Location = new System.Drawing.Point(97, 65);
            this.txtCat_Desc.Multiline = true;
            this.txtCat_Desc.Name = "txtCat_Desc";
            this.txtCat_Desc.Size = new System.Drawing.Size(182, 89);
            this.txtCat_Desc.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.ClientSize = new System.Drawing.Size(411, 166);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCat_Desc);
            this.Controls.Add(this.txtCat_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fAddCategory";
            this.Text = "Add New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCat_Name;
        private System.Windows.Forms.TextBox txtCat_Desc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}