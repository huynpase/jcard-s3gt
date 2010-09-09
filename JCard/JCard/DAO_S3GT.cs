using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace JCard
{
    
    public class DAO_S3GT
    {        
         string str_datasource;

        public DAO_S3GT(string str_dts)
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



        




        
        
    }
}
