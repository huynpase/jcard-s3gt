////Nguyen
using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class BUS_Setting
    {
        
        public DTO_Setting ReadSetting(string fPath)
        {
            DTO_Setting settingDTO;
            DAO_Setting settingDAO = new DAO_Setting();
            settingDTO = settingDAO.ReadSetting(fPath);
            return settingDTO;
        }
        public void SaveSetting(DTO_Setting settingDTO, string fPath)
        {
            DAO_Setting settingDAO = new DAO_Setting();
            settingDAO.SaveSetting(settingDTO, fPath);
        }
    }
}
