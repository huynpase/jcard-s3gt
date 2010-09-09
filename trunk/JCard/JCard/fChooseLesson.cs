using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCard
{
    public partial class fChooseLesson : Form
    {
        public fChooseLesson()
        {
            InitializeComponent();
        }

        // Declare a delegate
        public delegate void SendData(int flag);  // Delegate control event form 1

        public SendData sendData;

        private void button1_Click(object sender, EventArgs e)
        {
          //  fJCard _fjcard = new fJCard(); // truyen tham so cho form fJcard
           // _fjcard.Show();

            int iFlag = 1;
            if (sendData != null)
            {
                sendData(iFlag);
            }
      

            this.Hide();


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fChooseLesson_Load(object sender, EventArgs e)
        {
            AddValueIntoTreeView();
        }
        private void AddValueIntoTreeView()
        {
            // Dat 2 vong lap Loop Ngay day

            treeView1.Nodes.Add("IDLesson1","Kanji 3kyu");   // add Chu De 1

            TreeNode _TreeNode1 = treeView1.Nodes["IDLesson1"]; // Add node con chua de
            _TreeNode1.Nodes.Add("IDChildNode1", "Lesson 1");
            _TreeNode1.Nodes.Add("IDChildNode2", "Lesson 2");
            _TreeNode1.Nodes.Add("IDChildNode3", "Lesson 3");

            treeView1.Nodes.Add("IDLesson2", "Kanji 2kyu"); // add Chu De 2
            TreeNode _TreeNode2 = treeView1.Nodes["IDLesson2"];
            _TreeNode2.Nodes.Add("IDChildNode1", "Lesson 1");
            _TreeNode2.Nodes.Add("IDChildNode2", "Lesson 2");
            _TreeNode2.Nodes.Add("IDChildNode3", "Lesson 3");

           
        }
        private void AddValueIntoListCheckBox()
        {

        }
    }
}