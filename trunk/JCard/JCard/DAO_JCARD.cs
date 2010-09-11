using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace JCard
{
    
    public class DAO_JCARD
    {        
         string str_datasource;

        public DAO_JCARD(string str_dts)
        {
            str_datasource = str_dts;
        }
        /*
        public void SetDataSource(string str_dts)
        {
            str_datasource = str_dts;
        }      
      */
        public ArrayList GetContentTableKanjiOfS3GT()
        {
            DataProvider dPro = new DataProvider(str_datasource);            

            String sql = "Select * from S3GT_KAN " ;
            IDataReader iData = dPro.excuteQuery(sql);
            
            ArrayList arrLessCont = new ArrayList();
            while(iData.Read())
            {
                DTO_KANJI dto = new DTO_KANJI();
                dto.Kanji = iData["Kanji"].ToString();
                dto.Hannom = iData["HanNom"].ToString();
                dto.Kunyomi = iData["Kunyomi"].ToString();
                dto.Onyomin = iData["Onyomi"].ToString();             
                
                arrLessCont.Add(dto);                
            }
            iData.Close();
            return arrLessCont;
        }

       

        public ArrayList GetContentTableVocabularyOfS3GT()
        {
            DataProvider dPro = new DataProvider(str_datasource);  
           
            String sql = "Select * from S3GT_VOC ";
            IDataReader iData = dPro.excuteQuery(sql);
            ArrayList arrLessCont = new ArrayList();
            while (iData.Read())
            {
                DTO_VOC dto = new DTO_VOC();
                dto.Hiragana = iData["Hiragana"].ToString();
                dto.Kanji = iData["Kanji"].ToString();
                dto.Hannom = iData["Hannom"].ToString();
                dto.Meaning = iData["Meaning"].ToString();                
                arrLessCont.Add(dto);
            }
            iData.Close();
            return arrLessCont;
        }

        public ArrayList GetTopic()
        {
            DataProvider dPro = new DataProvider(str_datasource);  
             String sql = "Select * from S3GT_TPC ";
            IDataReader iData = dPro.excuteQuery(sql);
            ArrayList arrLessCont = new ArrayList();
            while (iData.Read())
            {
                DTO_Topic dto = new DTO_Topic();
                dto.IID = int.Parse(iData["Topic_ID"].ToString());
                dto.StrName = iData["Topic_Name"].ToString();
                dto.IGroupID = int.Parse(iData["Topic_Group_ID"].ToString());
                dto.IsLastTopic = (bool) iData["IsLastTopic"];
                arrLessCont.Add(dto);
            }
            iData.Close();
            return arrLessCont;
        }

        public ArrayList GetTopicGroup()
        {
            DataProvider dPro = new DataProvider(str_datasource);
            String sql = "Select * from S3GT_TPG ";
            IDataReader iData = dPro.excuteQuery(sql);
            ArrayList arrLessCont = new ArrayList();
            while (iData.Read())
            {
                DTO_Topic_Group dtog = new  DTO_Topic_Group();
                //dto.IID = int.Parse(iData["Topic_ID"].ToString());
                dtog.ITopicGroupID = int.Parse(iData["Topic_Group_ID"].ToString());
                dtog.StrTPGName = iData["Topic_Group_Name"].ToString();

                arrLessCont.Add(dtog);
            }
            iData.Close();
            return arrLessCont;
        }

        public ArrayList GetContentTableVocByTopicID(ArrayList arrListID)
        {
            DataProvider dPro = new DataProvider(str_datasource);
            ArrayList arrLessCont = new ArrayList();
            string sql = "";
            foreach (int ID in arrListID)
            {
                sql = "Select * From S3GT_VOC Where Topic_ID=" + ID;
                IDataReader iData = dPro.excuteQuery(sql);
                while (iData.Read())
                {
                    DTO_VOC dto = new DTO_VOC();

                    dto.Hiragana = iData["Hiragana"].ToString();
                    dto.Kanji = iData["Kanji"].ToString();
                    dto.Hannom = iData["Hannom"].ToString();
                    dto.Meaning = iData["Meaning"].ToString();

                    arrLessCont.Add(dto);
                }
                iData.Close();
            }
            return arrLessCont;
            
        }
        //++ 20100911 : PhuongHD  add function
        /// <summary>
        /// This function will be used for update value of column IsLastTopic
        /// </summary>
        /// <param name="topicID"></param>
        /// <param name="isLastTopic"></param>
        public void UpdateIsLastTopic(ArrayList arrTopic,bool isLastTopic)
        {
            DataProvider dPro = new DataProvider(str_datasource);
            foreach (int topicID in arrTopic)
            {
                String sql = "UPDATE S3GT_TPC SET IsLastTopic=";
                sql += isLastTopic;
                sql += " WHERE Topic_ID=";
                sql += topicID;
                try
                {
                    dPro.excuteNonQuery(sql);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
         
        }
        /// <summary>
        /// Reset all values of field IsLastTopic become to false
        /// </summary>
        public void ResetIsLastTopic()
        {
            DataProvider dPro = new DataProvider(str_datasource);
            String sql = "UPDATE S3GT_TPC SET IsLastTopic=false";
            try
            {
                dPro.excuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

     /// <summary>
     /// This function will get all topics have  value of field  IsLastTopic is true
     /// </summary>
     /// <returns></returns>
        public ArrayList GetTopicIDIsLastTopic()
        {
            DataProvider dPro = new DataProvider(str_datasource);
            String sql = "SELECT * from S3GT_TPC WHERE IsLastTopic=true";
            IDataReader iData = dPro.excuteQuery(sql);
            ArrayList arrLessCont = new ArrayList();
        
            while (iData.Read())
            {
                //dto.IID = int.Parse(iData["Topic_ID"].ToString());
                arrLessCont.Add(int.Parse(iData["Topic_ID"].ToString()));
            }
            iData.Close();
            return arrLessCont;
        }

        
        
    }
}
