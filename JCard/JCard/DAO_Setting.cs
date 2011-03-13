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
        
        //public DTO_Setting ReadSetting(string filePath)
        //{
        //    DTO_Setting sttDTO = new DTO_Setting();
        //    ArrayList arrSetting = new ArrayList();            
        //    string temp = "";
        //    string subTemp ="";
        //    try
        //    {
        //        string FilePath = filePath;
        //        FileStream fStreamRead = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
        //        StreamReader fStreamReader = new StreamReader(fStreamRead, Encoding.Default);
        //        //Doc cho den het file neu thuoc loai nao thi gan gia tri tuong an vao bien setting
        //        while (fStreamReader.Peek() >= 0)
        //        {
        //            temp = fStreamReader.ReadLine();                  
        //            if(temp.Contains("PositionVOC="))
        //            {
        //                subTemp = "PositionVOC=";
        //                sttDTO.PositionVOC = temp.Remove(0, subTemp.Length);
        //            }
        //            else if (temp.Contains("DisplayTimeVOC="))
        //            {
        //                subTemp = "DisplayTimeVOC=";
        //                sttDTO.DisplayTimeVOC = int.Parse(temp.Remove(0, subTemp.Length));
        //            }
        //            else if (temp.Contains("WaitingTimeVOC="))
        //            {
        //                subTemp = "WaitingTimeVOC=";
        //                sttDTO.WaitingTimeVOC = int.Parse(temp.Remove(0, subTemp.Length));
        //            }
        //            else if (temp.Contains("FontSizeKanjVOC="))
        //            {
        //                subTemp = "FontSizeKanjVOC=";
        //                sttDTO.FontSizeKanjiVOC= int.Parse(temp.Remove(0, subTemp.Length));
        //            }
        //            else if (temp.Contains("FontSizeHiraganaVOC="))
        //            {
        //                subTemp = "FontSizeHiraganaVOC=";
        //                sttDTO.FontSizeKanaVOC = int.Parse(temp.Remove(0, subTemp.Length));
        //            }
        //            else if (temp.Contains("FontSizeImiVOC="))
        //            {
        //                subTemp = "FontSizeImiVOC=";
        //                sttDTO.FontSizeImiVOC= int.Parse(temp.Remove(0, subTemp.Length));
        //            }

        //        }                
        //        fStreamRead.Close();
        //        fStreamReader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Can't read the file");
        //    }
        //    return sttDTO;
        //}

        //Ghi setting ra file neu nguoi dung thay doi

       public DTO_Setting ReadSetting(string filePath)
       {
           DTO_Setting dto = new DTO_Setting();
           IniFile ini = new IniFile(filePath);

           try
           {
               dto.PositionVOC = ini.ReadValue("Jcard", "PositionVOC", "BR");
               dto.DisplayTimeVOC = float.Parse(ini.ReadValue("Jcard", "DisplayTimeVOC", "5"));
               dto.WaitingTimeVOC = float.Parse(ini.ReadValue("Jcard", "WaitingTimeVOC", "3"));
               dto.FontSizeKanjiVOC = float.Parse(ini.ReadValue("Jcard", "FontSizeKanjVOC", "19"));
               dto.FontSizeKanaVOC = float.Parse(ini.ReadValue("Jcard", "FontSizeHiraganaVOC", "16"));
               dto.FontSizeImiVOC = float.Parse(ini.ReadValue("Jcard", "FontSizeImiVOC", "13"));

               dto.FontSizeHanNom = float.Parse(ini.ReadValue("Jcard", "FontSizeHanNom", "16"));
           }
           catch 
           {
               
               dto.PositionVOC = Constants.PositionVOC;
               dto.DisplayTimeVOC = Constants.DisplayTimeVOC;
               dto.WaitingTimeVOC = Constants.WaitingTimeVOC ;
               dto.FontSizeKanjiVOC = Constants.FontSizeKanjiVOC;
               dto.FontSizeImiVOC = Constants.FontSizeImiVOC;
               dto.FontSizeKanaVOC = Constants.FontSizeKanaVOC;
               dto.FontSizeHanNom = Constants.FontSizeHanNom;

               SaveSetting(dto,filePath);
              
           }
         
           return dto;
       }
        public void SaveSetting(DTO_Setting settingDTO, string filePath)
        {                     
            try
            {               
               IniFile ini = new IniFile(filePath);
               ini.WriteValue("Jcard", "PositionVOC", settingDTO.PositionVOC);
               ini.WriteValue("Jcard", "DisplayTimeVOC", ((int)settingDTO.DisplayTimeVOC).ToString());
               ini.WriteValue("Jcard", "WaitingTimeVOC", ((int)settingDTO.WaitingTimeVOC).ToString());
               ini.WriteValue("Jcard", "FontSizeKanjVOC", ((int)settingDTO.FontSizeKanjiVOC).ToString());
               ini.WriteValue("Jcard", "FontSizeHiraganaVOC", ((int)settingDTO.FontSizeKanaVOC).ToString());
               ini.WriteValue("Jcard", "FontSizeImiVOC", ((int)settingDTO.FontSizeImiVOC).ToString());
               ini.WriteValue("Jcard", "FontSizeHanNom", ((int)settingDTO.FontSizeHanNom).ToString());

            }
            catch (Exception ex)
            {
                throw new Exception("Can't save setting.");
            }
        }
    }
}
