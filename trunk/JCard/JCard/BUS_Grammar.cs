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
        #endregion
    }
}
