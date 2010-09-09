using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class DTO_Topic_Group
    {
        int iTopicGroupID;
        public int ITopicGroupID
        {
            get { return iTopicGroupID; }
            set { iTopicGroupID = value; }
        }
        string strTPGName;
        public string StrTPGName
        {
            get { return strTPGName; }
            set { strTPGName = value; }
        }
    }
}
