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
        public string XuLyXuongHangExampleJP(string exam)
        {
            string temp1 = String.Empty;
            string temp2 = String.Empty;
            if (exam.Length > Constants.MAX_LENGTH_NEWLINE)
            {
                temp1 = exam.Substring(0, Constants.MAX_LENGTH_NEWLINE);
                temp2 = exam.Substring(Constants.MAX_LENGTH_NEWLINE);
                if (temp1.Contains("、"))
                {
                    for (int i = 1; i < 5; i++)
                        if (temp1.LastIndexOf("、") == temp1.Length - i)
                            return temp1.Substring(0, temp1.LastIndexOf("、") + 1) + Environment.NewLine +
                                XuLyXuongHangExampleJP(exam.Substring(temp1.LastIndexOf("、") + 1));
                    return temp1 + Environment.NewLine +
                        XuLyXuongHangExampleJP(exam.Substring(Constants.MAX_LENGTH_NEWLINE));
                }
                else
                {
                    if (temp2.Contains("、"))
                    {
                        for (int j = 0; j < 3; j++)
                            if (temp2.LastIndexOf("、") == j)
                                return exam.Substring(0, Constants.MAX_LENGTH_NEWLINE + j + 1) + Environment.NewLine +
                                    XuLyXuongHangExampleJP(exam.Substring(Constants.MAX_LENGTH_NEWLINE + j + 1));
                        return temp1 + Environment.NewLine +
                            XuLyXuongHangExampleJP(exam.Substring(Constants.MAX_LENGTH_NEWLINE));
                    }
                    else
                        return temp1 + Environment.NewLine +
                            XuLyXuongHangExampleJP(exam.Substring(Constants.MAX_LENGTH_NEWLINE));
                }
            }
            else
                return exam;
        }

        /// <summary>
        /// Xus the ly xuong hang example VN.
        /// </summary>
        /// <returns></returns>
        public string XuLyXuongHangExampleVN(string exam)
        {
            string temp = String.Empty;
            if (exam.Length > Constants.MAX_LENGTH_NEWLINE)
            {
                temp = exam.Substring(0, Constants.MAX_LENGTH_NEWLINE);
                if (temp.Contains(" "))
                    if (temp.LastIndexOf(" ") + 1 == Constants.MAX_LENGTH_NEWLINE)
                        return temp.Substring(0, Constants.MAX_LENGTH_NEWLINE - 1) + Environment.NewLine +
                            XuLyXuongHangExampleVN(exam.Substring(Constants.MAX_LENGTH_NEWLINE));
                    else
                        return temp.Substring(0, temp.LastIndexOf(" ")) + Environment.NewLine +
                            XuLyXuongHangExampleVN(exam.Substring(temp.LastIndexOf(" ") + 1));
                else
                    return temp + Environment.NewLine + XuLyXuongHangExampleVN(exam.Substring(Constants.MAX_LENGTH_NEWLINE));
            }
            else
                return exam;
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
            if (exam_vn_displayed)
            {
                if (type)
                    return arrExampleJP[exIndex].ToString() + Environment.NewLine + arrExampleVN[exIndex].ToString();
                else
                    return XuLyXuongHangExampleJP(arrExampleJP[exIndex].ToString()) + Environment.NewLine + XuLyXuongHangExampleVN(arrExampleVN[exIndex].ToString());
            }
            else
            {
                if (type)
                    return arrExampleJP[exIndex].ToString();
                else
                    return XuLyXuongHangExampleJP(arrExampleJP[exIndex].ToString());
            }
        }
    }
}
