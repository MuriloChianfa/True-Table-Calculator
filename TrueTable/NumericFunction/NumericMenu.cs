using System;
using System.Threading;


namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericMenu {
        public static void Exec()
        {
            Console.Clear();
            Console.WriteLine("Numeric Menu\n\n1 - Numerical Calculator\n2 - Calculate All Numeric Possibilities\n3 - Show Numeric Table\n\n4 - Create a Numeric Poposition\n\n0 - Return\n");
            bool success = int.TryParse(Console.ReadLine(), out int option);
            if(success){

                
                if(option == 1){
                    NumericCalculator.Exec();
                }
                else if(option == 2){
                    NumericExpressionCalculator.Exec();
                }
                else if(option == 3){
                    NumericTable.Exec();
                }
                else if(option == 4){
                    NumericCreateProposition.Exec();
                }
                else if(option == 0){
                    TrueTableMenu.Exec();
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