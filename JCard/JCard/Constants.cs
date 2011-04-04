using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class Constants
    {
        public const int MAX_GRAMMAR_EXAMPLE = 10;       
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
        public const string Ex_VNIsDisplayed = "True";
        public const int MIN_WIDTH = 100;
        public const int MAX_WIDTH = 500;
        public const int Timer_Interval = 2500;
        public const int sleepTime = 3000;

        //Setting Vocabulary
        public const string PositionVOC = "BR";
        public const string DisplayTimeVOC = "5";
        public const string WaitingTimeVOC = "3";

        public const string Kanji_BackColor = "-32640";
        public const string Kanji_FontColor = "-16777216";
        public const string Kanji_IsDisplayed = "True";
        public const string Kanji_Fontsize = "20";

        public const string Hiragana_BackColor = "-4128832";
        public const string Hiragana_FontColor = "-16777216";
        public const string Hiragana_IsDisplayed = "True";
        public const string Hiragana_Fontsize = "15";

        public const string Meaning_BackColor = "-8000";
        public const string Meaning_FontColor = "-16777216";
        public const string Meaning_IsDisplayed = "True";
        public const string Meaning_Fontsize = "15";

        // App Config
        public const string CONFIG_LANGUAGE_KEY = "Language";
        public const string CONFIG_LANGUAGE_VALUE = "vi-VN";
        public const string DATABASE_PATH = "datasource\\s3gt_db.mdb";
        public const string CONFIG_DATABASE_PATH_KEY = "DatabasePath";

        // Resource Program
        public const string RES_PROGRAM_NAME = "ProgramName";
        public const string RES_PROGRAM_VALUE = "Chương trình J-Card";

        // Resource fCLesson
        public const string RES_TABVOCAB_NAME = "TabVocabulary";        
        public const string RES_S3GTLABEL_NAME = "lableS3GT";       
        public const string RES_TABGRAM_NAME = "TabGrammar";
        public const string RES_GROUPBOXVOCAB_NAME = "groupboxvocab";
        public const string RES_GROUPBOXGRAMMAR_NAME = "groupboxgrammar";
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
        public const string RES_BTNBROWSE_NAME = "btnbrowse";
        public const string RES_BTNCLOSE_NAME = "btnclose";

        public const string RES_TABVOCAB_VALUE = "Từ Vựng";
        public const string RES_S3GTLABEL_VALUE = "CSDL S3GT:";
        public const string RES_TABGRAM_VALUE = "Ngữ Pháp";
        public const string RES_GROUPBOXVOCAB_VALUE = "Chọn mẫu từ vựng để học";
        public const string RES_GROUPBOXGRAMMAR_VALUE = "Chọn mẫu ngữ pháp để học";
        public const string RES_CHKBOXALL_VALUE = "Tất Cả";
        public const string RES_CHKBOXCOLLAPSE_VALUE = "Thu Gọn";
        public const string RES_GROUPBOXVOCABLEARN_VALUE = "Học Từ Vựng";
        public const string RES_RADIOVOCABNEW_VALUE = "Từ Mới";
        public const string RES_RADIOVOCABLAST_VALUE = "Từ Đã Học";
        public const string RES_RADIOVOCABALL_VALUE = "Tất Cả";
        public const string RES_BTNSETTING_VALUE = "Cấu Hình";
        public const string RES_BTNSTART_VALUE = "Bắt Đầu";
        public const string RES_BTNSAVE_VALUE = "Lưu";
        public const string RES_BTNCANCEL_VALUE = "Hủy Bỏ";
        public const string RES_BTNIMPORT_VALUE = "Thêm Vào";
        public const string RES_BTNBROWSE_VALUE = "Duyệt...";
        public const string RES_BTNCLOSE_VALUE = "Đóng";

        // Resource fGramSettings
        public const string RES_GRAMSETT_NAME = "SettingGrammar";
        public const string RES_GRBSAMPLE_NAME = "grbsample";
        public const string RES_GRBJAP_NAME = "grbjap";
        public const string RES_GRBVIE_NAME = "grbvie";
        public const string RES_GRBEX_NAME = "grbex";
        public const string RES_LBLBGCLR_NAME = "lblbgclr";
        public const string RES_LBLFCLR_NAME = "lblfclr";
        public const string RES_CHKBOXISDISPLAYED_NAME = "chkboxisdisplayed";
        public const string RES_LBLEXNUM_NAME = "lblexnum";
        public const string RES_LBLDISPLAY_NAME = "lbldisplay";
        public const string RES_LBLDELAY_NAME = "lbldelay";
        public const string RES_CHKBOXVNISDISPLAYED_NAME = "chkboxvnisdisplayed";

        public const string RES_GRAMSETT_VALUE = "Cấu Hình Card Ngữ Pháp";
        public const string RES_GRBSAMPLE_VALUE = "Mẫu Ngữ Pháp";
        public const string RES_GRBJAP_VALUE = "Nghĩa Tiếng Nhật";
        public const string RES_GRBVIE_VALUE = "Nghĩa Tiếng Việt";
        public const string RES_GRBEX_VALUE = "Ví Dụ";
        public const string RES_LBLBGCLR_VALUE = "Màu Nền:";
        public const string RES_LBLFCLR_VALUE = "Màu Chữ:";
        public const string RES_CHKBOXISDISPLAYED_VALUE = "Hiển Thị";
        public const string RES_LBLEXNUM_VALUE = "Số Lượng Hiển Thị:";
        public const string RES_LBLDISPLAY_VALUE = "Thời Gian Hiển Thị (s):";
        public const string RES_LBLDELAY_VALUE = "Thời Gian Ẩn (s):";
        public const string RES_CHKBOXVNISDISPLAYED_VALUE = "Hiển thị ví dụ Tiếng Việt";

        //Resource fSetting
        public const string RES_VOCABSETT_NAME = "vocabsett";
        public const string RES_GRBPOS_NAME = "grbpos";
        public const string RES_GRBPROP_NAME = "grbprop";
        public const string RES_RADTR_NAME = "radtr";
        public const string RES_RADTL_NAME = "radtl";
        public const string RES_RADBR_NAME = "radbr";
        public const string RES_RADBL_NAME = "radbl";
        public const string RES_LBLFKANJI_NAME = "lblfkanji";
        public const string RES_LBLFKANA_NAME = "lblfkana";
        public const string RES_LBLFHAN_NAME = "lblfhan";
        public const string RES_LBLFMEANING_NAME = "lblfmeaning";

        public const string RES_VOCABSETT_VALUE = "Cấu Hình Card Từ Vựng";
        public const string RES_GRBPOS_VALUE = "Vị Trí Hiển Thị";
        public const string RES_GRBPROP_VALUE = "Các Thiết Lập";
        public const string RES_RADTR_VALUE = "Phía Trên Bên Phải";
        public const string RES_RADTL_VALUE = "Phía Trên Bên Trái";
        public const string RES_RADBR_VALUE = "Phía Dưới Bên Phải";
        public const string RES_RADBL_VALUE = "Phía Dưới Bên Trái";
        public const string RES_LBLFKANJI_VALUE = "Cỡ Chữ Kanji:";
        public const string RES_LBLFKANA_VALUE = "Cỡ Chữ Kana:";
        public const string RES_LBLFHAN_VALUE = "Cỡ Chữ Hán Nôm:";
        public const string RES_LBLFMEANING_VALUE = "Cỡ Chữ Phần Nghĩa:";

        //Resource Import Data Form
        public const string RES_IMPORTDATA_NAME = "importdata";
        public const string RES_LBLDATASOURCE_NAME = "lbldatasource";
        public const string RES_LBLCHOOSECAT_NAME = "lblchoosecat";
        public const string RES_BTNADDCAT_NAME = "btnaddcat";
        public const string RES_RADDEL_NAME = "raddel";
        public const string RES_RADKEEP_NAME = "radkeep";

        public const string RES_IMPORTDATA_VALUE = "Nhập Dữ Liệu Từ file Excel";
        public const string RES_LBLDATASOURCE_VALUE = "Nguồn Dữ Liệu:";
        public const string RES_LBLCHOOSECAT_VALUE = "Chọn Nhóm:";
        public const string RES_BTNADDCAT_VALUE = "Thêm Nhóm";
        public const string RES_RADDEL_VALUE = "Thay thế ngữ pháp cũ trong nhóm bằng ngữ pháp mới";
        public const string RES_RADKEEP_VALUE = "Giữ nguyên ngữ pháp cũ và chèn thêm ngữ pháp mới";

        //Resource Add Category Form
        public const string RES_CATEGORYNAME_NAME = "categoryname";
        public const string RES_DESCRIPTION_NAME = "description";

        public const string RES_CATEGORYNAME_VALUE = "Tên Nhóm:";
        public const string RES_DESCRIPTION_VALUE = "Mô tả về nhóm:";

        //Resource Context Menu
        public const string RES_MAINSCREEN_NAME = "mainscreen";
        public const string RES_EXIT_NAME = "exit"; 
        public const string RES_VOCABULARY_NAME = "vocabulary"; 

        public const string RES_MAINSCREEN_VALUE = "Trở lại Màn hình chính";
        public const string RES_EXIT_VALUE = "Thoát";
        public const string RES_VOCABULARY_VALUE = "J-Card - Từ Vựng";

        //Resource About Form
        public const string RES_ABOUT_NAME = "about";
        public const string RES_COPYRIGHT_NAME = "copyright";
        public const string RES_MEMBERS_NAME = "members";

        public const string RES_ABOUT_VALUE = "Thông Tin J-Card";
        public const string RES_COPYRIGHT_VALUE = "Bản Quyền thuộc về FSOFT HCM (JCD) 2011";
        public const string RES_MEMBERS_VALUE = "Các Thành Viên của Dự Án:";

        // Resource Messages
        public const string RES_ERROR_TITLE_NAME = "MsgErrorTitle";
        public const string RES_ERROR_TITLE_VALUE = "Thông Báo Lỗi";
        public const string RES_INFO_TITLE_NAME = "MsgInfoTitle";
        public const string RES_INFO_TITLE_VALUE = "Thông Báo";
        public const string RES_WARN_TITLE_NAME = "MsgWarnTitle";
        public const string RES_WARN_TITLE_VALUE = "Cảnh Báo";
        public const string RES_CONFIRM_TITLE_NAME = "MsgConfirmTitle";
        public const string RES_CONFIRM_TITLE_VALUE = "Thông Báo Xác Nhận";
        public const string RES_S3GT_OPEN_TITLE_NAME = "MsgS3gtOpenTitle";
        public const string RES_S3GT_OPEN_TITLE_VALUE = "Hãy chọn file CSDL S3GT";
        public const string RES_EXCEL_OPEN_TITLE_NAME = "MsgExcelOpenTitle";
        public const string RES_EXCEL_OPEN_TITLE_VALUE = "Hãy chọn file Excel";
        public const string RES_ERROR_NAME = "MsgError";
        public const string RES_ERROR_VALUE = "Lỗi khi thao tác Cơ Sở Dữ Liệu hoặc File. Vui lòng gửi nội dung lỗi sau đây cho người tạo chương trình:";
        public const string RES_SELECT_GRAM_INFO_NAME = "MsgSelectGram";
        public const string RES_SELECT_GRAM_INFO_VALUE = "Hãy chọn ít nhất một mẫu ngữ pháp trước khi bắt đầu học.";
        public const string RES_SELECT_TOPIC_INFO_NAME = "MsgSelectTopic";        
        public const string RES_SELECT_TOPIC_INFO_VALUE = "Hãy chọn ít nhất một chủ đề trước khi bắt đầu học.";        
        public const string RES_SELECT_CAT_FAIL_NAME = "MsgSelectCatFail";        
        public const string RES_SELECT_CAT_FAIL_VALUE = "Vui lòng chọn category cần để nhập dữ liệu?";        
        public const string RES_EMPTY_EXCEL_FILE_NAME = "MsgEmptyExcel";
        public const string RES_EMPTY_EXCEL_FILE_VALUE = "Không có dữ liệu trong file Excel.\nVui lòng chọn file Excel khác để import.";
        public const string RES_IMPORT_FAIL_NAME = "MsgImportFail";
        public const string RES_IMPORT_FAIL_VALUE = "Thất bại trong quá trình import vào Cơ Sở Dữ Liệu.";
        public const string RES_IMPORT_SUCESSFULL_NAME = "MsgImportSucessfull";
        public const string RES_IMPORT_SUCESSFULL_VALUE = "Đã import dữ liệu thành công.";
        public const string RES_SELECT_EXCEL_FILE_NAME = "MsgSelectExcel";
        public const string RES_SELECT_EXCEL_FILE_VALUE = "Hãy chọn file Excel trước khi thực hiện import.";
        public const string RES_SELECT_S3GT_FILE_NAME = "MsgSelectS3gt";
        public const string RES_SELECT_S3GT_FILE_VALUE = "Hãy chọn file CSDL S3GT trước khi thực hiện import.";
        public const string RES_CAT_NAME_EMPTY_NAME = "MsgCatNameEmpty";
        public const string RES_CAT_NAME_EMPTY_VALUE = "Tên Nhóm không được phép rỗng.\nVui lòng nhập Tên Nhóm trước khi lưu.";
        public const string RES_ADD_CAT_FAIL_NAME = "MsgAddCatFail";
        public const string RES_ADD_CAT_FAIL_VALUE = "Thất bại trong quá trình thêm dữ liệu vào Cơ Sở Dữ Liệu.";
        public const string RES_ADD_CAT_SUCESSFULL_NAME = "MsgAddCatSucessfull";
        public const string RES_ADD_CAT_SUCESSFULL_VALUE = "Đã thêm dữ liệu thành công.";
        public const string RES_SAVE_SETTING_SUCESSFULL_NAME = "MsgSaveSettingSucessfull";
        public const string RES_SAVE_SETTING_SUCESSFULL_VALUE = "Đã lưu cấu hình thành công.";
        public const string RES_CLOSE_PROGRAM_NAME = "MsgCloseProgram";
        public const string RES_CLOSE_PROGRAM_VALUE = "Bạn có muốn thoát khỏi chương trình hay không?";     
        public const string RES_START_PROGRAM_NAME = "MsgStartProgram";
        public const string RES_START_PROGRAM_VALUE = "Chương trình J-Card đang mở.\nVui lòng kiểm tra lại chương trình trên thanh Taskbar hoặc System Tray.";

        // Resource DTO_Grammar
        public const int MAX_LENGTH_JP_NEWLINE = 25;
        public const int MAX_LENGTH_VN_NEWLINE = 50;
        public const string COMMA_JP = "、";
        public const string DOT_JP = "。";
        public const string SPACE = " ";
    }
}
