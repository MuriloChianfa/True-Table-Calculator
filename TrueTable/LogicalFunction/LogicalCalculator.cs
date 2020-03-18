using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.LogicalFunction {
    class LogicalCalculator {
        public static string condition1, condition2, result;
        public static int operators;
        public static void Exec(){
            Console.Clear();
            Console.WriteLine("The 1st Condition is True or False ? (0 - Return)\n");
            Console.WriteLine("T - True\nF - False\n");
            condition1 = Console.ReadLine();
            if(condition1 == "t" | condition1 == "T"){
                condition1 = "T";
            }
            else if(condition1 == "f" | condition1 == "F"){
                condition1 = "F";
            }
            else if(condition1 == "0"){
                LogicalMenu.Exec();
            }
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter a Valid Option.");
                Thread.Sleep(2000);
                Console.ResetColor();
                Exec();
            }

            Console.Clear();
            Console.WriteLine("Whatch Operator Will You Use ?");
            Console.WriteLine("1 - ^\n2 - v\n3 - v_\n4 - ->\n5 - <->\n\n");
            bool success = int.TryParse(Console.ReadLine(), out operators);

            Console.Clear();
            Console.WriteLine("The 2nd Condition is True or False ?\n");
            Console.WriteLine("T - True\nF - False\n");
            condition2 = Console.ReadLine();
            if(condition2 == "t" | condition2 == "T"){
                condition2 = "T";
            }
            else if(condition2 == "f" | condition2 == "F"){
                condition2 = "F";
            }
            else{
                Console.Clear();
                Console.WriteLine("Please Enter a Valid Option.");
                Thread.Sleep(2000);
                Exec();
            }


            // AND
            if(operators == 1){
                result = LogicalOperations.and(condition1, condition2);
                Continue();
            }
            // OR
            else if(operators == 2){
                result = LogicalOperations.or(condition1, condition2);
                Continue();
            }
            // XOR
            else if(operators == 3){
                result = LogicalOperations.xor(condition1, condition2);
                Continue();
            }
            // Implica
            else if(operators == 4){
                result = LogicalOperations.ifthen(condition1, condition2);
                Continue();
            }
            // DUPLA IMPLICA
            else if(operators == 5){
                result = LogicalOperations.ifonlyif(condition1, condition2);
                Continue();
            }
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, We Dont Find This Option ...");
                Thread.Sleep(2000);
                Console.ResetColor();
                Exec();
            }
        }
        public static void Continue(){
            Console.Clear();
            Console.WriteLine("Your Result is: {0}\n\n", result);
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Exec();
        }
    }
}