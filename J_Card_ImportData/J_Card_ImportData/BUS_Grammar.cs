using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace J_Card_ImportData
{
    class BUS_Grammar
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="BUS_Grammar"/> class.
        /// </summary>
        /// <param name="str_dts">The STR_DTS.</param>
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
        public ArrayList GetGrammarCarByLevel(int catID)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            return daoGram.GetGrammarCarByLevel(catID);
        }


        /// <summary>
        /// Deletes all the grammar cards in S3GT database with this kyu.
        /// </summary>
        /// <param name="strKyu">The kyu.</param>
        /// <param name="dbFile">The S3GT databse file path.</param>
        /// <returns></returns>
        public Boolean DeleteGrammarCards(int strKyu)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            //Delete all the previous record
            return (daoGram.DeleteGrammarCards(strKyu));
        }
        /// <summary>
        /// Inserts the grammar cards.
        /// </summary>
        /// <param name="arrDTOGram">The arr DTO gram.</param>
        /// <param name="strKyu">The String of kyu.</param>
        /// <param name="dbFile">The s3gt database file path.</param>
        /// <returns></returns>
        public Boolean InsertGrammarCards(DTO_Grammar[] arrDTOGram, int catID)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            //Continue add new one
            return daoGram.InsertGrammarCards(arrDTOGram, catID);
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
