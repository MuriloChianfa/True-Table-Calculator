using System;
using System.Threading;


namespace AdvancedCalculator.TrueTable.LogicalFunction {
    class LogicalMenu {
        public static void Exec()
        {
            Console.Clear();
            Console.WriteLine("Logical Menu\n\n1 - Logical Calculator\n2 - Calculate All Logical Possibilities\n3 - Show Logical Table\n\n4 - Create a Logical Poposition\n\n0 - Return\n");
            bool success = int.TryParse(Console.ReadLine(), out int option);
            if(success){

                
                if(option == 1){
                    LogicalCalculator.Exec();
                }
                else if(option == 2){
                    LogicalExpressionCalculator.Exec();
                }
                else if(option == 3){
                    LogicalTable.Exec();
                }
                else if(option == 4){
                    LogicalCreateProposition.Exec();
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