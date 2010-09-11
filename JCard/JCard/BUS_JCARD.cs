using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace JCard
{
    public class BUS_JCARD
    {
        private string str_data; // duong dan toi datasource

        public BUS_JCARD(string sts)
        {
            str_data = sts;
        }
        
        
        public ArrayList GetContentTableKanjiOfS3GT()
        {
            DAO_JCARD dao = new DAO_JCARD(str_data);
            return dao.GetContentTableKanjiOfS3GT();
            //return dao.GetContentTableKanjiOfS3GT();
        }

         public ArrayList GetContentTableVocabularyOfS3GT()
         {
             DAO_JCARD dao = new DAO_JCARD(str_data);
             return dao.GetContentTableVocabularyOfS3GT();
         }

         public ArrayList GetTopic()
         {
             DAO_JCARD dao = new DAO_JCARD(str_data);
             return dao.GetTopic();
         }
          public ArrayList GetContentTableVocByTopicID(ArrayList arrListID)
          {
              DAO_JCARD dao = new DAO_JCARD(str_data);
              return dao.GetContentTableVocByTopicID(arrListID);
          }
          public ArrayList GetTopicGroup()
          {
              DAO_JCARD dao = new DAO_JCARD(str_data);
              return dao.GetTopicGroup();
          }
        
    }
}
