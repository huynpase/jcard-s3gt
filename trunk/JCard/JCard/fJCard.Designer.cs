namespace JCard
{
    partial class fJCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fJCard));
            this.tempTextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer_Flag = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlMeaning = new System.Windows.Forms.Panel();
            this.pnlImi_Left = new System.Windows.Forms.Panel();
            this.pnlImi_Right = new System.Windows.Forms.Panel();
            this.txtMeaning = new System.Windows.Forms.Label();
            this.pnlHiragana = new System.Windows.Forms.Panel();
            this.pnlHiragana_Left = new System.Windows.Forms.Panel();
            this.pnlHiragana_Right = new System.Windows.Forms.Panel();
            this.txtHiragana = new System.Windows.Forms.Label();
            this.pnlKanji = new System.Windows.Forms.Panel();
            this.pnlKanji_Left = new System.Windows.Forms.Panel();
            this.pnlKanji_Right = new System.Windows.Forms.Panel();
            this.txtKanji = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMeaning.SuspendLayout();
            this.pnlHiragana.SuspendLayout();
            this.pnlKanji.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempTextbox
            // 
            this.tempTextbox.Location = new System.Drawing.Point(3, 266);
            this.tempTextbox.Name = "tempTextbox";
            this.tempTextbox.Size = new System.Drawing.Size(10, 20);
            this.tempTextbox.TabIndex = 1;
            this.tempTextbox.Text = "set focus here";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // timer_Flag
            // 
            this.timer_Flag.Enabled = true;
            this.timer_Flag.Interval = 1000;
            this.timer_Flag.Tick += new System.EventHandler(this.timer_Flag_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Jcard";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vocabularyToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.vocabularyToolStripMenuItem.Text = "Back to Main screen";
            this.vocabularyToolStripMenuItem.Click += new System.EventHandler(this.vocabularyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_2);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlMeaning);
            this.panel4.Controls.Add(this.pnlHiragana);
            this.panel4.Controls.Add(this.pnlKanji);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 3;
            // 
            // pnlMeaning
            // 
            this.pnlMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlMeaning.Controls.Add(this.pnlImi_Left);
            this.pnlMeaning.Controls.Add(this.pnlImi_Right);
            this.pnlMeaning.Controls.Add(this.txtMeaning);
            this.pnlMeaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMeaning.Location = new System.Drawing.Point(0, 50);
            this.pnlMeaning.Name = "pnlMeaning";
            this.pnlMeaning.Size = new System.Drawing.Size(100, 50);
            this.pnlMeaning.TabIndex = 107;
            // 
            // pnlImi_Left
            // 
            this.pnlImi_Left.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlImi_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImi_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlImi_Left.Name = "pnlImi_Left";
            this.pnlImi_Left.Size = new System.Drawing.Size(2, 50);
            this.pnlImi_Left.TabIndex = 2;
            this.pnlImi_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlImi_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.pnlImi_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // pnlImi_Right
            // 
            this.pnlImi_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlImi_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlImi_Right.Location = new System.Drawing.Point(98, 0);
            this.pnlImi_Right.Name = "pnlImi_Right";
            this.pnlImi_Right.Size = new System.Drawing.Size(2, 50);
            this.pnlImi_Right.TabIndex = 10008;
            this.pnlImi_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlImi_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.pnlImi_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMeaning.Location = new System.Drawing.Point(7, 10);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(180, 30);
            this.txtMeaning.TabIndex = 1;
            this.txtMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMeaning.Paint += new System.Windows.Forms.PaintEventHandler(this.Ellipsis_Label_Paint);
            this.txtMeaning.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.txtMeaning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // pnlHiragana
            // 
            this.pnlHiragana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlHiragana.Controls.Add(this.pnlHiragana_Left);
            this.pnlHiragana.Controls.Add(this.pnlHiragana_Right);
            this.pnlHiragana.Controls.Add(this.txtHiragana);
            this.pnlHiragana.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHiragana.Location = new System.Drawing.Point(0, 50);
            this.pnlHiragana.Name = "pnlHiragana";
            this.pnlHiragana.Size = new System.Drawing.Size(100, 100);
            this.pnlHiragana.TabIndex = 104;
            // 
            // pnlHiragana_Left
            // 
            this.pnlHiragana_Left.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlHiragana_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHiragana_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlHiragana_Left.Name = "pnlHiragana_Left";
            this.pnlHiragana_Left.Size = new System.Drawing.Size(2, 100);
            this.pnlHiragana_Left.TabIndex = 2;
            this.pnlHiragana_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlHiragana_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.pnlHiragana_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // pnlHiragana_Right
            // 
            this.pnlHiragana_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlHiragana_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHiragana_Right.Location = new System.Drawing.Point(98, 0);
            this.pnlHiragana_Right.Name = "pnlHiragana_Right";
            this.pnlHiragana_Right.Size = new System.Drawing.Size(2, 100);
            this.pnlHiragana_Right.TabIndex = 10006;
            this.pnlHiragana_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlHiragana_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.pnlHiragana_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtHiragana
            // 
            this.txtHiragana.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHiragana.Location = new System.Drawing.Point(7, 10);
            this.txtHiragana.Name = "txtHiragana";
            this.txtHiragana.Size = new System.Drawing.Size(180, 30);
            this.txtHiragana.TabIndex = 0;
            this.txtHiragana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHiragana.Paint += new System.Windows.Forms.PaintEventHandler(this.Ellipsis_Label_Paint);
            this.txtHiragana.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.txtHiragana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // pnlKanji
            // 
            this.pnlKanji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlKanji.Controls.Add(this.pnlKanji_Left);
            this.pnlKanji.Controls.Add(this.pnlKanji_Right);
            this.pnlKanji.Controls.Add(this.txtKanji);
            this.pnlKanji.Controls.Add(this.label1);
            this.pnlKanji.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKanji.Location = new System.Drawing.Point(0, 0);
            this.pnlKanji.Name = "pnlKanji";
            this.pnlKanji.Size = new System.Drawing.Size(100, 50);
            this.pnlKanji.TabIndex = 1;
            // 
            // pnlKanji_Left
            // 
            this.pnlKanji_Left.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlKanji_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKanji_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlKanji_Left.Name = "pnlKanji_Left";
            this.pnlKanji_Left.Size = new System.Drawing.Size(2, 50);
            this.pnlKanji_Left.TabIndex = 0;
            this.pnlKanji_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlKanji_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.pnlKanji_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // pnlKanji_Right
            // 
            this.pnlKanji_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlKanji_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlKanji_Right.Location = new System.Drawing.Point(98, 0);
            this.pnlKanji_Right.Name = "pnlKanji_Right";
            this.pnlKanji_Right.Size = new System.Drawing.Size(2, 50);
            this.pnlKanji_Right.TabIndex = 10005;
            this.pnlKanji_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlKanji_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.pnlKanji_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtKanji
            // 
            this.txtKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKanji.Location = new System.Drawing.Point(7, 10);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.Size = new System.Drawing.Size(180, 30);
            this.txtKanji.TabIndex = 1;
            this.txtKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtKanji.Paint += new System.Windows.Forms.PaintEventHandler(this.Ellipsis_Label_Paint);
            this.txtKanji.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.txtKanji.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10003;
            // 
            // fJCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tempTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fJCard";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCard- Vocabulary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fJCard_FormClosing);
            this.Load += new System.EventHandler(this.FJCardLoad);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlMeaning.ResumeLayout(false);
            this.pnlHiragana.ResumeLayout(false);
            this.pnlKanji.ResumeLayout(false);
            this.pnlKanji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //   private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox tempTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer_Flag;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlMeaning;
        private System.Windows.Forms.Panel pnlImi_Left;
        private System.Windows.Forms.Panel pnlImi_Right;
        private System.Windows.Forms.Label txtMeaning;
        private System.Windows.Forms.Panel pnlHiragana;
        private System.Windows.Forms.Panel pnlHiragana_Left;
        private System.Windows.Forms.Panel pnlHiragana_Right;
        private System.Windows.Forms.Label txtHiragana;
        private System.Windows.Forms.Panel pnlKanji;
        private System.Windows.Forms.Panel pnlKanji_Left;
        private System.Windows.Forms.Panel pnlKanji_Right;
        private System.Windows.Forms.Label txtKanji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

