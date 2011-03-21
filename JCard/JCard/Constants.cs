using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class Constants
    {
        public const int MAX_GRAMMAR_EXAMPLE = 10;
        public const string DATABASE_PATH = "datasource\\s3gt_db.mdb";
        public const string Top = "0";
        public const string Left = "0";
        public const string BackColor = "-256";
        public const string ForeColor = "-16777216";
        public const string Width = "130";
        public const string JP_BackColor = "-16724737";
        public const string JP_ForeColor = "-16777216";
        public const string JP_Width = "200";
        public const string JP_IsDisplayed = "True";
        public const string VN_BackColor = "-6697984";
        public const string VN_ForeColor = "-16777216";
        public const string VN_Width = "200";
        public const string VN_IsDisplayed = "True";
        public const string Ex_BackColor = "-4144960";
        public const string Ex_ForeColor = "-16777216";
        public const string Ex_Width = "250";
        public const string Ex_NoOfDisplay = "10";
        public const string Ex_DisplayTime = "30";
        public const string Ex_DelayTime = "3";
        public const int MIN_WIDTH = 100;
        public const int MAX_WIDTH = 500;
        public const int Timer_Interval = 2500;
        public const int sleepTime = 3000;


        //20100312: phuonghd : add code declare constant variable for setting jcard vocabulary
        public const string PositionVOC = "BR";
        public const float DisplayTimeVOC = 5;
        public const float WaitingTimeVOC = 3;
        public const float FontSizeKanjiVOC = 19;
        public const float FontSizeImiVOC = 13;
        public const float FontSizeKanaVOC = 16;
        public const float FontSizeHanNom = 16;

        // App Config
        public const string CONFIG_LANGUAGE_KEY = "Language";
        public const string CONFIG_LANGUAGE_VALUE = "vi-VN";

        // Resource Program
        public const string RES_PROGRAM_NAME = "ProgramName";
        public const string RES_PROGRAM_VALUE = "Chương trình J-Card";

        // Resource fCLesson
        public const string RES_TABVOCAB_NAME = "TabVocabulary";        
        public const string RES_S3GTLABEL_NAME = "lableS3GT";       
        public const string RES_TABGRAM_NAME = "TabGrammar";
        public const string RES_GROUPBOXVOCAB_NAME = "groupboxvocab";
        public const string RES_CHKBOXALL_NAME = "chkboxall";
        public const string RES_CHKBOXCOLLAPSE_NAME = "chkboxcollapse";
        public const string RES_GROUPBOXVOCABLEARN_NAME = "groupboxvocablearn";
        public const string RES_RADIOVOCABNEW_NAME = "radiovocabnew";
        public const string RES_RADIOVOCABLAST_NAME = "radiovocablast";
        public const string RES_RADIOVOCABALL_NAME = "radiovocaball";
        public const string RES_BTNSETTING_NAME = "btnsetting";
        public const string RES_BTNSTART_NAME = "btnstart";
        public const string RES_BTNSAVE_NAME = "btnsave";
        public const string RES_BTNCANCEL_NAME = "btncancel";
        public const string RES_BTNIMPORT_NAME = "btnimport";
        public const string RES_TABVOCAB_VALUE = "Từ Vựng";
        public const string RES_S3GTLABEL_VALUE = "CSDL S3GT:";
        public const string RES_TABGRAM_VALUE = "Ngữ Pháp";
        public const string RES_GROUPBOXVOCAB_VALUE = "Chọn chủ đề học";
        public const string RES_CHKBOXALL_VALUE = "Tất Cả";
        public const string RES_CHKBOXCOLLAPSE_VALUE = "Thu Gọn";
        public const string RES_GROUPBOXVOCABLEARN_VALUE = "Học Từ Vựng";
        public const string RES_RADIOVOCABNEW_VALUE = "Từ Mới";
        public const string RES_RADIOVOCABLAST_VALUE = "Từ Đã Học";
        public const string RES_RADIOVOCABALL_VALUE = "Tất Cả";
        public const string RES_BTNSETTING_VALUE = "Cấu Hình";
        public const string RES_BTNSTART_VALUE = "Bắt Đầu";
        public const string RES_BTNSAVE_VALUE = "Lưu";
        public const string RES_BTNCANCEL_VALUE = "Hủy";
        public const string RES_BTNIMPORT_VALUE = "Thêm Vào";

        // Resource fGramSettings
        public const string RES_GRAMSETT_NAME = "SettingGrammar";
        public const string RES_GRAMSETT_VALUE = "Cấu Hình Card Ngữ Pháp";
        public const string RES_GRAMSETT_SAVEBUTTON_NAME = "GramSettSaveButt";
        public const string RES_GRAMSETT_SAVEBUTTON_VALUE = "Lưu";
    }
}
