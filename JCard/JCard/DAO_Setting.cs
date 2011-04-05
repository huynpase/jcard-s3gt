////Nguyen
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace JCard
{
    class DAO_Setting
    {
       public DTO_Setting ReadSetting(string filePath)
       {
           DTO_Setting dto = new DTO_Setting();
           IniFile ini = new IniFile(filePath);
           try
           {
               dto.PositionVOC = ini.ReadValue("Vocabulary", "PositionVOC", Constants.PositionVOC);
               dto.DisplayTimeVOC = int.Parse(ini.ReadValue("Vocabulary", "DisplayTimeVOC", Constants.DisplayTimeVOC));
               dto.WaitingTimeVOC = int.Parse(ini.ReadValue("Vocabulary", "WaitingTimeVOC", Constants.WaitingTimeVOC));
               dto.Width = int.Parse(ini.ReadValue("Sample", "Width", Constants.VocabWidth));
               dto.Kanji_BackColor = int.Parse(ini.ReadValue("Kanji", "Kanji_BackColor", Constants.Kanji_BackColor));
               dto.Kanji_FontColor = int.Parse(ini.ReadValue("Kanji", "Kanji_FontColor", Constants.Kanji_FontColor));
               dto.Kanji_Fontsize = int.Parse(ini.ReadValue("Kanji", "Kanji_Fontsize", Constants.Kanji_Fontsize));
               dto.Kanji_IsDisplayed = bool.Parse(ini.ReadValue("Kanji", "Kanji_IsDisplayed", Constants.Kanji_IsDisplayed));
               dto.Hiragana_BackColor = int.Parse(ini.ReadValue("Hiragana", "Hiragana_BackColor", Constants.Hiragana_BackColor));
               dto.Hiragana_FontColor = int.Parse(ini.ReadValue("Hiragana", "Hiragana_FontColor", Constants.Hiragana_FontColor));
               dto.Hiragana_Fontsize = int.Parse(ini.ReadValue("Hiragana", "Hiragana_Fontsize", Constants.Hiragana_Fontsize));
               dto.Hiragana_IsDisplayed = bool.Parse(ini.ReadValue("Hiragana", "Hiragana_IsDisplayed", Constants.Hiragana_IsDisplayed));
               dto.Meaning_BackColor = int.Parse(ini.ReadValue("Meaning", "Meaning_BackColor", Constants.Meaning_BackColor));
               dto.Meaning_FontColor = int.Parse(ini.ReadValue("Meaning", "Meaning_FontColor", Constants.Meaning_FontColor));
               dto.Meaning_Fontsize = int.Parse(ini.ReadValue("Meaning", "Meaning_Fontsize", Constants.Meaning_Fontsize));
               dto.Meaning_IsDisplayed = bool.Parse(ini.ReadValue("Meaning", "Meaning_IsDisplayed",Constants.Meaning_IsDisplayed));
           }
           catch 
           {
               dto.PositionVOC = Constants.PositionVOC;
               dto.DisplayTimeVOC = int.Parse(Constants.DisplayTimeVOC);
               dto.WaitingTimeVOC = int.Parse(Constants.WaitingTimeVOC);
               dto.Width = int.Parse(Constants.VocabWidth);
               dto.Kanji_BackColor = int.Parse(Constants.Kanji_BackColor);
               dto.Kanji_FontColor = int.Parse(Constants.Kanji_FontColor);
               dto.Kanji_Fontsize = int.Parse(Constants.Kanji_Fontsize);
               dto.Kanji_IsDisplayed = bool.Parse(Constants.Kanji_IsDisplayed);
               dto.Hiragana_BackColor = int.Parse(Constants.Hiragana_BackColor);
               dto.Hiragana_FontColor = int.Parse(Constants.Hiragana_FontColor);
               dto.Hiragana_Fontsize = int.Parse(Constants.Hiragana_Fontsize);
               dto.Hiragana_IsDisplayed = bool.Parse(Constants.Hiragana_IsDisplayed);
               dto.Meaning_BackColor = int.Parse(Constants.Meaning_BackColor);
               dto.Meaning_FontColor = int.Parse(Constants.Meaning_FontColor);
               dto.Meaning_Fontsize = int.Parse(Constants.Meaning_Fontsize);
               dto.Meaning_IsDisplayed = bool.Parse(Constants.Meaning_IsDisplayed);
           }
           return dto;
       }
        public void SaveSetting(DTO_Setting settingDTO, string filePath)
        {
            IniFile ini = new IniFile(filePath);
            ini.WriteValue("Vocabulary", "PositionVOC", settingDTO.PositionVOC);
            ini.WriteValue("Vocabulary", "DisplayTimeVOC", settingDTO.DisplayTimeVOC.ToString());
            ini.WriteValue("Vocabulary", "WaitingTimeVOC", settingDTO.WaitingTimeVOC.ToString());
            ini.WriteValue("Vocabulary", "Width", settingDTO.Width.ToString());
            ini.WriteValue("Kanji", "Kanji_BackColor", settingDTO.Kanji_BackColor.ToString());
            ini.WriteValue("Kanji", "Kanji_FontColor", settingDTO.Kanji_FontColor.ToString());
            ini.WriteValue("Kanji", "Kanji_Fontsize", settingDTO.Kanji_Fontsize.ToString());
            ini.WriteValue("Kanji", "Kanji_IsDisplayed", settingDTO.Kanji_IsDisplayed.ToString());
            ini.WriteValue("Hiragana", "Hiragana_BackColor", settingDTO.Hiragana_BackColor.ToString());
            ini.WriteValue("Hiragana", "Hiragana_FontColor", settingDTO.Hiragana_FontColor.ToString());
            ini.WriteValue("Hiragana", "Hiragana_Fontsize", settingDTO.Hiragana_Fontsize.ToString());
            ini.WriteValue("Hiragana", "Hiragana_IsDisplayed", settingDTO.Hiragana_IsDisplayed.ToString());
            ini.WriteValue("Meaning", "Meaning_BackColor", settingDTO.Meaning_BackColor.ToString());
            ini.WriteValue("Meaning", "Meaning_FontColor", settingDTO.Meaning_FontColor.ToString());
            ini.WriteValue("Meaning", "Meaning_Fontsize", settingDTO.Meaning_Fontsize.ToString());
            ini.WriteValue("Meaning", "Meaning_IsDisplayed", settingDTO.Meaning_IsDisplayed.ToString());
        }
    }
}
