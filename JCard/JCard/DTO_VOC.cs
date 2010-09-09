using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class DTO_VOC
    {
        string kanji;
        public string Kanji
        {
            get { return kanji; }
            set { kanji = value; }
        }
        string hiragana;
        public string Hiragana
        {
            get { return hiragana; }
            set { hiragana = value; }
        }
        string hannom;
        public string Hannom
        {
            get { return hannom; }
            set { hannom = value; }
        }
        string meaning;
        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }
    }
}
