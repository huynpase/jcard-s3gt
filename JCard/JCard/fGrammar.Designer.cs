namespace JCard
{
    partial class fGrammar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGrammar));
            this.pnlSample = new System.Windows.Forms.Panel();
            this.pnlSamWidth = new System.Windows.Forms.Panel();
            this.lblSample = new System.Windows.Forms.Label();
            this.pnlJPMeaning = new System.Windows.Forms.Panel();
            this.pnlJPMeanWidth = new System.Windows.Forms.Panel();
            this.lblJPMeaning = new System.Windows.Forms.Label();
            this.pnlExample = new System.Windows.Forms.Panel();
            this.pnlExWidth = new System.Windows.Forms.Panel();
            this.lblExample = new System.Windows.Forms.Label();
            this.pnlVNMeaning = new System.Windows.Forms.Panel();
            this.pnlVnMeanWidth = new System.Windows.Forms.Panel();
            this.lblVNMeaning = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToMainScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlSample.SuspendLayout();
            this.pnlJPMeaning.SuspendLayout();
            this.pnlExample.SuspendLayout();
            this.pnlVNMeaning.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSample
            // 
            this.pnlSample.BackColor = System.Drawing.Color.Yellow;
            this.pnlSample.Controls.Add(this.pnlSamWidth);
            this.pnlSample.Controls.Add(this.lblSample);
            this.pnlSample.Location = new System.Drawing.Point(64, 0);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(135, 66);
            this.pnlSample.TabIndex = 2;
            this.toolTip1.SetToolTip(this.pnlSample, "～をめぐって");
            this.pnlSample.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.pnlSample.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pnlSamWidth
            // 
            this.pnlSamWidth.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlSamWidth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSamWidth.Location = new System.Drawing.Point(133, 0);
            this.pnlSamWidth.Name = "pnlSamWidth";
            this.pnlSamWidth.Size = new System.Drawing.Size(2, 66);
            this.pnlSamWidth.TabIndex = 7;
            this.pnlSamWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlSamWidth.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.pnlSamWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlExWidth_MouseMove);
            this.pnlSamWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // lblSample
            // 
            this.lblSample.AutoEllipsis = true;
            this.lblSample.BackColor = System.Drawing.Color.Transparent;
            this.lblSample.Location = new System.Drawing.Point(4, 4);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(126, 13);
            this.lblSample.TabIndex = 0;
            this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblSample, "～をめぐって");
            this.lblSample.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lblSample.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pnlJPMeaning
            // 
            this.pnlJPMeaning.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlJPMeaning.Controls.Add(this.pnlJPMeanWidth);
            this.pnlJPMeaning.Controls.Add(this.lblJPMeaning);
            this.pnlJPMeaning.Location = new System.Drawing.Point(199, 0);
            this.pnlJPMeaning.Name = "pnlJPMeaning";
            this.pnlJPMeaning.Size = new System.Drawing.Size(405, 33);
            this.pnlJPMeaning.TabIndex = 2;
            this.toolTip2.SetToolTip(this.pnlJPMeaning, "「～について（争う）」、「～を争いや議論の対象として」という意味。後ろには「議論する」「More]");
            this.pnlJPMeaning.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.pnlJPMeaning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pnlJPMeanWidth
            // 
            this.pnlJPMeanWidth.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlJPMeanWidth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlJPMeanWidth.Location = new System.Drawing.Point(403, 0);
            this.pnlJPMeanWidth.Name = "pnlJPMeanWidth";
            this.pnlJPMeanWidth.Size = new System.Drawing.Size(2, 33);
            this.pnlJPMeanWidth.TabIndex = 9;
            this.pnlJPMeanWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlJPMeanWidth.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.pnlJPMeanWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlExWidth_MouseMove);
            this.pnlJPMeanWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // lblJPMeaning
            // 
            this.lblJPMeaning.AutoEllipsis = true;
            this.lblJPMeaning.Location = new System.Drawing.Point(8, 9);
            this.lblJPMeaning.Name = "lblJPMeaning";
            this.lblJPMeaning.Size = new System.Drawing.Size(392, 13);
            this.lblJPMeaning.TabIndex = 0;
            this.toolTip2.SetToolTip(this.lblJPMeaning, "「～について（争う）」、「～を争いや議論の対象として」という意味。後ろには「議論する」「More]");
            this.lblJPMeaning.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.lblJPMeaning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // pnlExample
            // 
            this.pnlExample.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlExample.Controls.Add(this.pnlExWidth);
            this.pnlExample.Controls.Add(this.lblExample);
            this.pnlExample.Location = new System.Drawing.Point(604, 0);
            this.pnlExample.Name = "pnlExample";
            this.pnlExample.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.pnlExample.Size = new System.Drawing.Size(251, 66);
            this.pnlExample.TabIndex = 4;
            // 
            // pnlExWidth
            // 
            this.pnlExWidth.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlExWidth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExWidth.Location = new System.Drawing.Point(249, 2);
            this.pnlExWidth.Name = "pnlExWidth";
            this.pnlExWidth.Size = new System.Drawing.Size(2, 62);
            this.pnlExWidth.TabIndex = 6;
            this.pnlExWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlExWidth.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.pnlExWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlExWidth_MouseMove);
            this.pnlExWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // lblExample
            // 
            this.lblExample.AutoEllipsis = true;
            this.lblExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExample.Location = new System.Drawing.Point(3, 2);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(248, 62);
            this.lblExample.TabIndex = 0;
            this.lblExample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExample.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.lblExample.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // pnlVNMeaning
            // 
            this.pnlVNMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlVNMeaning.Controls.Add(this.pnlVnMeanWidth);
            this.pnlVNMeaning.Controls.Add(this.lblVNMeaning);
            this.pnlVNMeaning.Location = new System.Drawing.Point(199, 33);
            this.pnlVNMeaning.Name = "pnlVNMeaning";
            this.pnlVNMeaning.Size = new System.Drawing.Size(405, 33);
            this.pnlVNMeaning.TabIndex = 3;
            this.toolTip3.SetToolTip(this.pnlVNMeaning, "( Tranh giành, tranh cãi ) về cái gì đó” , “ đối tượng tranh luận hay tranh cãi”." +
                    " Phía sau thường là cai gi do con nua ne ....");
            this.pnlVNMeaning.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.pnlVNMeaning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // pnlVnMeanWidth
            // 
            this.pnlVnMeanWidth.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pnlVnMeanWidth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVnMeanWidth.Location = new System.Drawing.Point(403, 0);
            this.pnlVnMeanWidth.Name = "pnlVnMeanWidth";
            this.pnlVnMeanWidth.Size = new System.Drawing.Size(2, 33);
            this.pnlVnMeanWidth.TabIndex = 10;
            this.pnlVnMeanWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlVnMeanWidth.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.pnlVnMeanWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlExWidth_MouseMove);
            this.pnlVnMeanWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // lblVNMeaning
            // 
            this.lblVNMeaning.AutoEllipsis = true;
            this.lblVNMeaning.Location = new System.Drawing.Point(8, 9);
            this.lblVNMeaning.Name = "lblVNMeaning";
            this.lblVNMeaning.Size = new System.Drawing.Size(392, 13);
            this.lblVNMeaning.TabIndex = 0;
            this.toolTip3.SetToolTip(this.lblVNMeaning, "( Tranh giành, tranh cãi ) về cái gì đó” , “ đối tượng tranh luận hay tranh cãi”." +
                    " Phía sau thường là cai gi do con nua ne ....");
            this.lblVNMeaning.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.lblVNMeaning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // toolTip2
            // 
            this.toolTip2.ShowAlways = true;
            // 
            // toolTip3
            // 
            this.toolTip3.ShowAlways = true;
            // 
            // toolTip4
            // 
            this.toolTip4.ShowAlways = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainScreenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 48);
            // 
            // backToMainScreenToolStripMenuItem
            // 
            this.backToMainScreenToolStripMenuItem.Name = "backToMainScreenToolStripMenuItem";
            this.backToMainScreenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.backToMainScreenToolStripMenuItem.Text = "Back to Main Screen";
            this.backToMainScreenToolStripMenuItem.Click += new System.EventHandler(this.backToMainScreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "J-Card (Grammar)";
            this.notifyIcon1.Visible = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnPrevious);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(31, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(33, 66);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(0, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 33);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "˅";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseMove);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(33, 33);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "˄";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPrevious_MouseMove);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::JCard.Properties.Resources.J_Card;
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(31, 66);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.pnlTitle.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // fGrammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 66);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlVNMeaning);
            this.Controls.Add(this.pnlExample);
            this.Controls.Add(this.pnlJPMeaning);
            this.Controls.Add(this.pnlSample);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fGrammar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "JCARD - Grammar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fGrammar_FormClosing);
            this.Load += new System.EventHandler(this.fGrammar_Load);
            this.MouseLeave += new System.EventHandler(this.fGrammar_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fGrammar_MouseMove);
            this.pnlSample.ResumeLayout(false);
            this.pnlJPMeaning.ResumeLayout(false);
            this.pnlExample.ResumeLayout(false);
            this.pnlVNMeaning.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Panel pnlJPMeaning;
        private System.Windows.Forms.Panel pnlExample;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Panel pnlVNMeaning;
        private System.Windows.Forms.Label lblJPMeaning;
        private System.Windows.Forms.Label lblVNMeaning;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ToolStripMenuItem backToMainScreenToolStripMenuItem;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Panel pnlExWidth;
        private System.Windows.Forms.Panel pnlSamWidth;
        private System.Windows.Forms.Panel pnlJPMeanWidth;
        private System.Windows.Forms.Panel pnlVnMeanWidth;
    }
}