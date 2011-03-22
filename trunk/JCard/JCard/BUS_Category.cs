using System;
using System.Collections;

namespace JCard
{
    class BUS_Category
    {
        #region members
        string str_datasource;
        #endregion

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BUS_Category"/> class.
        /// </summary>
        /// <param name="str_dts">The STR_DTS.</param>
        public BUS_Category(string str_dts)
        {
            str_datasource = str_dts;
        }
        #endregion

        #region methods
        /// <summary>
        /// Adds the new category.
        /// </summary>
        /// <param name="dtoCat">The DTO_Category.</param>
        /// <param name="dbFile">The S3GT database file.</param>
        /// <returns></returns>
        public Boolean addNewCategory(DTO_Category dtoCat)
        {
            DAO_Category daoCat = new DAO_Category(str_datasource);
            //Continue add new one
            return daoCat.addNewCategory(dtoCat);
        }

        /// <summary>
        /// Reads all categories.
        /// </summary>
        /// <param name="dbFile">The S3GT database file.</param>
        /// <returns></returns>
        public ArrayList readAllCategories()
        {
            DAO_Category daoCat = new DAO_Category(str_datasource);
            //Continue add new one
            return daoCat.readAllCategories();
        }

        #endregion

    }
}
