using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Data.OleDb;
using JCard;

namespace JCard
{
    class DAO_GramSetting
    {
        public DTO_GramSetting ReadGramSetting(string iniPath)
        {
            DTO_GramSetting gramSettDTO = new DTO_GramSetting();
            IniFile ini = new IniFile(iniPath);
            ini.ReadValue("[Position]", "Top", Constants.Top);
            ini.ReadValue("[Position]", "Left",Constants.Left);
            ini.ReadValue("[Sample]","BackColor",Constants.BackColor);
            ini.ReadValue("[Sample]", "ForeColor", Constants.ForeColor);
            ini.ReadValue("[Sample]", "Width", Constants.Width);
            ini.ReadValue("[JPMeaning]", "JP_BackColor", Constants.JP_BackColor);
            ini.ReadValue("[JPMeaning]", "JP_ForeColor", Constants.JP_ForeColor);
            ini.ReadValue("[JPMeaning]", "JP_Width", Constants.JP_Width);
            ini.ReadValue("[JPMeaning]", "JP_IsDisplayed", Constants.JP_IsDisplayed);
            ini.ReadValue("[VNMeaning]", "VN_BackColor", Constants.VN_BackColor);
            ini.ReadValue("[VNMeaning]", "VN_ForeColor", Constants.VN_ForeColor);
            ini.ReadValue("[VNMeaning]", "VN_Width", Constants.VN_Width);
            ini.ReadValue("[VNMeaning]", "VN_IsDisplayed", Constants.VN_IsDisplayed);
            ini.ReadValue("[Example]", "Ex_BackColor", Constants.Ex_BackColor);
            ini.ReadValue("[Example]", "Ex_ForeColor", Constants.Ex_ForeColor);
            ini.ReadValue("[Example]", "Ex_NoOfDisplay", Constants.Ex_NoOfDisplay);
            ini.ReadValue("[Example]", "Ex_DisplayTime", Constants.Ex_DisplayTime);
            ini.ReadValue("[Example]", "Ex_DelayTime", Constants.Ex_DelayTime);

            return gramSettDTO;
        }

        public void WriteGramSettings(DTO_GramSetting gramSettDTO, string iniPath)
        {
            IniFile ini = new IniFile(iniPath);
            ini.WriteValue("[Position]","Top",gramSettDTO.Top.ToString());
            ini.WriteValue("[Position]", "Left", gramSettDTO.Left.ToString());
            ini.WriteValue("[Sample]", "BackColor", gramSettDTO.BackColor.ToString());
            ini.WriteValue("[Sample]", "ForeColor", gramSettDTO.ForeColor.ToString());
            ini.WriteValue("[Sample]", "Width", gramSettDTO.Width.ToString());
            ini.WriteValue("[JPMeaning]", "JP_BackColor", gramSettDTO.JP_BackColor.ToString());
            ini.WriteValue("[JPMeaning]", "JP_ForeColor", gramSettDTO.JP_ForeColor.ToString());
            ini.WriteValue("[JPMeaning]", "JP_Width", gramSettDTO.JP_Width.ToString());
            ini.WriteValue("[JPMeaning]", "JP_IsDisplayed", gramSettDTO.JP_Isdisplayed.ToString());
            ini.WriteValue("[VNMeaning]", "VN_BackColor", gramSettDTO.VN_BackColor.ToString());
            ini.WriteValue("[VNMeaning]", "VN_ForeColor", gramSettDTO.VN_ForeColor.ToString());
            ini.WriteValue("[VNMeaning]", "VN_Width", gramSettDTO.VN_Width.ToString());
            ini.WriteValue("[VNMeaning]", "VN_IsDisplayed", gramSettDTO.VN_IsDisplayed.ToString());
            ini.WriteValue("[Example]", "Ex_BackColor", gramSettDTO.Ex_BackColor.ToString());
            ini.WriteValue("[Example]", "Ex_ForeColor", gramSettDTO.Ex_ForeColor.ToString());
            ini.WriteValue("[Example]", "Ex_NoOfDisplay", gramSettDTO.Ex_NoOfDisplay.ToString());
            ini.WriteValue("[Example]", "Ex_DisplayTime", gramSettDTO.Ex_DisplayTime.ToString());
            ini.WriteValue("[Example]", "Ex_DelayTime", gramSettDTO.Ex_DelayTime.ToString());
        }
    }
}
