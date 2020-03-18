using System;
using System.Threading;

using AdvancedCalculator.TrueTable.LogicalFunction;
using AdvancedCalculator.TrueTable.NumericFunction;

namespace AdvancedCalculator.TrueTable {
    class TrueTableMenu {
        public static void Exec()
        {
            Console.Clear();
            Console.WriteLine("Main Menu\n\n1 - Logical Menu\n2 - Numeric Menu\n\n0 - Return\n");
            bool success = int.TryParse(Console.ReadLine(), out int option);
            if(success){

                
                if(option == 1){
                    LogicalMenu.Exec();
                }
                else if(option == 2){
                    NumericMenu.Exec();
                }
                else if(option == 0){
                    Program.Main();
                }
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option..");
                    Thread.Sleep(500);
                    Console.WriteLine("Invalid option...");
                    Thread.Sleep(500);
                    Console.WriteLine("Invalid option....");
                    Thread.Sleep(500);
                    Console.ResetColor();
                    Exec();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please... Enter With A Valid Number.");
                Thread.Sleep(2000);
                Console.ResetColor();
                Exec();
            }
        }
    }
}