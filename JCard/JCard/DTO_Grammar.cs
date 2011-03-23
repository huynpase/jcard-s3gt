using System;
using System.Collections;
using System.Text;

namespace JCard
{
    public class DTO_Grammar
    {
        long lGR_ID;
        public long LGR_ID
        {
            get { return lGR_ID; }
            set { lGR_ID = value; }
        }

        long lCAT_ID;
        public long LCAT_ID
        {
            get { return lCAT_ID; }
            set { lCAT_ID = value; }
        }       

        string str_Sample;

        public string STR_Sample
        {
            get { return str_Sample; }
            set { str_Sample = value; }
        }

        string str_Syntax;

        public string STR_Syntax
        {
            get { return str_Syntax; }
            set { str_Syntax = value; }
        }

        string str_Meaning_JP;

        public string STR_Meaning_JP
        {
            get { return str_Meaning_JP; }
            set { str_Meaning_JP = value; }
        }

        string str_Meaning_VN;

        public string STR_Meaning_VN
        {
            get { return str_Meaning_VN; }
            set { str_Meaning_VN = value; }
        }

        ArrayList arrExampleVN;
        public ArrayList ArrExampleVN
        {
            get { return arrExampleVN; }
            set { arrExampleVN = value; }
        }

        ArrayList arrExample;
        public ArrayList ArrExample
        {
            get { return arrExample; }
            set { arrExample = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Grammar"/> class.
        /// </summary>
        public DTO_Grammar()
        {
            lGR_ID = 1;
            lCAT_ID = 1;          
            str_Sample = "";
            str_Syntax = "";
            str_Meaning_JP = "";
            str_Meaning_VN = "";
            arrExample = new ArrayList();
            arrExampleVN = new ArrayList();
        }

        public DTO_Grammar(DTO_Grammar grammar)
        {
            lGR_ID = grammar.LGR_ID;
            str_Sample = grammar.STR_Sample;
            str_Meaning_JP = grammar.STR_Meaning_JP;
            str_Meaning_VN = grammar.STR_Meaning_VN;
            lCAT_ID = grammar.LCAT_ID;
            str_Syntax = grammar.STR_Syntax;
            arrExample = new ArrayList();
            arrExampleVN = new ArrayList();

            int j = 0;
            for (j = 0; j < grammar.ArrExample.Count; j++)
                arrExample.Add(grammar.ArrExample[j].ToString());

            for (j = 0; j < grammar.ArrExampleVN.Count; j++)
                arrExampleVN.Add(grammar.ArrExampleVN[j].ToString());
        }
    }
}
