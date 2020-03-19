using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericTable {
        #region NumericArray2
        public static int[] A2 = new[] { 1, 1, 0, 0};
        public static int[] B2 = new[] { 1, 0, 1, 0};
        public static int[] nA2 = new[] { 0, 0, 1, 1};
        public static int[] nB2 = new[] { 0, 1, 0, 1};
        #endregion
        #region NumericArray3
        public static int[] A3 = new[] { 1, 1, 1, 1, 0, 0, 0, 0};
        public static int[] B3 = new[] { 1, 1, 0, 0, 1, 1, 0, 0};
        public static int[] C3 = new[] { 1, 0, 1, 0, 1, 0, 1, 0};
        public static int[] nA3 = new[] { 0, 0, 0, 0, 1, 1, 1, 1};
        public static int[] nB3 = new[] { 0, 0, 1, 1, 0, 0, 1, 1};
        public static int[] nC3 = new[] { 0, 1, 0, 1, 0, 1, 0, 1};
        #endregion
        #region NumericArray4
        public static int[] A4 = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0};
        public static int[] B4 = new[] { 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0,};
        public static int[] C4 = new[] { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0};
        public static int[] D4 = new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0};
        public static int[] nA4 = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1};
        public static int[] nB4 = new[] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1};
        public static int[] nC4 = new[] { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1};
        public static int[] nD4 = new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1};
        #endregion
        public static int[] result2Return = new int[4];
        public static int[] result3Return = new int[8];
        public static int[] result4Return = new int[16];
        public static void Exec(){
            Console.Clear();

            Console.WriteLine("How Many Propositions Will You Use ?");
            Console.WriteLine("\n2 -  2 Propositions (4 Possibilities)\n3 -  3 Propositions (8 Possibilities)\n4 -  4 Propositions (16 Possibilities)\n\n0 -  Return\n");
            bool success = int.TryParse(Console.ReadLine(), out int option);

            if(success){

                if(option == 2){
                    ShowTable2();
                    NumericMenuContinue();
                }
                else if(option == 3){
                    ShowTable3();
                    NumericMenuContinue();
                }
                else if(option == 4){
                    ShowTable4();
                    NumericMenuContinue();
                }
                else if(option == 0){
                    NumericMenu.Exec();
                }
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option....");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    NumericMenu.Exec();
                }
            }
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please... Enter With A Valid Number.");
                Thread.Sleep(2000);
                Console.ResetColor();
                Exec();
            }
        }

        private static void NumericMenuContinue(){
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadKey();
            Exec();
        }

        public static void ShowTable2(){
            Console.Clear();

            Console.WriteLine("+------+ +------+ +------+ +------+");
            Console.WriteLine("¦   A  ¦ ¦   B  ¦ ¦  !A  ¦ ¦  !B  ¦");
            Console.WriteLine("+------+ +------+ +------+ +------+");
            Console.WriteLine("+------+ +------+ +------+ +------+");
            for (int i = 0, j = 0, h = 0, k = 0; i < A2.Length; i++, j++, h++, k++)
            {
                int condition = A2[i];
                int condition2 = B2[j];
                int condition3 = nA2[h];
                int condition4 = nB2[k];
                Console.WriteLine("¦   {0}  ¦ ¦   {1}  ¦ ¦   {2}  ¦ ¦   {3}  ¦", condition, condition2, condition3, condition4);
            }
            Console.WriteLine("+------+ +------+ +------+ +------+\n");
        }

        public static void ShowTable3(){
            Console.Clear();

            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+");
                Console.WriteLine("¦   A  ¦ ¦   B  ¦ ¦   C  ¦ ¦  !A  ¦ ¦  !B  ¦ ¦  !C  ¦");
                Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+");
                Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+");
            for (int i = 0, j = 0, h = 0, k = 0, l = 0, m = 0; i < A3.Length; i++, j++, h++, k++, l++, m++)
            {
                int condition1 = A3[i];
                int condition2 = B3[j];
                int condition3 = C3[h];
                int condition4 = nA3[k];
                int condition5 = nB3[l];
                int condition6 = nC3[m];
                Console.WriteLine("¦   {0}  ¦ ¦   {1}  ¦ ¦   {2}  ¦ ¦   {3}  ¦ ¦   {4}  ¦ ¦   {5}  ¦", condition1, condition2, condition3, condition4, condition5, condition6);
            }
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+\n");
        }

        public static void ShowTable4(){
            Console.Clear();

            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+");
            Console.WriteLine("¦   A  ¦ ¦   B  ¦ ¦   C  ¦ ¦   D  ¦ ¦  !A  ¦ ¦  !B  ¦ ¦  !C  ¦ ¦  !D  ¦");
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+");
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+");
            for (int i = 0; i < A4.Length; i++)
            {
                int condition1 = A4[i];
                int condition2 = B4[i];
                int condition3 = C4[i];
                int condition4 = D4[i];
                int condition5 = nA4[i];
                int condition6 = nB4[i];
                int condition7 = nC4[i];
                int condition8 = nD4[i];
                Console.WriteLine("¦   {0}  ¦ ¦   {1}  ¦ ¦   {2}  ¦ ¦   {3}  ¦ ¦   {4}  ¦ ¦   {5}  ¦ ¦   {6}  ¦ ¦   {7}  ¦", condition1, condition2, condition3, condition4, condition5, condition6, condition7, condition8);
            }
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+\n");
        }
    }
}