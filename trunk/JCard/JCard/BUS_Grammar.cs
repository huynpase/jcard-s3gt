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
        public ArrayList GetGrammarCardByLevel(int catID)
        {
            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            return daoGram.GetGrammarCardByLevel(catID);
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

        /// <summary>
        /// Get a tree of grammar card
        /// </summary>
        /// <returns>A List of TreeNode</returns>
        public List<TreeNode> GetGrammarCardTree()
        {
            List<TreeNode> lstCards = new List<TreeNode>();

            DAO_Category daoCat = new DAO_Category(str_datasource);
            ArrayList arrCats = daoCat.GetAllCats();

            DAO_Grammar daoGram = new DAO_Grammar(str_datasource);
            ArrayList arrCards = daoGram.GetAllGrammarCard();

            for (int i = 0; i < arrCards.Count; i++)
            {
                DTO_Grammar dtoGram = (DTO_Grammar)arrCards[i];
                int rootIndex = GetRootNode(arrCats, ref lstCards, dtoGram.LCAT_ID);

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
        private int GetRootNode(ArrayList arrCats, ref List<TreeNode> lstCards, long catID)
        {
            for (int i = lstCards.Count - 1; i >= 0; i--)
            {
                TreeNode node = lstCards[i];
                if (node.Name == catID.ToString())
                {
                    return i;
                }
            }

            for (int i = 0; i < arrCats.Count; i++)
            {
                DTO_Category cat = (DTO_Category)arrCats[i];
                if (cat.LCAT_ID == catID)
                {
                    TreeNode node = new TreeNode();
                    node.Name = cat.LCAT_ID.ToString();
                    node.Text = cat.StrName;

                    lstCards.Add(node);

                    return lstCards.Count - 1;
                }
            }

            return -1;
        }
        #endregion

    }
}
