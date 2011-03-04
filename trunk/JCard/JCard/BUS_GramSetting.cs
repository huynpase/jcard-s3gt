using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class BUS_GramSetting
    {
        public DTO_GramSetting ReadGramSetting(string filePath)
        {
            DTO_GramSetting dtoGramSett;
            DAO_GramSetting daoGramSett = new DAO_GramSetting();
            dtoGramSett = daoGramSett.ReadGramSetting(filePath);
            return dtoGramSett;
        }

        public void SaveGramSetting(DTO_GramSetting dtoGramSett, string filePath)
        {
            DAO_GramSetting daoGramSett = new DAO_GramSetting();
            daoGramSett.WriteGramSettings(dtoGramSett, filePath);
        }
    }
}
