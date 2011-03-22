using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;

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
        public ArrayList GetGrammarCardByLevel(int intKyu)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            return daoGram.GetGrammarCardByLevel(intKyu);
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

        /// <summary>
        /// Get a tree of grammar card
        /// </summary>
        /// <returns>A List of TreeNode</returns>
        public List<TreeNode> GetGrammarCardTree()
        {
            List<TreeNode> lstCards = new List<TreeNode>();

            DAO_CAT daoCat = new DAO_CAT(str_datasource);
            ArrayList arrCats = daoCat.GetAllCats();
            
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            ArrayList arrCards = daoGram.GetAllGrammarCard();

            for (int i = 0; i < arrCards.Count; i++)
            {
                DTO_Grammar dtoGram = (DTO_Grammar)arrCards[i];
                int rootIndex = GetRootNode(arrCats, ref lstCards, dtoGram.INT_Kyu);

                TreeNode node = new TreeNode();
                node.Name = dtoGram.LGR_ID.ToString();
                node.Text = dtoGram.STR_Sample;
                node.Tag = dtoGram;

                lstCards[rootIndex].Nodes.Add(node);
            }

            return lstCards;
        }

        /// <summary>
        /// Get index of Root Node by catID
        /// </summary>
        /// <param name="arrCats">Array of Category</param>
        /// <param name="lstCards">A List of TreeNode</param>
        /// <param name="catID">Category ID</param>
        /// <returns>Index of Root Node</returns>
        private int GetRootNode(ArrayList arrCats, ref List<TreeNode> lstCards, int catID)
        {
            for (int i = lstCards.Count - 1; i >= 0 ; i--)
            {
                TreeNode node = lstCards[i];
                if (node.Name == catID.ToString())
                {
                    return i;
                }
            }

            for (int i = 0; i < arrCats.Count; i++)
            {
                DTO_CAT cat = (DTO_CAT)arrCats[i];
                if (cat.IntID == catID)
                {
                    TreeNode node = new TreeNode();
                    node.Name = cat.IntID.ToString();
                    node.Text = cat.StrName;

                    lstCards.Add(node);

                    return lstCards.Count-1;
                }
            }

            return -1;
        }
        #endregion
    }
}
