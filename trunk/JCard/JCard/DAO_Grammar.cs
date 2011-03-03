using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace JCard
{
    class DAO_Grammar
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        public DAO_Grammar(string str_dts)
        {
            str_datasource = str_dts;
        }
        #endregion

        #region methods
        /// <summary>
        /// Get all grammar cards by input Level
        /// </summary>
        /// <param name="strLevel">Input Level</param>
        /// <returns>List of grammar cards</returns>
        public ArrayList GetGrammarCarByLevel(string strLevel)
        {
            ArrayList result = new ArrayList();
            
            DataProvider provider = new DataProvider(str_datasource);            

            String sql = "Select * from S3GT_GRAM where Level='" + strLevel + "'";
            IDataReader reader = provider.excuteQuery(sql);

            string tempEx = "";

            while (reader.Read())
            {
                DTO_Grammar gramCard = new DTO_Grammar();
                gramCard.LGR_ID = long.Parse(reader["GR_ID"].ToString());
                gramCard.STR_Level = strLevel;
                gramCard.STR_Sample = reader["Sample"].ToString();
                gramCard.STR_Syntax = reader["Syntax"].ToString();
                gramCard.STR_Meaning_JP = reader["Meaning_JP"].ToString();
                gramCard.STR_Meaning_VN = reader["Meaning_VN"].ToString();

                for (int i = 0; i < Constants.MAX_GRAMMAR_EXAMPLE; i++)
                {
                    tempEx = reader["Example" + (i+1).ToString()].ToString();
                    gramCard.ArrExample[i] = tempEx;
                }

                result.Add(gramCard);
            }
            reader.Close();

            return result;
        }
        #endregion
    }
}
