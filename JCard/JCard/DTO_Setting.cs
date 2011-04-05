////Nguyen
using System;

namespace JCard
{
    class DTO_Setting
    {
        //Set values for Form Vocabulary
        #region Position
        string _PositionVOC;
        int _DisplayTimeVOC, _WaitingTimeVOC, _Width;

        public string PositionVOC
        {
            get { return _PositionVOC; }
            set { _PositionVOC = value; }
        }

        public int DisplayTimeVOC
        {
            get { return _DisplayTimeVOC; }
            set { _DisplayTimeVOC = value; }
        }
       
        public int WaitingTimeVOC
        {
            get { return _WaitingTimeVOC; }
            set { _WaitingTimeVOC = value; }
        }

        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        #endregion

        //Set values for Kanji field
        #region Kanji
        int _Kanji_BackColor, _Kanji_ForeColor, _Kanji_FontSize, _Kanji_Width;
        bool _Kanji_IsDisplayed;

        public int Kanji_BackColor
        {
            get { return _Kanji_BackColor; }
            set { _Kanji_BackColor = value; }
        }

        public int Kanji_FontColor
        {
            get { return _Kanji_ForeColor; }
            set { _Kanji_ForeColor = value; }
        }

        public int Kanji_Fontsize
        {
            get { return _Kanji_FontSize; }
            set { _Kanji_FontSize = value; }
        }

        public bool Kanji_IsDisplayed
        {
            get { return _Kanji_IsDisplayed; }
            set { _Kanji_IsDisplayed = value; }
        }
        #endregion

        //Set values for Hiragana field
        #region Hiragana
        int _Hiragana_BackColor, _Hiragana_ForeColor, _Hiragana_FontSize, _Hiragana_Width;
        bool _Hiragana_IsDisplayed;

        public int Hiragana_BackColor
        {
            get { return _Hiragana_BackColor; }
            set { _Hiragana_BackColor = value; }
        }

        public int Hiragana_FontColor
        {
            get { return _Hiragana_ForeColor; }
            set { _Hiragana_ForeColor = value; }
        }

        public int Hiragana_Fontsize
        {
            get { return _Hiragana_FontSize; }
            set { _Hiragana_FontSize = value; }
        }

        public bool Hiragana_IsDisplayed
        {
            get { return _Hiragana_IsDisplayed; }
            set { _Hiragana_IsDisplayed = value; }
        }
        #endregion

        //Set values for Meaning field
        #region Meaning
        int _Meaning_BackColor, _Meaning_ForeColor, _Meaning_FontSize, _Meaning_Width;
        bool _Meaning_IsDisplayed;

        public int Meaning_BackColor
        {
            get { return _Meaning_BackColor; }
            set { _Meaning_BackColor = value; }
        }

        public int Meaning_FontColor
        {
            get { return _Meaning_ForeColor; }
            set { _Meaning_ForeColor = value; }
        }

        public int Meaning_Fontsize
        {
            get { return _Meaning_FontSize; }
            set { _Meaning_FontSize = value; }
        }

        public bool Meaning_IsDisplayed
        {
            get { return _Meaning_IsDisplayed; }
            set { _Meaning_IsDisplayed = value; }
        }
        #endregion
    }
}
