using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    class DTO_GramSetting
    {
        // Set the POSITION
        #region Position
        float _Top,_Left;
        public float Top
        {
            get { return _Top; }
            set { _Top = value; }
        }

        public float Left
        {
            get { return _Left; }
            set { _Left = value; }
        }
        #endregion
        //Set values for Sample Panel
        #region Sample
        float _BackColor, _ForeColor, _Width;
        public float BackColor
        {
            get { return _BackColor; }
            set { _BackColor = value; }
        }

        public float ForeColor
        {
            get { return _ForeColor; }
            set { _ForeColor = value; }
        }

        public float Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        #endregion
        //Set values for Japanese Meaning Panel
        #region Japanese Meaning
        float _JP_BackColor, _JP_ForeColor, _JP_Width, _JP_IsDiplayed;
        public float JP_BackColor
        {
            get { return _JP_BackColor; }
            set { _JP_BackColor = value; }
        }

        public float JP_ForeColor
        {
            get { return _JP_ForeColor; }
            set { _JP_ForeColor = value; }
        }

        public float JP_Width
        {
            get { return _JP_Width; }
            set { _JP_Width = value; }
        }

        public float JP_Isdisplayed
        {
            get { return _JP_IsDiplayed; }
            set { _JP_IsDiplayed = value; }
        }
        #endregion
        //Set values for Vietnamese Meaning Panel
        #region Vietnamese Meaning
        float _VN_BackColor, _VN_ForeColor, _VN_Width, _VN_IsDisplayed;

        public float VN_BackColor
        {
            get { return _VN_BackColor; }
            set { _VN_BackColor = value; }
        }

        public float VN_ForeColor
        {
            get { return _VN_ForeColor; }
            set { _VN_ForeColor = value; }
        }

        public float VN_Width
        {
            get { return _VN_Width; }
            set { _VN_Width = value; }
        }

        public float IsDisplayed
        {
            get { return _VN_IsDisplayed; }
            set { _VN_IsDisplayed = value; }
        }
        #endregion
        //Set values for Example Panel
        float _Ex_BackColor, _Ex_ForeColor, _Ex_NoOfDisplay, _Ex_DisplayTime, _Ex_DelayTime;
        public float Ex_BackColor
        {
            get { return _Ex_BackColor; }
            set { _Ex_BackColor = value; }
        }

        public float Ex_ForeColor
        {
            get { return _Ex_ForeColor; }
            set { _Ex_ForeColor = value; }
        }

        public float Ex_NoOfDisplay
        {
            get { return _Ex_NoOfDisplay; }
            set { _Ex_NoOfDisplay = value; }
        }

        public float Ex_DisplayTime
        {
            get { return _Ex_DisplayTime; }
            set { _Ex_DisplayTime = value; }
        }

        public float Ex_DelayTime
        {
            get { return _Ex_DelayTime; }
            set { _Ex_DelayTime = value; }
        }
    }
}
