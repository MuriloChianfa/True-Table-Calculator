using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class MultiplicationTable {
        public static void Exec(){
            Console.Clear();

            Console.WriteLine("┌─────────────┐\t+-------------+\t┌─────────────┐\t+-------------+\t┌─────────────┐\t+-------------+\t┌─────────────┐\t+-------------+");
            Console.WriteLine("│Tabuada do 2 │\t¦Tabuada do 3 ¦\t│Tabuada do 4 │\t¦Tabuada do 5 ¦\t│Tabuada do 6 │\t¦Tabuada do 7 ¦\t│Tabuada do 8 │\t¦Tabuada do 9 ¦");
            Console.WriteLine("└─────────────┘\t+-------------+\t└─────────────┘\t+-------------+\t└─────────────┘\t+-------------+\t└─────────────┘\t+-------------+");
            for (int tabuada=1;tabuada<=10;tabuada++)
            {
            Console.WriteLine("2*{0}={1}\t\t3*{0}={2}\t\t4*{0}={3}\t\t5*{0}={4}\t\t6*{0}={5}\t\t7*{0}={6}\t\t8*{0}={7}\t\t9*{0}={8}",tabuada,2*tabuada,3*tabuada,4*tabuada,5*tabuada,6*tabuada,7*tabuada,8*tabuada,9*tabuada);
            }

            Console.WriteLine("\nPress ENTER to Continue...");
            Console.ReadKey();
            Program.Main();
        }
    }
}