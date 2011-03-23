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

        ArrayList arrExampleJP;
        public ArrayList ArrExampleJP
        {
            get { return arrExampleJP; }
            set { arrExampleJP = value; }
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

            arrExampleVN = new ArrayList();
            arrExampleJP = new ArrayList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Grammar"/> class.
        /// </summary>
        /// <param name="sample">The sample.</param>
        /// <param name="meaning_jp">The meaning_jp.</param>
        /// <param name="meaning_vn">The meaning_vn.</param>
        /// <param name="example">The example.</param>
        public DTO_Grammar(string sample, string meaning_jp, string meaning_vn, ArrayList exampleVN, ArrayList exampleJP)
        {
            str_Sample = sample;
            str_Meaning_JP = meaning_jp;
            str_Meaning_VN = meaning_vn;
            arrExampleVN = exampleVN;
            arrExampleJP = exampleJP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Grammar"/> class.
        /// </summary>
        /// <param name="grammar">Grammar khoi tao</param>
        public DTO_Grammar(DTO_Grammar grammar)
        {
            lGR_ID = grammar.LGR_ID;
            str_Sample = grammar.STR_Sample;
            str_Meaning_JP = grammar.STR_Meaning_JP;
            str_Meaning_VN = grammar.STR_Meaning_VN;
            str_Syntax = grammar.STR_Syntax;
            arrExampleJP = new ArrayList();
            arrExampleVN = new ArrayList();
            
            int j = 0;
            for (j = 0; j < grammar.ArrExampleJP.Count; j++)
                arrExampleJP.Add(grammar.ArrExampleJP[j].ToString());

            for (j = 0; j < grammar.ArrExampleVN.Count; j++)
                arrExampleVN.Add(grammar.ArrExampleVN[j].ToString());
        }

        /// <summary>
        /// Xus the ly xuong hang example JP.
        /// </summary>
        /// <returns></returns>
        public string XuLyXuongHangExampleJP()
        {
            return "";
        }

        /// <summary>
        /// Xus the ly xuong hang example VN.
        /// </summary>
        /// <returns></returns>
        public string XuLyXuongHangExampleVN()
        {
            return "";
        }

        /// <summary>
        /// Gets the example.
        /// </summary>
        /// <param name="exIndex">Index of the ex.</param>
        /// <param name="exam_vn_displayed">if set to <c>true</c> [exam_vn_displayed].</param>
        /// <param name="type">if set to <c>true</c> [type].</param>
        /// <returns></returns>
        public string GetExample(int exIndex, bool exam_vn_displayed, bool type)
        {
            if (type)
                return arrExampleJP[exIndex].ToString() + Environment.NewLine + arrExampleVN[exIndex].ToString();
            else
                return XuLyXuongHangExampleJP() + Environment.NewLine + XuLyXuongHangExampleVN();
        }
    }
}
