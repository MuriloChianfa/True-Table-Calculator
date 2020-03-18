using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericCalculator {
        public static int condition1, condition2, operators, result;
        public static void Exec(){
            Console.Clear();
            Console.WriteLine("The 1st Number is 1 or 0 ? (2 - Return)\n");
            bool success = int.TryParse(Console.ReadLine(), out condition1);

            bool validNumber = condition1 >= 0 & condition1 <= 2;

            if(success){
                if(condition1 == 2)
                    NumericMenu.Exec();
            }
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter With a Valid Number.");
                Thread.Sleep(2000);
                Console.ResetColor();
                Exec();
            }

            if(validNumber){

                Console.Clear();
                Console.WriteLine("Whatch Operator Will You Use ?");
                Console.WriteLine("1 - AND\n2 - OR\n3 - XOR\n4 - ->\n5 - <->\n\n");
                bool validOperator = int.TryParse(Console.ReadLine(), out operators);

                Console.Clear();
                Console.WriteLine("The 2nd Number is 1 or 0 ? (2 - Return)\n");
                success = int.TryParse(Console.ReadLine(), out condition2);

                bool validNumber2 = condition2 >= 0 & condition2 <= 2;

                if(validNumber & validNumber2 & validOperator){
                    // AND
                    if(operators == 1){
                        result = and(condition1, condition2);
                        Continue();
                    }
                    // OR
                    else if(operators == 2){
                        result = or(condition1, condition2);
                        Continue();
                    }
                    // XOR
                    else if(operators == 3){
                        result = xor(condition1, condition2);
                        Continue();
                    }
                    // Implica
                    else if(operators == 4){
                        result = ifthen(condition1, condition2);
                        Continue();
                    }
                    // DUPLA IMPLICA
                    else if(operators == 5){
                        result = ifonlyif(condition1, condition2);
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
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Errno 8[");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Exec();
                }
            }else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter With a Valid Number.");
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