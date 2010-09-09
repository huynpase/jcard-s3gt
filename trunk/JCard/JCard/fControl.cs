using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace JCard
{
    public partial class fControl : Form
    {
        public fControl()
        {
        	
            InitializeComponent();
            this.Hide();
            
        }
        
//        private ArrayList ReadXMLSetting()
//        {
//        	ArrayList arrSetting = new ArrayList();
//        	string startupPath = Application.StartupPath;
//        	startupPath += @"\Setting.xml";
//        	
//        	try
//        	{
//	        
//	        	XmlTextReader xmlReader = new XmlTextReader(startupPath);
//	        	while(xmlReader.Read())
//	        	{
//	        		if(xmlReader.NodeType == XmlNodeType.Text)
//	        		{
//	        			arrSetting.Add(xmlReader.Value);	        			
//	        		}		        		
//	        	
//	        	}
//        	}
//        	catch(Exception ex)
//        	{
//        		MessageBox.Show(ex.ToString());
//        	}
//
//            return arrSetting;
    
//        }       
        
        void FControlLoad(object sender, EventArgs e)
        {
        	
        	notifyIcon1.Visible = true;
        }
    }
}