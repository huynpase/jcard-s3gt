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

        bool bl_IsLastSelected = false;
        public bool BL_IsLastSelected
        {
            get { return bl_IsLastSelected; }
            set { bl_IsLastSelected = value; }
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
            bl_IsLastSelected = false;

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
            bl_IsLastSelected = grammar.BL_IsLastSelected;
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
        /// <param name="exam">Chuoi JP can xu ly xuong hang.</param>
        /// <returns>Chuoi da xu ly</returns>
        public string XuLyXuongHangJP(string exam)
        {
            string temp1 = String.Empty;
            string temp2 = String.Empty;
            if (exam.Length > Constants.MAX_LENGTH_JP_NEWLINE)
            {
                temp1 = exam.Substring(0, Constants.MAX_LENGTH_JP_NEWLINE);
                temp2 = exam.Substring(Constants.MAX_LENGTH_JP_NEWLINE);
                int last_index_of = 0;
                int last_index_of_comma = 0;
                int last_index_of_dot = 0;
                if (temp1.Contains(Constants.COMMA_JP))
                {
                    last_index_of_comma = temp1.LastIndexOf(Constants.COMMA_JP);
                    if(temp1.Contains(Constants.DOT_JP))
                    {
                        last_index_of_dot = temp1.LastIndexOf(Constants.DOT_JP);
                        if (last_index_of_comma > last_index_of_dot)
                            last_index_of = last_index_of_comma;
                        else
                            last_index_of = last_index_of_dot;
                    }
                    else
                        last_index_of = last_index_of_comma;
                    
                    for (int i = 1; i < 5; i++)
                        if (last_index_of == temp1.Length - i)
                            return temp1.Substring(0, last_index_of + 1) + Environment.NewLine +
                                XuLyXuongHangJP(exam.Substring(last_index_of + 1));
                    return temp1 + Environment.NewLine +
                        XuLyXuongHangJP(exam.Substring(Constants.MAX_LENGTH_JP_NEWLINE));
                }
                else
                {
                    if (temp2.Contains(Constants.COMMA_JP))
                    {
                        last_index_of_comma = temp2.IndexOf(Constants.COMMA_JP);
                        if (temp2.Contains(Constants.DOT_JP))
                        {
                            last_index_of_dot = temp2.IndexOf(Constants.DOT_JP);
                            if (last_index_of_comma > last_index_of_dot)
                                last_index_of = last_index_of_dot;
                            else
                                last_index_of = last_index_of_comma;
                        }
                        else
                            last_index_of = last_index_of_comma;

                        for (int j = 0; j < 3; j++)
                            if (last_index_of == j)
                                return exam.Substring(0, Constants.MAX_LENGTH_JP_NEWLINE + j + 1) + Environment.NewLine +
                                    XuLyXuongHangJP(exam.Substring(Constants.MAX_LENGTH_JP_NEWLINE + j + 1));
                        return temp1 + Environment.NewLine +
                            XuLyXuongHangJP(exam.Substring(Constants.MAX_LENGTH_JP_NEWLINE));
                    }
                    else
                        return temp1 + Environment.NewLine +
                            XuLyXuongHangJP(exam.Substring(Constants.MAX_LENGTH_JP_NEWLINE));
                }
            }
            else
                return exam;
        }

        /// <summary>
        /// Xus the ly xuong hang example VN.
        /// </summary>
        /// <param name="exam">Chuoi VN can xu ly xuong hang.</param>
        /// <returns>Chuoi da xu ly</returns>
        public string XuLyXuongHangVN(string exam)
        {
            string temp1 = String.Empty;
            string temp2 = String.Empty;
            if (exam.Length > Constants.MAX_LENGTH_VN_NEWLINE)
            {
                temp1 = exam.Substring(0, Constants.MAX_LENGTH_VN_NEWLINE);
                temp2 = exam.Substring(Constants.MAX_LENGTH_VN_NEWLINE);
                int last_index_of = 0;
                if (temp1.Contains(Constants.SPACE))
                {
                    last_index_of = temp1.LastIndexOf(Constants.SPACE);
                    if (last_index_of + 1 == Constants.MAX_LENGTH_VN_NEWLINE)
                        return temp1.Substring(0, Constants.MAX_LENGTH_VN_NEWLINE - 1) + Environment.NewLine +
                            XuLyXuongHangVN(exam.Substring(Constants.MAX_LENGTH_VN_NEWLINE));
                    else
                        return temp1.Substring(0, last_index_of) + Environment.NewLine +
                            XuLyXuongHangVN(exam.Substring(last_index_of + 1));
                }
                else
                {
                    if (temp2.Contains(Constants.SPACE))
                    {
                        last_index_of = temp2.IndexOf(Constants.SPACE);
                        return exam.Substring(0, Constants.MAX_LENGTH_VN_NEWLINE + last_index_of) + Environment.NewLine +
                                    XuLyXuongHangVN(exam.Substring(Constants.MAX_LENGTH_VN_NEWLINE + last_index_of + 1));
                    }
                    else
                        return exam;
                }
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
        /// <returns>Chuoi vi du</returns>
        public string GetExample(int exIndex, bool exam_vn_displayed, bool type)
        {
            if (exam_vn_displayed)
            {
                if (type)
                    return arrExampleJP[exIndex].ToString() + Environment.NewLine + arrExampleVN[exIndex].ToString();
            }
            else
            {
                if (type)
                    return arrExampleJP[exIndex].ToString();
            }

            return XuLyXuongHangJP(arrExampleJP[exIndex].ToString()) + Environment.NewLine + XuLyXuongHangVN(arrExampleVN[exIndex].ToString());
        }

        /// <summary>
        /// Gets the meaning of jp.
        /// </summary>
        /// <returns>Chuoi meaning jp</returns>
        public string GetMeaningJP()
        {
            if (str_Meaning_JP == null)
                return String.Empty;
            return XuLyXuongHangJP(str_Meaning_JP);
        }

        /// <summary>
        /// Gets the meaning of vn.
        /// </summary>
        /// <returns>Chuoi meaning vn</returns>
        public string GetMeaningVN()
        {
            if (str_Meaning_VN == null)
                return String.Empty;
            return XuLyXuongHangVN(str_Meaning_VN);
        }

        /// <summary>
        /// Gets the meaning for tooltip: include of JP meaning and VN meaning.
        /// </summary>
        /// <returns>Chuoi meaning jp+vn</returns>
        public string GetMeaning()
        {
            if (str_Meaning_JP == null)
                return GetMeaningVN();
            if (str_Meaning_VN == null)
                return GetMeaningJP();
            return GetMeaningJP() + Environment.NewLine + GetMeaningVN();
        }

        /// <summary>
        /// Gets the sample.
        /// </summary>
        /// <returns>Chuoi sample</returns>
        public string GetSample()
        {
            if (str_Sample == null)
                return String.Empty;
            return XuLyXuongHangJP(str_Sample);
        }
    }
}
