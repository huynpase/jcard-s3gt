using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace JCard
{
    public class BUS
    {
        DAO dao = new DAO();
        
         public ArrayList GetLessonContent(int TopicID)
         {
             
             return dao.GetLessonContentFollowingTopicID(TopicID);
         }
        public int GetTopicID(String LessonName)
        {
            return dao.GetTopicIDFollowingLessonName(LessonName);
        }
    }
}
