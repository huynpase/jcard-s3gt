using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace JCard
{
    
    public class DAO
    {
        DataProvider dPro  = new DataProvider();
        
        /// <summary>
        ///  GetLessonContentFollowingTopic ID
        /// </summary>
  
        public ArrayList GetLessonContentFollowingTopicID(int TopicID)
        {
            String sql = "Select * from S3GT_VOC where Topic_ID=" + TopicID;
            IDataReader iData = dPro.excuteQuery(sql);
            ArrayList arrLessCont = new ArrayList();
            while(iData.Read())
            {
                DTO dto = new DTO();
                dto.Kanji = iData["Kanji"].ToString();
                dto.HanNom = iData["Hannom"].ToString();
                dto.Yomikata = iData["Hiragana"].ToString();
                dto.Imi = iData["Meaning"].ToString();
                dto.Kunyomi = ""; // Hien tai data base chua co
                dto.Onyomi = ""; // Hien tai database chua co
                dto.Rei = ""; // Hien tai database chua co
                arrLessCont.Add(dto);                
            }
            iData.Close();
            return arrLessCont;
        }
        
    /// <summary>
    ///   FunctionGetTopicID following Lesson Name
    /// </summary>
        public int GetTopicIDFollowingLessonName(String LessonName)  
        {
            String sql = "Select * from S3GT_TPC where Topic_Name='"+LessonName+"'";
            int TopicID = 0;
            IDataReader iData = dPro.excuteQuery(sql);
            while(iData.Read())
            {
                TopicID = (int)iData["Topic_ID"];
            }
            iData.Close();
            return TopicID;

        }
        /// <summary>
        ///   Get topic group ID following Topic group Name
        /// </summary>
     
        public int GetTopicGroupIDFollowingTGN(String TGN)
        {
            return 1; 
        }

        /// <summary>
        ///   GetListTopicFollowingTopicGroupID
        /// </summary>
        public ArrayList GetListTopicFollowingTopicGroupID(int TopicGroupID)
        {
            ArrayList a = new ArrayList();
            return a;
        }
             
    }
}
