using System;
using System.Collections.Generic;
using System.Text;

namespace JCard
{
    public class DTO
    {
        private String _Kanji;
        public System.String Kanji
        {
            get { return _Kanji; }
            set { _Kanji = value; }
        }
        private String _Yomikata;
        public System.String Yomikata
        {
            get { return _Yomikata; }
            set { _Yomikata = value; }
        }
        private String _HanNom;
        public System.String HanNom
        {
            get { return _HanNom; }
            set { _HanNom = value; }
        }
        private String _Imi;
        public System.String Imi
        {
            get { return _Imi; }
            set { _Imi = value; }
        }
        private String _Kunyomi;

        public String Kunyomi
        {
            get { return _Kunyomi; }
            set { _Kunyomi = value; }
        }
        private String _Onyomi;
        public System.String Onyomi
        {
            get { return _Onyomi; }
            set { _Onyomi = value; }
        }
        private String _Rei;
        public System.String Rei
        {
            get { return _Rei; }
            set { _Rei = value; }
        }
    }
}
