using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JCard
{
    class DAO_GramSetting
    {
        public DTO_GramSetting ReadGramSetting(string path)
        {
            DTO_GramSetting gramSettDTO = new DTO_GramSetting();
            ArrayList arrSett = new ArrayList();
            string temp = "";
            string subTemp = "";
            try
            {
                string filePath = path;
                FileStream fStream = new FileStream(filePath,FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fStream, Encoding.Default);

                while (streamReader.Peek() >= 0)
                {
                    temp = streamReader.ReadLine();
                    if (temp.Contains("Top="))
                    {
                        subTemp = "Top=";
                        gramSettDTO.Top = int.Parse(temp.Remove(0,subTemp.Length));
                    }

                    else if (temp.Contains("Left"))
                    {
                        subTemp = "Left=";
                        gramSettDTO.Left = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("BackColor"))
                    {
                        subTemp = "BackColor=";
                        gramSettDTO.BackColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("Width"))
                    {
                        subTemp = "Width=";
                        gramSettDTO.Width = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("JP_BackColor"))
                    {
                        subTemp = "JP_BackColor=";
                        gramSettDTO.JP_BackColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("JP_ForeColor"))
                    {
                        subTemp = "JP_ForeColor=";
                        gramSettDTO.JP_ForeColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("JP_Width"))
                    {
                        subTemp = "JP_Width=";
                        gramSettDTO.JP_Width = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("JP_IsDisplayed"))
                    {
                        subTemp = "JP_IsDiplayed=";
                        gramSettDTO.JP_Isdisplayed = bool.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("VN_BackColor"))
                    {
                        subTemp = "VN_BackColor=";
                        gramSettDTO.VN_BackColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("VN_ForeColor"))
                    {
                        subTemp = "VN_ForeColor=";
                        gramSettDTO.VN_ForeColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if(temp.Contains("VN_Width"))
                    {
                        subTemp = "VN_Width=";
                        gramSettDTO.VN_ForeColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("VN_IsDisplayed"))
                    {
                        subTemp = "VN_IsDisplayed=";
                        gramSettDTO.VN_IsDisplayed = bool.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("Ex_BackColor"))
                    {
                        subTemp = "Ex_BackColor=";
                        gramSettDTO.Ex_BackColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("Ex_ForeColor"))
                    {
                        subTemp = "Ex_ForeColor=";
                        gramSettDTO.Ex_ForeColor = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("Ex_NoOfDisplay"))
                    {
                        subTemp = "Ex_NoOfDisplay=";
                        gramSettDTO.Ex_NoOfDisplay = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("Ex_DisplayTime"))
                    {
                        subTemp = "Ex_DisplayTime=";
                        gramSettDTO.Ex_DisplayTime = int.Parse(temp.Remove(0, subTemp.Length));
                    }

                    else if (temp.Contains("Ex_DelayTime"))
                    {
                        subTemp = "Ex_DelayTime=";
                        gramSettDTO.Ex_DelayTime = int.Parse(temp.Remove(0, subTemp.Length));
                    }
                }
                fStream.Close();
                streamReader.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Can't read the setting file.");
            }

            return gramSettDTO;
        }

        public void WriteGramSettings(DTO_GramSetting gramSettDTO, string filePath)
        {
            try
            {
                string saveSettings = "";
                saveSettings += "[Position]\r\n";
                saveSettings += "Top=" + gramSettDTO.Top + "\r\n";
                saveSettings += "Left=" + gramSettDTO.Left + "\r\n";
                saveSettings += "\r\n[Sample]\r\n";
                saveSettings += "BackColor=" + gramSettDTO.BackColor + "\r\n";
                saveSettings += "ForeColor=" + gramSettDTO.ForeColor + "\r\n";
                saveSettings += "Width=" + gramSettDTO.Width + "\r\n";
                saveSettings += "\r\n[JPMeaning]\r\n";
                saveSettings += "JP_BackColor=" + gramSettDTO.JP_BackColor + "\r\n";
                saveSettings += "JP_ForeColor=" + gramSettDTO.JP_ForeColor + "\r\n";
                saveSettings += "JP_Width=" + gramSettDTO.JP_Width + "\r\n";
                saveSettings += "JP_IsDisplayed=" + Convert.ToString(gramSettDTO.JP_Isdisplayed) + "\r\n";
                saveSettings += "/r/n[VNMeaning]/r/n";
                saveSettings += "VN_BackColor=" + gramSettDTO.VN_BackColor + "\r\n";
                saveSettings += "VN_ForeColor=" + gramSettDTO.VN_ForeColor + "\r\n";
                saveSettings += "VN_Width=" + gramSettDTO.VN_Width + "\r\n";
                saveSettings += "VN_IsDisplayed=" + Convert.ToString(gramSettDTO.VN_IsDisplayed) + "\r\n";
                saveSettings += "\r\n[Example]\r\n";
                saveSettings += "Ex_BackColor=" + gramSettDTO.Ex_BackColor + "\r\n";
                saveSettings += "Ex_ForeColor=" + gramSettDTO.Ex_ForeColor + "\r\n";
                saveSettings += "Ex_NoOfDisplay=" + gramSettDTO.Ex_NoOfDisplay + "\r\n";
                saveSettings += "Ex_DisplayTime=" + gramSettDTO.Ex_DisplayTime + "\r\n";
                saveSettings += "Ex_DelayTime=" + gramSettDTO.Ex_DelayTime + "\r\n";

                StreamWriter file = new System.IO.StreamWriter(filePath);
                file.WriteLine(saveSettings);
                file.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Can't write the setting file.");
            }
        }
    }
}
