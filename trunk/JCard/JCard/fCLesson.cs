using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Resources;
using System.Globalization;

namespace JCard
{
    /// <summary>
    /// 
    /// </summary>
    public partial class fCLesson : Form
    {
        #region Variables for resource
        ResourceManager objResourceManager;
        CultureInfo objCulInfo;
        #endregion

        private double opacityInc = .05;

        public fCLesson()
        {
            InitializeComponent();
            string s3gtPath = Application.StartupPath + "\\" + Common.GetConfigValue(Constants.CONFIG_DATABASE_PATH_KEY, Constants.DATABASE_PATH);
            txtS3GTDB.Text = s3gtPath;
            txtDatabaseGram.Text = s3gtPath;

            SetDisplayLabel();
        }

        // Define a delegate
        public delegate void SendData(int flag, ArrayList arrVoc);

        // Delegate control event form 1
        public SendData sendData;

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            fSplash.ShowSplashScreen();
            timer2.Interval = Constants.Timer_Interval;
            timer2.Start();
            this.Opacity = 0;
            // notifyIcon1.Visible = false;
            this.tabVocabulary.Select();

            InitTreeView(txtS3GTDB.Text);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            fSplash.CloseForm();
            this.TopMost = true;
            this.Activate();
            timer3.Interval = 50;
            timer3.Start();
            Thread.Sleep(1000);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += opacityInc;
            else if (this.Opacity == 1)
            {
                this.TopMost = false;                
                timer3.Stop();
            }
        }

