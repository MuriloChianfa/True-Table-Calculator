using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabelaVerdade
{
    class LogicalTable
    {
        #region LogicalArray2
        public static string[] p2 = new[] { "T", "T", "F", "F" };
        public static string[] q2 = new[] { "T", "F", "T", "F" };
        public static string[] np2 = new[] { "F", "F", "T", "T" };
        public static string[] nq2 = new[] { "F", "T", "F", "T" };
        #endregion
        #region LogicalArray3
        public static string[] p3 = new[] { "T", "T", "T", "T", "F", "F", "F", "F" };
        public static string[] q3 = new[] { "T", "T", "F", "F", "T", "T", "F", "F" };
        public static string[] r3 = new[] { "T", "F", "T", "F", "T", "F", "T", "F" };
        public static string[] np3 = new[] { "F", "F", "F", "F", "T", "T", "T", "T" };
        public static string[] nq3 = new[] { "F", "F", "T", "T", "F", "F", "T", "T" };
        public static string[] nr3 = new[] { "F", "T", "F", "T", "F", "T", "F", "T" };
        #endregion
        #region LogicalArray4
        public static string[] p4 = new[] { "T", "T", "T", "T", "T", "T", "T", "T", "F", "F", "F", "F", "F", "F", "F", "F" };
        public static string[] q4 = new[] { "T", "T", "T", "T", "F", "F", "F", "F", "T", "T", "T", "T", "F", "F", "F", "F", };
        public static string[] r4 = new[] { "T", "T", "F", "F", "T", "T", "F", "F", "T", "T", "F", "F", "T", "T", "F", "F" };
        public static string[] s4 = new[] { "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F" };
        public static string[] np4 = new[] { "F", "F", "F", "F", "F", "F", "F", "F", "T", "T", "T", "T", "T", "T", "T", "T" };
        public static string[] nq4 = new[] { "F", "F", "F", "F", "T", "T", "T", "T", "F", "F", "F", "F", "T", "T", "T", "T" };
        public static string[] nr4 = new[] { "F", "F", "T", "T", "F", "F", "T", "T", "F", "F", "T", "T", "F", "F", "T", "T" };
        public static string[] ns4 = new[] { "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T" };
        #endregion
        public static string[] result2Return = new string[4];
        public static string[] result3Return = new string[8];
        public static string[] result4Return = new string[16];
    }
}
