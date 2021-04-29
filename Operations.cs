using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabelaVerdade
{
    class Operations
    {
        public static string not(string condition1)
        {
            if (condition1 == "F") return "T";
            return "F";
        }
        public static string or(string condition1, string condition2)
        {
            if (condition1 == "T" | condition2 == "T") return "T";
            return "F";
        }
        public static string xor(string condition1, string condition2)
        {
            if (condition1 == "T" & condition2 == "T")
            {
                return "F";
            }
            else if (condition1 == "F" & condition2 == "F")
            {
                return "F";
            }
            return "T";
        }
        public static string and(string condition1, string condition2)
        {
            if (condition1 == "T" & condition2 == "T") return "T";
            return "F";
        }
        public static string ifthen(string condition1, string condition2)
        {
            if (condition1 == "F" | condition2 == "T") return "T";
            return "F";
        }
        public static string ifonlyif(string condition1, string condition2)
        {
            if ((condition1 == "T" & condition2 == "T") | (condition1 == "F" & condition2 == "F"))
            {
                return "T";
            }
            return "F";
        }
    }
}
