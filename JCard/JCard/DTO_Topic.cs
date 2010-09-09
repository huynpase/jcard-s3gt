using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class DTO_Topic
    {
        int iID;
        public int IID
        {
            get { return iID; }
            set { iID = value; }
        }
        int iGroupID;
        public int IGroupID
        {
            get { return iGroupID; }
            set { iGroupID = value; }
        }
        string strName;
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }
        private bool isLastTopic;
        public bool IsLastTopic
        {
            get { return isLastTopic; }
            set { isLastTopic = value; }
        }

       

        
    }
}
