////Nguyen
using System;

namespace JCard
{
    class DTO_Setting
    {
        //Cac thuoc tinh chi mang tinh tam thoi, co the them bot tuy sau nay phat trien, sua doi
        //nhu mau sac font, mau background,...
        string _PositionVOC;//Set vi tri cua Vocabalary

        public string PositionVOC
        {
            get { return _PositionVOC; }
            set { _PositionVOC = value; }
        }
        //string _PositionGMR;//Set vi tri cua Grammer

        //public string PositionGMR
        //{
        //    get { return _PositionGMR; }
        //    set { _PositionGMR = value; }
        //}
        float _DisplayTimeVOC;//Set thoi gian xuat hien cua Vocabalary

        public float DisplayTimeVOC
        {
            get { return _DisplayTimeVOC; }
            set { _DisplayTimeVOC = value; }
        }
        //int _DisplayTimeGMR;//Set thoi gian xuat hien cua Grammer

        //public int DisplayTimeGMR
        //{
        //    get { return _DisplayTimeGMR; }
        //    set { _DisplayTimeGMR = value; }
        //}
        float _WaitingTimeVOC;

        public float WaitingTimeVOC
        {
            get { return _WaitingTimeVOC; }
            set { _WaitingTimeVOC = value; }
        }
        float _FontSizeKanjiVOC;//Set font cho loai chu Kanji

        public float FontSizeKanjiVOC
        {
            get { return _FontSizeKanjiVOC; }
            set { _FontSizeKanjiVOC = value; }
        }
        float _FontSizeKanaVOC;//Set font cho loai chu Kana (bao gom Hiragana va Katakana)

        public float FontSizeKanaVOC
        {
            get { return _FontSizeKanaVOC; }
            set { _FontSizeKanaVOC = value; }
        }
        float _FontSizeImiVOC;

        public float FontSizeImiVOC
        {
            get { return _FontSizeImiVOC; }
            set { _FontSizeImiVOC = value; }
        }
        //float _FontSizeGrammer1;//Set font cho chu cua Grammer, tuy sau nay phat trien the nao

        //public float FontSizeGrammer1
        //{
        //    get { return _FontSizeGrammer1; }
        //    set { _FontSizeGrammer1 = value; }
        //}
        //float _FontSizeGrammer2;

        //public float FontSizeGrammer2
        //{
        //    get { return _FontSizeGrammer2; }
        //    set { _FontSizeGrammer2 = value; }
        //}
        //float _FontSizeGrammer3;

        //public float FontSizeGrammer3
        //{
        //    get { return _FontSizeGrammer3; }
        //    set { _FontSizeGrammer3 = value; }
        //}

        public DTO_Setting()
        {
            PositionVOC = "BR";
            //PositionGMR = "BR";
            FontSizeKanjiVOC = 13;
            FontSizeKanaVOC = 13;
            FontSizeImiVOC = 13;
            DisplayTimeVOC = 5;
            //DisplayTimeGMR = 5;
            //FontSizeGrammer3 = 13;
            //FontSizeGrammer2 = 13;
            //FontSizeGrammer1 = 13;
        }
    }
}
