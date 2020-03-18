using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericCreateProposition {
        public static void Exec(){
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Option In Development.");
            Thread.Sleep(800);
            Console.ResetColor();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Option In Development..");
            Thread.Sleep(800);
            Console.ResetColor();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Option In Development...");
            Thread.Sleep(800);
            Console.ResetColor();
            
            NumericMenu.Exec();
        }
    }
}