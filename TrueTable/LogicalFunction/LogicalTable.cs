using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.LogicalFunction {
    class LogicalTable {
        #region LogicalArray2
        public static string[] p2 = new[] { "T", "T", "F", "F"};
        public static string[] q2 = new[] { "T", "F", "T", "F"};
        public static string[] np2 = new[] { "F", "F", "T", "T"};
        public static string[] nq2 = new[] { "F", "T", "F", "T"};
        #endregion
        #region LogicalArray3
        public static string[] p3 = new[] { "T", "T", "T", "T", "F", "F", "F", "F"};
        public static string[] q3 = new[] { "T", "T", "F", "F", "T", "T", "F", "F"};
        public static string[] r3 = new[] { "T", "F", "T", "F", "T", "F", "T", "F"};
        public static string[] np3 = new[] { "F", "F", "F", "F", "T", "T", "T", "T"};
        public static string[] nq3 = new[] { "F", "F", "T", "T", "F", "F", "T", "T"};
        public static string[] nr3 = new[] { "F", "T", "F", "T", "F", "T", "F", "T"};
        #endregion
        #region LogicalArray4
        public static string[] p4 = new[] { "T", "T", "T", "T", "T", "T", "T", "T", "F", "F", "F", "F", "F", "F", "F", "F"};
        public static string[] q4 = new[] { "T", "T", "T", "T", "F", "F", "F", "F", "T", "T", "T", "T", "F", "F", "F", "F",};
        public static string[] r4 = new[] { "T", "T", "F", "F", "T", "T", "F", "F", "T", "T", "F", "F", "T", "T", "F", "F"};
        public static string[] s4 = new[] { "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F"};
        public static string[] np4 = new[] { "F", "F", "F", "F", "F", "F", "F", "F", "T", "T", "T", "T", "T", "T", "T", "T"};
        public static string[] nq4 = new[] { "F", "F", "F", "F", "T", "T", "T", "T", "F", "F", "F", "F", "T", "T", "T", "T"};
        public static string[] nr4 = new[] { "F", "F", "T", "T", "F", "F", "T", "T", "F", "F", "T", "T", "F", "F", "T", "T"};
        public static string[] ns4 = new[] { "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T", "F", "T"};
        #endregion
        public static string[] result2Return = new string[4];
        public static string[] result3Return = new string[8];
        public static string[] result4Return = new string[16];
        public static void Exec(){
            Console.Clear();

            Console.WriteLine("How Many Propositions Will You Use ?");
            Console.WriteLine("\n2 -  2 Propositions (4 Possibilities)\n3 -  3 Propositions (8 Possibilities)\n4 -  4 Propositions (16 Possibilities)\n\n0 -  Return\n");
            bool success = int.TryParse(Console.ReadLine(), out int option);

            if(success){

                if(option == 2){
                    ShowTable2();
                    LogicalMenuContinue();
                }
                else if(option == 3){
                    ShowTable3();
                    LogicalMenuContinue();
                }
                else if(option == 4){
                    ShowTable4();
                    LogicalMenuContinue();
                }
                else if(option == 0){
                    LogicalMenu.Exec();
                }
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option....");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    LogicalMenu.Exec();
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

        private static void LogicalMenuContinue(){
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadKey();
            Exec();
        }

        public static void ShowTable2(){
            Console.Clear();

            Console.WriteLine("+------+ +------+ +------+ +------+");
            Console.WriteLine("¦   p  ¦ ¦   q  ¦ ¦  ~p  ¦ ¦  ~q  ¦");
            Console.WriteLine("+------+ +------+ +------+ +------+");
            Console.WriteLine("+------+ +------+ +------+ +------+");
            for (int i = 0, j = 0, h = 0, k = 0; i < p2.Length; i++, j++, h++, k++)
            {
                string condition = p2[i];
                string condition2 = q2[j];
                string condition3 = np2[h];
                string condition4 = nq2[k];

                Console.Write("¦   ");
                if (condition == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition2 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition2);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition3 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition3);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition4 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition4);
                Console.ResetColor();
                Console.WriteLine("  ¦");
            }
            Console.WriteLine("+------+ +------+ +------+ +------+\n");
        }

        public static void ShowTable3(){
            Console.Clear();

            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+");
            Console.WriteLine("¦   p  ¦ ¦   q  ¦ ¦   r  ¦ ¦  ~p  ¦ ¦  ~q  ¦ ¦  ~r  ¦");
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+");
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+");
            for (int i = 0, j = 0, h = 0, k = 0, l = 0, m = 0; i < p3.Length; i++, j++, h++, k++, l++, m++)
            {
                string condition1 = p3[i];
                string condition2 = q3[j];
                string condition3 = r3[h];
                string condition4 = np3[k];
                string condition5 = nq3[l];
                string condition6 = nr3[m];
                
                Console.Write("¦   ");
                if (condition1 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition1);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition2 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition2);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition3 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition3);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition4 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition4);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition5 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition5);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition6 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition6);
                Console.ResetColor();
                Console.WriteLine("  ¦");
            }
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+\n");
        }

        public static void ShowTable4(){
            Console.Clear();

            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+");
            Console.WriteLine("¦   p  ¦ ¦   q  ¦ ¦   r  ¦ ¦   s  ¦ ¦  ~p  ¦ ¦  ~q  ¦ ¦  ~r  ¦ ¦  ~s  ¦");
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+");
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+");
            for (int i = 0; i < p4.Length; i++)
            {
                string condition1 = p4[i];
                string condition2 = q4[i];
                string condition3 = r4[i];
                string condition4 = s4[i];
                string condition5 = np4[i];
                string condition6 = nq4[i];
                string condition7 = nr4[i];
                string condition8 = ns4[i];
                
                Console.Write("¦   ");
                if (condition1 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition1);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition2 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition2);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition3 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition3);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition4 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition4);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition5 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition5);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition6 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition6);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition7 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition7);
                Console.ResetColor();
                Console.Write("  ¦ ");

                Console.Write("¦   ");
                if (condition8 == "T")
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", condition8);
                Console.ResetColor();
                Console.WriteLine("  ¦");
            }
            Console.WriteLine("+------+ +------+ +------+ +------+ +------+ +------+ +------+ +------+\n");
        }
    }
}