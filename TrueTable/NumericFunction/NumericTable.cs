using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericTable {
        #region Array2
        public static int[] p2 = new[] { 1, 1, 0, 0};
        public static int[] q2 = new[] { 1, 0, 1, 0};
        public static int[] np2 = new[] { 0, 0, 1, 1};
        public static int[] nq2 = new[] { 0, 1, 0, 1};
        #endregion
        #region Array3
        public static int[] p3 = new[] { 1, 1, 1, 1, 0, 0, 0, 0};
        public static int[] q3 = new[] { 1, 1, 0, 0, 1, 1, 0, 0};
        public static int[] r3 = new[] { 1, 0, 1, 0, 1, 0, 1, 0};
        public static int[] np3 = new[] { 0, 0, 0, 0, 1, 1, 1, 1};
        public static int[] nq3 = new[] { 0, 0, 1, 1, 0, 0, 1, 1};
        public static int[] nr3 = new[] { 0, 1, 0, 1, 0, 1, 0, 1};
        #endregion
        #region Array4
        public static int[] p4 = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0};
        public static int[] q4 = new[] { 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0,};
        public static int[] r4 = new[] { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0};
        public static int[] s4 = new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0};
        public static int[] np4 = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1};
        public static int[] nq4 = new[] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1};
        public static int[] nr4 = new[] { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1};
        public static int[] ns4 = new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1};
        #endregion
        
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
            for (int i = 0, j = 0, h = 0, k = 0; i < p2.Length; i++, j++, h++, k++)
            {
                int condition = p2[i];
                int condition2 = q2[j];
                int condition3 = np2[h];
                int condition4 = nq2[k];
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
            for (int i = 0, j = 0, h = 0, k = 0, l = 0, m = 0; i < p3.Length; i++, j++, h++, k++, l++, m++)
            {
                int condition1 = p3[i];
                int condition2 = q3[j];
                int condition3 = r3[h];
                int condition4 = np3[k];
                int condition5 = nq3[l];
                int condition6 = nr3[m];
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
            for (int i = 0; i < p4.Length; i++)
            {
                int condition1 = p4[i];
                int condition2 = q4[i];
                int condition3 = r4[i];
                int condition4 = s4[i];
                int condition5 = np4[i];
                int condition6 = nq4[i];
                int condition7 = nr4[i];
                int condition8 = ns4[i];
                Console.WriteLine("¦   {0}  ¦ ¦   {1}  ¦ ¦   {2}  ¦ ¦   {3}  ¦ ¦   {4}  ¦ ¦   {5}  ¦ ¦   {6}  ¦ ¦   {7}  ¦", condition1, condition2, condition3, condition4, condition5, condition6, condition7, condition8);
            }
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+\n");
        }
    }
}