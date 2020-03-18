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
                Console.WriteLine("1 - AND\n2 - NAND\n3 - OR\n4 - NOR\n5 - XOR\n6 - XNOR\n7 - NOT\n\n");
                bool validOperator = int.TryParse(Console.ReadLine(), out operators);

                if(operators != 7){

                    

                    Console.Clear();
                    Console.WriteLine("The 2nd Number is 1 or 0 ? (2 - Return)\n");
                    success = int.TryParse(Console.ReadLine(), out condition2);

                    bool validNumber2 = condition2 >= 0 & condition2 <= 2;

                    if(validNumber & validNumber2 & validOperator){
                        if(operators == 1){
                            result = NumericOperations.and(condition1, condition2);
                            Continue();
                        }
                        else if(operators == 2){
                            result = NumericOperations.nand(condition1, condition2);
                            Continue();
                        }
                        else if(operators == 3){
                            result = NumericOperations.or(condition1, condition2);
                            Continue();
                        }
                        else if(operators == 4){
                            result = NumericOperations.nor(condition1, condition2);
                            Continue();
                        }
                        else if(operators == 5){
                            result = NumericOperations.xor(condition1, condition2);
                            Continue();
                        }
                        else if(operators == 6){
                            result = NumericOperations.xnor(condition1, condition2);
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
                }
                else if(operators == 7){
                    result = NumericOperations.not(condition1);
                    Continue();
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
    }
}