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

        // Define file path of database 
        private String s3gtPath = "datasource\\s3gt_db.mdb";

        // private  String fpath = "";// bien duong dan toan cuc

        private double opacityInc = .05;


        public fCLesson()
        {
            InitializeComponent();

            s3gtPath = Common.GetConfigValue(Constants.CONFIG_DATABASE_PATH_KEY, Constants.DATABASE_PATH);

            SetDisplayLabel();
        }


        // Define a delegate
        public delegate void SendData(int flag, ArrayList arrVoc);

        // Delegate control event form 1
        public SendData sendData;
        private void Form1_Load(object sender, EventArgs e)
        {
            fSplash.ShowSplashScreen();
            timer2.Interval = Constants.Timer_Interval;
            timer2.Start();
            this.Opacity = 0;
            // notifyIcon1.Visible = false;
            this.tabVocabulary.Select();
            try
            {
                InitTreeView(s3gtPath);

            }
            catch (Exception ex)
            {
                // throw ex;
            }
        }
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
                MessageBox.Show("Error when load DB");
                MessageBox.Show("Please send to author contents of error below: \n" + ex);
            }
        }


        private void ButtCopy_Click(object sender, EventArgs e)
        {
            cReduceMemory.ReduceMemory();

            int iFlag = 1;
            BUS_JCARD oJcard = new BUS_JCARD(s3gtPath);

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
                        MessageBox.Show("Error when connect to DB");
                        MessageBox.Show("Please send to author contents of error below: \n" + ex);

                    }
                }
                else
                {
                    MessageBox.Show("Please select at least one glossary ", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
                    MessageBox.Show("Error when connect to DB");
                    MessageBox.Show("Please send to author contents of error below: \n" + ex);

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
                        MessageBox.Show("Error when connect to DB");
                        MessageBox.Show("Please send to author contents of error below: \n" + ex);

                    }

                }
                else
                {
                    MessageBox.Show("Please select at least one glossary ", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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

        private void fCLesson_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Mouse hover");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this program ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }

        }

        #region Thao Tác trên TreeView
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

        private void tabGrammar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNodeSelected(trvGrammars))
                {
                    ///* Get grammar cards frm database
                    ArrayList arr_Entry = GetSelectedGrammarCards(trvGrammars.Nodes);
                    //*/

                    if (arr_Entry != null && arr_Entry.Count > 0)
                    {
                        fGrammar fg = new fGrammar(arr_Entry);
                        fg.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The grammar of selected level is empty.\n Please select another level and restart displaying grammar cards.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Dispose();
                    Application.Exit();
                    return;
                }
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        public static void showTabSetting()
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            fGramSetts fSetting = new fGramSetts();
            fSetting.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            fImportData fImport = new fImportData();
            fImport.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog opf = new OpenFileDialog();

            opf.Title = "Please choose file S3GT DB want to load.";
            opf.DefaultExt = "*.mdb";
            opf.RestoreDirectory = true;
            opf.Filter = "S3GT DB (*.mdb)|*.mdb";
            if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    filepath = opf.FileName;
                    InitTreeView(filepath);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error when load DB file");
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            fSplash.CloseForm();
            timer3.Interval = 50;
            timer3.Start();
            Thread.Sleep(1000);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (opacityInc > 0)
            {
                if (this.Opacity < 1)
                    this.Opacity += opacityInc;
            }
            else
            {
                if (this.Opacity > 0)
                    this.Opacity += opacityInc;
                else
                    this.Close();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            fSetting fset = new fSetting();
            fset.ShowDialog();
        }

        public void SetDisplayLabel()
        {
            // Create a resource manager to retrieve resources.
            objResourceManager = new ResourceManager("JCard.Resources", typeof(fCLesson).Assembly);
            objCulInfo = new CultureInfo(Common.GetConfigValue(Constants.CONFIG_LANGUAGE_KEY, Constants.CONFIG_LANGUAGE_VALUE));

            if (objResourceManager != null)
            {
                //Main screen
                this.Text = Common.GetResourceValue(Constants.RES_PROGRAM_NAME, objCulInfo, objResourceManager, Constants.RES_PROGRAM_VALUE);
                tabVocabulary.Text = Common.GetResourceValue(Constants.RES_TABVOCAB_NAME,objCulInfo,objResourceManager,Constants.RES_TABVOCAB_VALUE);
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
                button1.Text = Common.GetResourceValue(Constants.RES_BTNCANCEL_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCANCEL_VALUE);
                groupBox2.Text = Common.GetResourceValue(Constants.RES_GROUPBOXVOCAB_NAME, objCulInfo, objResourceManager, Constants.RES_GROUPBOXVOCAB_VALUE);
                chbGramAll.Text = Common.GetResourceValue(Constants.RES_CHKBOXALL_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXALL_VALUE);
                chbGramColAll.Text = Common.GetResourceValue(Constants.RES_CHKBOXCOLLAPSE_NAME, objCulInfo, objResourceManager, Constants.RES_CHKBOXCOLLAPSE_VALUE);
                btnImport.Text = Common.GetResourceValue(Constants.RES_BTNIMPORT_NAME, objCulInfo, objResourceManager, Constants.RES_BTNIMPORT_VALUE);
                btnSetting.Text = Common.GetResourceValue(Constants.RES_BTNSETTING_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSETTING_VALUE);
                button2.Text = Common.GetResourceValue(Constants.RES_BTNCANCEL_NAME, objCulInfo, objResourceManager, Constants.RES_BTNCANCEL_VALUE);
                button3.Text = Common.GetResourceValue(Constants.RES_BTNSTART_NAME, objCulInfo, objResourceManager, Constants.RES_BTNSTART_VALUE);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                try
                {
                    trvGrammars.Nodes.Clear();

                    // Get Grammars
                    BUS_Grammar buGram = new BUS_Grammar(s3gtPath);
                    List<TreeNode> lstNodes = buGram.GetGrammarCardTree();

                    trvGrammars.Nodes.AddRange(lstNodes.ToArray());

                    trvGrammars.ExpandAll();
                    trvGrammars.SelectedNode = trvGrammars.TopNode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                    this.Enabled = true;
                }
            }
        }
    }
}