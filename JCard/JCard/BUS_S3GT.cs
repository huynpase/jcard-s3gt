using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace JCard
{
    public class BUS_S3GT
    {
        private string str_data; // duong dan toi datasource

        public BUS_S3GT(string sts)
        {
            str_data = sts;
        }
        
        
        public ArrayList GetContentTableKanjiOfS3GT()
        {
            DAO_S3GT dao = new DAO_S3GT(str_data);
            return dao.GetContentTableKanjiOfS3GT();
            //return dao.GetContentTableKanjiOfS3GT();
        }

         public ArrayList GetContentTableVocabularyOfS3GT()
         {
             DAO_S3GT dao = new DAO_S3GT(str_data);
             return dao.GetContentTableVocabularyOfS3GT();
         }

         public ArrayList GetTopic()
         {
             DAO_S3GT dao = new DAO_S3GT(str_data);
             return dao.GetTopic();
         }
          public ArrayList GetContentTableVocByTopicID(ArrayList arrListID)
          {
              DAO_S3GT dao = new DAO_S3GT(str_data);
              return dao.GetContentTableVocByTopicID(arrListID);
          }
          public ArrayList GetTopicGroup()
          {
              DAO_S3GT dao = new DAO_S3GT(str_data);
              return dao.GetTopicGroup();
          }
        
    }
}
