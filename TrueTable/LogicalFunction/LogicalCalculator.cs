using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.LogicalFunction {
    class LogicalCalculator {
        public static string condition1, condition2, resultValue;
        public static int condition1value, condition2value, operators, result;
        public static void Exec(){
            Console.Clear();
            Console.WriteLine("The 1st Condition is True or False ? (0 - Return)\n");
            Console.WriteLine("T - True\nF - False\n");
            condition1 = Console.ReadLine();
            if(condition1 == "t" | condition1 == "T"){
                condition1value = 1;
            }
            else if(condition1 == "f" | condition1 == "F"){
                condition1value = 0;
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
                condition2value = 1;
            }
            else if(condition2 == "f" | condition2 == "F"){
                condition2value = 0;
            }
            else{
                Console.Clear();
                Console.WriteLine("Please Enter a Valid Option.");
                Thread.Sleep(2000);
                Exec();
            }


            // AND
            if(operators == 1){
                result = and(condition1value, condition2value);
                Converter(result);
            }
            // OR
            else if(operators == 2){
                result = or(condition1value, condition2value);
                Converter(result);
            }
            // XOR
            else if(operators == 3){
                result = xor(condition1value, condition2value);
                Converter(result);
            }
            // Implica
            else if(operators == 4){
                result = ifthen(condition1value, condition2value);
                Converter(result);
            }
            // DUPLA IMPLICA
            else if(operators == 5){
                result = ifonlyif(condition1value, condition2value);
                Converter(result);
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

        public static void Converter(int result){
            if(result == 1){
                resultValue = "T";
                Continue(resultValue);
            }
            else if(result == 0){
                resultValue = "F";
                Continue(resultValue);
            }
            else{
                Console.Clear();
                Console.WriteLine("WhAt tHe FUck ?");
                LogicalMenu.Exec();
            }
        }
        public static void Continue(string resultValue){
            Console.Clear();
            Console.WriteLine("Your Result is: {0}\n\n", resultValue);
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Exec();
        }
        public static int not(int condition1) {
		if(condition1==0) return 1;
		return 0;
        }
        public static int or(int condition1, int condition2) {
            if(condition1==1 | condition2==1) return 1;
            return 0;
        }
        public static int xor(int condition1, int condition2) {
            if(condition1==1 & condition2==1){
                return 0;
            }
            else if(condition1==0 & condition2==0){
                return 0;
            }
            return 1;
        }
        public static int and(int condition1, int condition2) {
            if(condition1==1 & condition2==1) return 1;
            return 0;
        }
        public static int ifthen(int condition1, int condition2) {
            if(condition1==0 | condition2==1) return 1;
            return 0;
        }
        public static int ifonlyif(int condition1, int condition2) {
            if((condition1==1 & condition2==1) | (condition1==0 & condition2==0)){
                return 1;
            }
            return 0;
        }
    }
}