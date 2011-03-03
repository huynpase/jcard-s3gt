using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class DTO_GramSetting
    {
        // Set the POSITION
        #region Position
        int _Top,_Left;
        public int Top
        {
            get { return _Top; }
            set { _Top = value; }
        }

        public int Left
        {
            get { return _Left; }
            set { _Left = value; }
        }
        #endregion
        //Set values for Sample Panel
        #region Sample
        int _BackColor, _ForeColor, _Width;
        public int BackColor
        {
            get { return _BackColor; }
            set { _BackColor = value; }
        }

        public int ForeColor
        {
            get { return _ForeColor; }
            set { _ForeColor = value; }
        }

        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        #endregion
        //Set values for Japanese Meaning Panel
        #region Japanese Meaning
        int _JP_BackColor, _JP_ForeColor, _JP_Width;
        bool _JP_IsDiplayed;

        public int JP_BackColor
        {
            get { return _JP_BackColor; }
            set { _JP_BackColor = value; }
        }

        public int JP_ForeColor
        {
            get { return _JP_ForeColor; }
            set { _JP_ForeColor = value; }
        }

        public int JP_Width
        {
            get { return _JP_Width; }
            set { _JP_Width = value; }
        }

        public bool JP_Isdisplayed
        {
            get { return _JP_IsDiplayed; }
            set { _JP_IsDiplayed = value; }
        }
        #endregion
        //Set values for Vietnamese Meaning Panel
        #region Vietnamese Meaning
        int _VN_BackColor, _VN_ForeColor, _VN_Width;
        bool _VN_IsDisplayed;

        public int VN_BackColor
        {
            get { return _VN_BackColor; }
            set { _VN_BackColor = value; }
        }

        public int VN_ForeColor
        {
            get { return _VN_ForeColor; }
            set { _VN_ForeColor = value; }
        }

        public int VN_Width
        {
            get { return _VN_Width; }
            set { _VN_Width = value; }
        }

        public bool VN_IsDisplayed
        {
            get { return _VN_IsDisplayed; }
            set { _VN_IsDisplayed = value; }
        }
        #endregion
        //Set values for Example Panel
        #region Example
        int _Ex_BackColor, _Ex_ForeColor, _Ex_NoOfDisplay, _Ex_DisplayTime, _Ex_DelayTime;
        public int Ex_BackColor
        {
            get { return _Ex_BackColor; }
            set { _Ex_BackColor = value; }
        }

        public int Ex_ForeColor
        {
            get { return _Ex_ForeColor; }
            set { _Ex_ForeColor = value; }
        }

        public int Ex_NoOfDisplay
        {
            get { return _Ex_NoOfDisplay; }
            set { _Ex_NoOfDisplay = value; }
        }

        public int Ex_DisplayTime
        {
            get { return _Ex_DisplayTime; }
            set { _Ex_DisplayTime = value; }
        }

        public int Ex_DelayTime
        {
            get { return _Ex_DelayTime; }
            set { _Ex_DelayTime = value; }
        }
        #endregion
    }
}
