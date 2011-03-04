using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace JCard
{
    class BUS_Grammar
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        public BUS_Grammar(string str_dts)
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
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            return daoGram.GetGrammarCarByLevel(strLevel);
        }

        /// <summary>
        /// Deletes all the grammar cards in S3GT database with this kyu.
        /// </summary>
        /// <param name="strKyu">The kyu.</param>
        /// <param name="dbFile">The S3GT databse file path.</param>
        /// <returns></returns>
        public Boolean DeleteGrammarCards(int strKyu, string dbFile)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            //Delete all the previous record
            return (daoGram.DeleteGrammarCards(strKyu, dbFile));
        }
        /// <summary>
        /// Inserts the grammar cards.
        /// </summary>
        /// <param name="arrDTOGram">The arr DTO gram.</param>
        /// <param name="strKyu">The String of kyu.</param>
        /// <param name="dbFile">The s3gt database file path.</param>
        /// <returns></returns>
        public Boolean InsertGrammarCards(DTO_Grammar[] arrDTOGram, String strKyu, String dbFile)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            //Continue add new one
            return daoGram.InsertGrammarCards(arrDTOGram, strKyu, dbFile);
        }

        /// <summary>
        /// Reads the excel file.
        /// </summary>
        /// <param name="exFilePath">The ex file path.</param>
        /// <returns></returns>
        public DTO_Grammar[] ReadExcelFile(String exFilePath)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            return daoGram.ReadExcelFile(exFilePath);
        }
        #endregion
    }
}
