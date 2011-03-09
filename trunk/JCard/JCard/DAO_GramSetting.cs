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
            try
            {
                gramSettDTO.Top = int.Parse(ini.ReadValue("Position", "Top", Constants.Top));
                gramSettDTO.Left = int.Parse(ini.ReadValue("Position", "Left", Constants.Left));
                gramSettDTO.BackColor = int.Parse(ini.ReadValue("Sample", "BackColor", Constants.BackColor));
                gramSettDTO.ForeColor = int.Parse(ini.ReadValue("Sample", "ForeColor", Constants.ForeColor));
                gramSettDTO.Width = int.Parse(ini.ReadValue("Sample", "Width", Constants.Width));
                gramSettDTO.JP_BackColor = int.Parse(ini.ReadValue("JPMeaning", "JP_BackColor", Constants.JP_BackColor));
                gramSettDTO.JP_ForeColor = int.Parse(ini.ReadValue("JPMeaning", "JP_ForeColor", Constants.JP_ForeColor));
                gramSettDTO.JP_Width = int.Parse(ini.ReadValue("JPMeaning", "JP_Width", Constants.JP_Width));
                gramSettDTO.JP_Isdisplayed = bool.Parse(ini.ReadValue("JPMeaning", "JP_IsDisplayed", Constants.JP_IsDisplayed));
                gramSettDTO.VN_BackColor = int.Parse(ini.ReadValue("VNMeaning", "VN_BackColor", Constants.VN_BackColor));
                gramSettDTO.VN_ForeColor = int.Parse(ini.ReadValue("VNMeaning", "VN_ForeColor", Constants.VN_ForeColor));
                gramSettDTO.VN_Width = int.Parse(ini.ReadValue("VNMeaning", "VN_Width", Constants.VN_Width));
                gramSettDTO.VN_IsDisplayed = bool.Parse(ini.ReadValue("VNMeaning", "VN_IsDisplayed", Constants.VN_IsDisplayed));
                gramSettDTO.Ex_BackColor = int.Parse(ini.ReadValue("Example", "Ex_BackColor", Constants.Ex_BackColor));
                gramSettDTO.Ex_ForeColor = int.Parse(ini.ReadValue("Example", "Ex_ForeColor", Constants.Ex_ForeColor));
                gramSettDTO.Ex_Width = int.Parse(ini.ReadValue("Example", "Ex_Width", Constants.Ex_Width));
                gramSettDTO.Ex_NoOfDisplay = int.Parse(ini.ReadValue("Example", "Ex_NoOfDisplay", Constants.Ex_NoOfDisplay));
                gramSettDTO.Ex_DisplayTime = int.Parse(ini.ReadValue("Example", "Ex_DisplayTime", Constants.Ex_DisplayTime));
                gramSettDTO.Ex_DelayTime = int.Parse(ini.ReadValue("Example", "Ex_DelayTime", Constants.Ex_DelayTime));
            }
            catch
            {
                gramSettDTO.Top = int.Parse(Constants.Top);
                gramSettDTO.Left = int.Parse(Constants.Left);
                gramSettDTO.BackColor = int.Parse(Constants.BackColor);
                gramSettDTO.ForeColor = int.Parse(Constants.ForeColor);
                gramSettDTO.Width = int.Parse(Constants.Width);
                gramSettDTO.JP_BackColor = int.Parse(Constants.JP_BackColor);
                gramSettDTO.JP_ForeColor = int.Parse(Constants.JP_ForeColor);
                gramSettDTO.JP_Width = int.Parse(Constants.JP_Width);
                gramSettDTO.JP_Isdisplayed = bool.Parse(Constants.JP_IsDisplayed);
                gramSettDTO.VN_BackColor = int.Parse(Constants.VN_BackColor);
                gramSettDTO.VN_ForeColor = int.Parse(Constants.VN_ForeColor);
                gramSettDTO.VN_Width = int.Parse(Constants.VN_Width);
                gramSettDTO.VN_IsDisplayed = bool.Parse(Constants.VN_IsDisplayed);
                gramSettDTO.Ex_BackColor = int.Parse(Constants.Ex_BackColor);
                gramSettDTO.Ex_ForeColor = int.Parse(Constants.Ex_ForeColor);
                gramSettDTO.Ex_Width = int.Parse(Constants.Ex_Width);
                gramSettDTO.Ex_NoOfDisplay = int.Parse(Constants.Ex_NoOfDisplay);
                gramSettDTO.Ex_DisplayTime = int.Parse(Constants.Ex_DisplayTime);
                gramSettDTO.Ex_DelayTime = int.Parse(Constants.Ex_DelayTime);
            }
            return gramSettDTO;
        }

        public void WriteGramSettings(DTO_GramSetting gramSettDTO, string iniPath)
        {

            IniFile ini = new IniFile(iniPath);
            ini.WriteValue("Position","Top",gramSettDTO.Top.ToString());
            ini.WriteValue("Position", "Left", gramSettDTO.Left.ToString());
            ini.WriteValue("Sample", "BackColor", gramSettDTO.BackColor.ToString());
            ini.WriteValue("Sample", "ForeColor", gramSettDTO.ForeColor.ToString());
            ini.WriteValue("Sample", "Width", gramSettDTO.Width.ToString());
            ini.WriteValue("JPMeaning", "JP_BackColor", gramSettDTO.JP_BackColor.ToString());
            ini.WriteValue("JPMeaning", "JP_ForeColor", gramSettDTO.JP_ForeColor.ToString());
            ini.WriteValue("JPMeaning", "JP_Width", gramSettDTO.JP_Width.ToString());
            ini.WriteValue("JPMeaning", "JP_IsDisplayed", gramSettDTO.JP_Isdisplayed.ToString());
            ini.WriteValue("VNMeaning", "VN_BackColor", gramSettDTO.VN_BackColor.ToString());
            ini.WriteValue("VNMeaning", "VN_ForeColor", gramSettDTO.VN_ForeColor.ToString());
            ini.WriteValue("VNMeaning", "VN_Width", gramSettDTO.VN_Width.ToString());
            ini.WriteValue("VNMeaning", "VN_IsDisplayed", gramSettDTO.VN_IsDisplayed.ToString());
            ini.WriteValue("Example", "Ex_BackColor", gramSettDTO.Ex_BackColor.ToString());
            ini.WriteValue("Example", "Ex_ForeColor", gramSettDTO.Ex_ForeColor.ToString());
            ini.WriteValue("Example", "Ex_Width", gramSettDTO.Ex_Width.ToString());
            ini.WriteValue("Example", "Ex_NoOfDisplay", gramSettDTO.Ex_NoOfDisplay.ToString());
            ini.WriteValue("Example", "Ex_DisplayTime", gramSettDTO.Ex_DisplayTime.ToString());
            ini.WriteValue("Example", "Ex_DelayTime", gramSettDTO.Ex_DelayTime.ToString());
        }
    }
}
