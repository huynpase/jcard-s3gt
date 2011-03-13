﻿using System;
using System.Collections;
using System.Text;

namespace J_Card_ImportData
{
    public class DTO_Grammar
    {
        long lGR_ID;

        public long LGR_ID
        {
            get { return lGR_ID; }
            set { lGR_ID = value; }
        }

        string str_Level;

        public string STR_Level
        {
            get { return str_Level; }
            set { str_Level = value; }
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
            str_Level = "";
            str_Sample = "";
            str_Syntax = "";
            str_Meaning_JP = "";
            str_Meaning_VN = "";
            //
            arrExample = new ArrayList();
            //int i = 0;
            //for (; i < Constants.MAX_GRAMMAR_EXAMPLE; i++)
            //{
            //    String tmpStr = "";
            //    arrExample.Add(tmpStr);
            //}
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTO_Grammar"/> class.
        /// </summary>
        /// <param name="sample">The sample.</param>
        /// <param name="meaning_jp">The meaning_jp.</param>
        /// <param name="meaning_vn">The meaning_vn.</param>
        /// <param name="example">The example.</param>
        public DTO_Grammar(string sample, string meaning_jp, string meaning_vn, ArrayList example)
        {
            str_Sample = sample;
            str_Meaning_JP = meaning_jp;
            str_Meaning_VN = meaning_vn;
            arrExample = example;
        }
    }
}