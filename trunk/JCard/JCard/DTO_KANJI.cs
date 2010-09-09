using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class DTO_KANJI
    {
        string kanji;

        public string Kanji
        {
            get { return kanji; }
            set { kanji = value; }
        }
        string kunyomi;
        public string Kunyomi
        {
            get { return kunyomi; }
            set { kunyomi = value; }
        }
        string onyomin;
        public string Onyomin
        {
            get { return onyomin; }
            set { onyomin = value; }
        }
        string hannom;
        public string Hannom
        {
            get { return hannom; }
            set { hannom = value; }
        }
    }
}
