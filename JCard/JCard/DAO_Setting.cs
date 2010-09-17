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
            DTO_Setting sttDTO = new DTO_Setting();
            ArrayList arrSetting = new ArrayList();            
            string temp = "";
            string subTemp ="";
            try
            {
                string FilePath = filePath;
                FileStream fStreamRead = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                StreamReader fStreamReader = new StreamReader(fStreamRead, Encoding.Default);
                //Doc cho den het file neu thuoc loai nao thi gan gia tri tuong an vao bien setting
                while (fStreamReader.Peek() >= 0)
                {
                    temp = fStreamReader.ReadLine();                  
                    if(temp.Contains("PositionVOC="))
                    {
                        subTemp = "PositionVOC=";
                        sttDTO.PositionVOC = temp.Remove(0, subTemp.Length);
                    }
                    else if (temp.Contains("DisplayTimeVOC="))
                    {
                        subTemp = "DisplayTimeVOC=";
                        sttDTO.DisplayTimeVOC = int.Parse(temp.Remove(0, subTemp.Length));
                    }
                    else if (temp.Contains("WaitingTimeVOC="))
                    {
                        subTemp = "WaitingTimeVOC=";
                        sttDTO.WaitingTimeVOC = int.Parse(temp.Remove(0, subTemp.Length));
                    }
                    else if (temp.Contains("FontSizeKanjVOC="))
                    {
                        subTemp = "FontSizeKanjVOC=";
                        sttDTO.FontSizeKanjiVOC= int.Parse(temp.Remove(0, subTemp.Length));
                    }
                    else if (temp.Contains("FontSizeHiraganaVOC="))
                    {
                        subTemp = "FontSizeHiraganaVOC=";
                        sttDTO.FontSizeKanaVOC = int.Parse(temp.Remove(0, subTemp.Length));
                    }
                    else if (temp.Contains("FontSizeImiVOC="))
                    {
                        subTemp = "FontSizeImiVOC=";
                        sttDTO.FontSizeImiVOC= int.Parse(temp.Remove(0, subTemp.Length));
                    }

                }                
                fStreamRead.Close();
                fStreamReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Can't read the file");
            }
            return sttDTO;
        }

        //Ghi setting ra file neu nguoi dung thay doi
        public void SaveSetting(DTO_Setting settingDTO, string filePath)
        {                     
            try
            {               
                string saveSetting = "";
                saveSetting += "PositionVOC=" + settingDTO.PositionVOC + "\r\n";
                saveSetting += "DisplayTimeVOC=" + settingDTO.DisplayTimeVOC + "\r\n";
                saveSetting += "WaitingTimeVOC=" + settingDTO.WaitingTimeVOC + "\r\n";
                saveSetting += "FontSizeKanjVOC=" + settingDTO.FontSizeKanjiVOC + "\r\n";
                saveSetting += "FontSizeHiraganaVOC=" + settingDTO.FontSizeKanaVOC + "\r\n";
                saveSetting += "FontSizeImiVOC=" + settingDTO.FontSizeImiVOC + "\r\n";

                StreamWriter file = new System.IO.StreamWriter(filePath);
                file.WriteLine(saveSetting);
                file.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Can't write the file.");
            }
        }
    }
}
