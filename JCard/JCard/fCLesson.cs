using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace JCard
{
    /// <summary>
    /// 
    /// </summary>
    public partial class fCLesson : Form
    {
        // Define file path of database 
        private String s3gtPath = "datasource\\s3gt_db.mdb";

        public fCLesson()
        {
            InitializeComponent();            
        }
        
       
        // Define a delegate
        public delegate void SendData(int flag, ArrayList arrVoc);

        // Delegate control event form 1
        public SendData sendData;
        private void Form1_Load(object sender, EventArgs e)
        {           
           // notifyIcon1.Visible = false;
            this.tabVocabulary.Select();
            try
            {
                ArrayList arrTopic = new ArrayList();
                ArrayList arrTopicGroup = new ArrayList();
                BUS_JCARD busJcard = new BUS_JCARD(s3gtPath);
                arrTopic = busJcard.GetTopic();
                arrTopicGroup = busJcard.GetTopicGroup();
                AddToTreeView(arrTopicGroup, arrTopic);
                treeView1.ExpandAll();
               
            }
            catch (Exception ex)
            {
                // throw ex;
            }
        }

        private void ButtStartClick(object sender, EventArgs e)
        {
                 cReduceMemory.ReduceMemory();
          
                int iFlag = 1;
                BUS_JCARD oJcard = new BUS_JCARD(s3gtPath);
                
                ArrayList arrVoc = new ArrayList();
                ArrayList arrListTopic = new ArrayList();
                ArrayList arrListLastTopic = new ArrayList();

                // Cho nay se lam them check kiem tra 3 option nguoi dung chon: new topic, last topic, new + last
                if(radNewTopic.Checked) // is new topic
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
                else if(radLastTopic.Checked)
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

        private void CombineArrayList(ref ArrayList arrReturn,ArrayList arrNeedCopy)
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
                foreach (TreeNode tn  in trNR.Nodes)
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
                dtogroup = (DTO_Topic_Group) arrTopicGroup[j];
                noderoot = treeView1.Nodes.Add(dtogroup.StrTPGName);
                noderoot.Name = dtogroup.ITopicGroupID.ToString();

                for (int i = 0; i < arrTopic.Count; i++)
                {
                    DTO_Topic dto = new DTO_Topic();
                    dto = (DTO_Topic) arrTopic[i];
                    if (dtogroup.ITopicGroupID == dto.IGroupID)
                    {
                        TreeNode node = new TreeNode();
                        node = treeView1.Nodes[j].Nodes.Add(dto.StrName);
                        node.Name = dto.IID.ToString();
                    }
                }
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

        private void fCLesson_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Mouse hover");
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit this program ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(dr == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();                
            }          
              
        }

        private void chBoxAll_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chBoxAll.Checked)
            {
                foreach (TreeNode tn in treeView1.Nodes)
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
                foreach (TreeNode tn in treeView1.Nodes)
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
            if (cBoxCollapse.Checked)
            {
                treeView1.CollapseAll();
            }
            else
            {
                treeView1.ExpandAll();
            }
        }

        private void tabGrammar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fGrammar fg = new fGrammar();
            try
            {
                fg.Show();
                this.Hide();
            }
            catch { }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // stop form dang chay
            // hien thi form setting
            this.Show();
            this.tabSetting.Select();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
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
            fSetting.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            fImportData fImport = new fImportData();
            fImport.Show();
        }

       
    }
}