        public void SetDisplayLabel()
        {
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fCLesson).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));
            this.Text = Common.GetResourceValue(Constants.RES_PROGRAM_NAME, objCulInfo, objResourceManager, Constants.RES_PROGRAM_VALUE);
            tabVocabulary.Text = Common.GetResourceValue(Constants.RES_TABVOCAB_NAME, objCulInfo, objResourceManager, Constants.RES_TABVOCAB_VALUE);
            tabGrammar.Text = Common.GetResourceValue(Constants.RES_TABGRAM_NAME, objCulInfo, objResourceManager, Constants.RES_TABGRAM_VALUE);
            lblGramS3GT.Text = Common.GetResourceValue(Constants.RES_S3GTLABEL_NAME, objCulInfo, objResourceManager, Constants.RES_S3GTLABEL_VALUE);
            lblVocabS3GT.Text = Common.GetResourceValue(Constants.RES_S3GTLABEL_NAME, objCulInfo, objResourceManager, Constants.RES_S3GTLABEL_VALUE);
            groupBox1.Text = Common.GetResourceValue(Constants.RES_GROUPBOXVOCAB_NAME, objCulInfo, objResourceManager, Constants.RES_GROUPBOXVOCAB_VALUE);
            chBoxAll.Text = Common.GetResourceValue(Constants.RES_CHKBOXALL_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXALL_VALUE);
            cBoxCollapse.Text = Common.GetResourceValue(Constants.RES_CHKBOXCOLLAPSE_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXCOLLAPSE_VALUE);
            groupBox3.Text = Common.GetResourceValue(Constants.RES_GROUPBOXVOCABLEARN_NAME, objCulInfo, objResourceManager, Constants.RES_GROUPBOXVOCABLEARN_VALUE);
            radNewTopic.Text = Common.GetResourceValue(Constants.RES_RADIOVOCABNEW_NAME, objCulInfo, objResourceManager, Constants.RES_RADIOVOCABNEW_VALUE);
            radLastTopic.Text = Common.GetResourceValue(Constants.RES_RADIOVOCABLAST_NAME, objCulInfo, objResourceManager, Constants.RES_RADIOVOCABLAST_VALUE);
            radCombine.Text = Common.GetResourceValue(Constants.RES_RADIOVOCABALL_NAME, objCulInfo, objResourceManager, Constants.RES_RADIOVOCABALL_VALUE);
            button4.Text = Common.GetResourceValue(Constants.RES_BTNSETTING_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSETTING_VALUE);
            ButtCopy.Text = Common.GetResourceValue(Constants.RES_BTNSTART_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSTART_VALUE);
            button1.Text = Common.GetResourceValue(Constants.RES_BTNCLOSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCLOSE_VALUE);
            groupBox2.Text = Common.GetResourceValue(Constants.RES_GROUPBOXGRAMMAR_NAME, objCulInfo, objResourceManager, Constants.RES_GROUPBOXGRAMMAR_VALUE);
            chbGramAll.Text = Common.GetResourceValue(Constants.RES_CHKBOXALL_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXALL_VALUE);
            chbGramColAll.Text = Common.GetResourceValue(Constants.RES_CHKBOXCOLLAPSE_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXCOLLAPSE_VALUE);
            btnImport.Text = Common.GetResourceValue(Constants.RES_BTNIMPORT_NAME, objCulInfo, objResourceManager, Constants.RES_BTNIMPORT_VALUE);
            btnSetting.Text = Common.GetResourceValue(Constants.RES_BTNSETTING_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSETTING_VALUE);
            button2.Text = Common.GetResourceValue(Constants.RES_BTNCLOSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCLOSE_VALUE);
            button3.Text = Common.GetResourceValue(Constants.RES_BTNSTART_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSTART_VALUE);
            btnBrowseGram.Text = Common.GetResourceValue(Constants.RES_BTNBROWSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNBROWSE_VALUE);
            btnBrowseVoc.Text = Common.GetResourceValue(Constants.RES_BTNBROWSE_NAME, objCulInfo, objResourceManager, Constants.RES_BTNBROWSE_VALUE);
            linkLabel1.Text = Common.GetResourceValue(Constants.RES_ABOUT_NAME, objCulInfo, objResourceManager, Constants.RES_ABOUT_VALUE);
        }
        #endregion

        #region Thao Tác trên TabControl
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            trvGrammars.Nodes.Clear();

            if (tabControl1.SelectedIndex == 1)
            {
                InitGramTreeView(txtDatabaseGram.Text);
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                InitTreeView(txtS3GTDB.Text);
            }
        }
        #endregion

        #region Thao Tác trên TreeView
        private void InitTreeView(string filepath)
        {
            try
            {
                // fpath = filepath;
                ArrayList arrTopic = new ArrayList();
                ArrayList arrTopicGroup = new ArrayList();
                BUS_JCARD busJcard = new BUS_JCARD(filepath);
                arrTopic = busJcard.GetTopic();
                arrTopicGroup = busJcard.GetTopicGroup();
                AddToTreeView(arrTopicGroup, arrTopic);
                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
            }
        }        

        private bool CheckChosedDataOfTreeView()
        {
            int flag = 0;
            foreach (TreeNode tnroot in treeView1.Nodes)
            {
                foreach (TreeNode tn in tnroot.Nodes)
                {
                    if (tn.Checked == true)
                        flag = 1;
                }
            }

            if (flag == 0)
            {
                return false;
            }
            return true;
        }

        private ArrayList GetListTopicChosen()
        {
            ArrayList arr = new ArrayList();
            foreach (TreeNode trNR in treeView1.Nodes)
            {
                foreach (TreeNode tn in trNR.Nodes)
                {
                    if (tn.Checked == true)
                    {
                        int id = int.Parse(tn.Name.ToString());
                        arr.Add(id);
                    }
                }
            }
            return arr;
        }

        private void AddToTreeView(ArrayList arrTopicGroup, ArrayList arrTopic)
        {
            treeView1.Nodes.Clear();
            for (int j = 0; j < arrTopicGroup.Count; j++)
            {
                TreeNode noderoot = new TreeNode();
                DTO_Topic_Group dtogroup = new DTO_Topic_Group();
                dtogroup = (DTO_Topic_Group)arrTopicGroup[j];
                noderoot = treeView1.Nodes.Add(dtogroup.StrTPGName);
                noderoot.Name = dtogroup.ITopicGroupID.ToString();

                for (int i = 0; i < arrTopic.Count; i++)
                {
                    DTO_Topic dto = new DTO_Topic();
                    dto = (DTO_Topic)arrTopic[i];
                    if (dtogroup.ITopicGroupID == dto.IGroupID)
                    {
                        TreeNode node = new TreeNode();
                        node = treeView1.Nodes[j].Nodes.Add(dto.StrName);
                        node.Name = dto.IID.ToString();
                    }
                }
            }
        }

        private void InitGramTreeView(string strFilePath)
        {
            try
            {
                // Get Grammars
                BUS_Grammar buGram = new BUS_Grammar(strFilePath);
                List<TreeNode> lstNodes = buGram.GetGrammarCardTree();

                trvGrammars.Nodes.AddRange(lstNodes.ToArray());

                trvGrammars.ExpandAll();
            }
            catch (Exception ex)
            {
                Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // TreeNode node;
            // bool blnAll;
            if (e.Node.Level == 0)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = e.Node.Checked;
                }
            }
            else
            {
                bool blnAll = false;
                foreach (TreeNode node in e.Node.Parent.Nodes)
                {
                    blnAll |= node.Checked;
                }
                e.Node.Parent.Checked = blnAll;
            }
        }

        private void chBoxAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender == chBoxAll)
            {
                CheckAll(treeView1, chBoxAll.Checked);
            }
            else if (sender == chbGramAll)
            {
                CheckAll(trvGrammars, chbGramAll.Checked);
            }
        }

        /// <summary>
        /// Check ON/OFF for all TreeNode
        /// </summary>
        /// <param name="tv">Tree View</param>
        /// <param name="flag">ON/OFF</param>
        private void CheckAll(TreeView tv, bool flag)
        {
            if (flag)
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    tn.Checked = true;
                    foreach (TreeNode n in tn.Nodes)
                    {
                        n.Checked = true;
                    }
                }
            }
            else
            {
                foreach (TreeNode tn in tv.Nodes)
                {
                    tn.Checked = false;
                    foreach (TreeNode n in tn.Nodes)
                    {
                        n.Checked = false;
                    }
                }
            }
        }

        private void cBoxCollapse_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender == cBoxCollapse)
            {
                ExpandAll(treeView1, cBoxCollapse.Checked);
            }
            else if (sender == chbGramColAll)
            {
                ExpandAll(trvGrammars, chbGramColAll.Checked);
            }
        }

        /// <summary>
        /// Expand or Collapse for all TreeNode
        /// </summary>
        /// <param name="tv">Tree View</param>
        /// <param name="flag">TRUE/FALSE</param>
        private void ExpandAll(TreeView tv, bool flag)
        {
            if (flag)
            {
                tv.CollapseAll();
            }
            else
            {
                tv.ExpandAll();
            }
        }

        /// <summary>
        /// Check whether existing one node is selected.
        /// </summary>
        /// <param name="tv">Tree View</param>
        /// <returns>TRUE/FALSE</returns>
        private bool IsNodeSelected(TreeView tv)
        {
            for (int i = 0; i < tv.Nodes.Count; i++)
            {
                if (tv.Nodes[i].Checked)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Get selected grammar cards from Tree View
        /// </summary>
        /// <param name="lstNodes">List of Tree Node</param>
        /// <returns>Selected Grammar Cards</returns>
        public ArrayList GetSelectedGrammarCards(TreeNodeCollection lstNodes)
        {
            ArrayList result = new ArrayList();

            for (int i = 0; i < lstNodes.Count; i++)
            {
                TreeNode rootNode = lstNodes[i];
                if (rootNode.Checked)
                {
                    for (int j = 0; j < rootNode.Nodes.Count; j++)
                    {
                        if (rootNode.Nodes[j].Checked)
                        {
                            DTO_Grammar dtoGram = (DTO_Grammar)rootNode.Nodes[j].Tag;
                            result.Add(dtoGram);
                        }
                    }
                }
            }

            return result;
        }
        #endregion

        #region Thao Tác trên Grammar Tab
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsNodeSelected(trvGrammars))
            {
                ///* Get grammar cards frm database
                ArrayList arr_Entry = GetSelectedGrammarCards(trvGrammars.Nodes);
                //*/

                fGrammar fg = new fGrammar(arr_Entry);
                fg.Show();

                trvGrammars.Nodes.Clear();
                this.Hide();
            }
            else
            {
                Common.ShowInfoMsg(objCulInfo, objResourceManager, Constants.RES_SELECT_GRAM_INFO_NAME, Constants.RES_SELECT_GRAM_INFO_VALUE);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            fGramSetts fSetting = new fGramSetts();
            fSetting.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //fImportData fImport = new fImportData();
            fImportData fImport = new fImportData(txtDatabaseGram.Text);
            if (fImport.ShowDialog() == DialogResult.OK)
            {
                //Update tree view
                trvGrammars.Nodes.Clear();
                InitGramTreeView(txtDatabaseGram.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
        #endregion       

        #region Thao Tác trên Vocabulary Tab
        private void ButtCopy_Click(object sender, EventArgs e)
        {
            cReduceMemory.ReduceMemory();

            int iFlag = 1;
            //BUS_JCARD oJcard = new BUS_JCARD(s3gtPath);
            BUS_JCARD oJcard = new BUS_JCARD(txtS3GTDB.Text);

            ArrayList arrVoc = new ArrayList();
            ArrayList arrListTopic = new ArrayList();
            ArrayList arrListLastTopic = new ArrayList();

            // Cho nay se lam them check kiem tra 3 option nguoi dung chon: new topic, last topic, new + last
            if (radNewTopic.Checked) // is new topic
            {
                if (CheckChosedDataOfTreeView() != false)
                {
                    try
                    {
                        oJcard.ResetIsLastTopic();
                        arrListTopic = GetListTopicChosen();
                        arrVoc = oJcard.GetContentTableVocByTopicID(arrListTopic);
                        oJcard.UpdateIsLastTopic(arrListTopic, true);
                        fJCard fjcard = new fJCard(iFlag, arrVoc);
                        fjcard.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
                    }
                }
                else
                {
                    Common.ShowInfoMsg(objCulInfo, objResourceManager, Constants.RES_SELECT_TOPIC_INFO_NAME, Constants.RES_SELECT_TOPIC_INFO_VALUE);
                }
            }
            else if (radLastTopic.Checked)
            {
                try
                {
                    arrListTopic = oJcard.GetTopicIsLastTopic();
                    arrVoc = oJcard.GetContentTableVocByTopicID(arrListTopic);
                    fJCard fjcard = new fJCard(iFlag, arrVoc);
                    fjcard.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
                }
            }
            else
            {
                if (CheckChosedDataOfTreeView() != false)
                {
                    try
                    {
                        arrListLastTopic = oJcard.GetTopicIsLastTopic();
                        arrListTopic = GetListTopicChosen();
                        CombineArrayList(ref arrListTopic, arrListLastTopic);
                        arrVoc = oJcard.GetContentTableVocByTopicID(arrListTopic);
                        oJcard.UpdateIsLastTopic(arrListTopic, true);
                        fJCard fjcard = new fJCard(iFlag, arrVoc);
                        fjcard.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Common.ShowErrorMsg(objCulInfo, objResourceManager, ex.Message);
                    }
                }
                else
                {
                    Common.ShowInfoMsg(objCulInfo, objResourceManager, Constants.RES_SELECT_TOPIC_INFO_NAME, Constants.RES_SELECT_TOPIC_INFO_VALUE);
                }
            }

        }

        private void CombineArrayList(ref ArrayList arrReturn, ArrayList arrNeedCopy)
        {
            foreach (int value in arrNeedCopy)
            {
                arrReturn.Add(value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            fSetting fset = new fSetting();
            fset.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Title = Common.GetResourceValue(Constants.RES_S3GT_OPEN_TITLE_NAME, objCulInfo,
                objResourceManager, Constants.RES_S3GT_OPEN_TITLE_VALUE);
            opf.DefaultExt = "*.mdb";
            opf.RestoreDirectory = true;
            opf.Filter = "S3GT DB (*.mdb)|*.mdb";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sender == btnBrowseVoc)
                {
                    txtS3GTDB.Text = opf.FileName;
                    treeView1.Nodes.Clear();
                    InitTreeView(txtS3GTDB.Text);
                }
                else if (sender == btnBrowseGram)
                {
                    txtDatabaseGram.Text = opf.FileName;
                    trvGrammars.Nodes.Clear();
                    InitGramTreeView(txtDatabaseGram.Text);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void radLastTopic_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.Enabled = false;
        }

        private void radCombine_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.Enabled = true;
        }

        private void radNewTopic_CheckedChanged(object sender, EventArgs e)
        {
            treeView1.Enabled = true;
        }
        #endregion     
    }
}