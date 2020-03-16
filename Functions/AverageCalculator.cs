using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class AverageCalculator {
        public static bool haveName = false;
        public static string name;
        public static int possibilities;
        public static float note, sum, result;
        public static void Exec()
        {
            Console.Clear();

            if(!haveName){
            Console.WriteLine("Qual o Seu Nome ? (0 - Voltar)\n");
            name = Console.ReadLine();
            }

            if(name != null)
                haveName = true;

            if(name == "0")
                Program.Main();
            

            Console.Clear();

            Console.WriteLine("Quantas Notas Você Possui ? (0 - Voltar)\n");
            possibilities = int.Parse(Console.ReadLine());
            int[] numberPossibilities = new int[possibilities];
            
            if (possibilities == 0)
                Program.Main();


            if (possibilities < 10)
            {
                float[] Notes = new float[possibilities];
                for (int i = 0; i < possibilities; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Qual a Sua {0}° Nota ?\n", i + 1);
                    note = float.Parse(Console.ReadLine());
                    Notes[i] = note;
                }

                if (name != "")
                {
                    Console.Clear();
                    Console.WriteLine("{0}, A Media Entre:\n", name);
                    foreach (var number in Notes)
                    {
                        sum += number;
                        Console.WriteLine("\t{0}", number);
                    }
                    result = sum / Notes.Length;
                    Console.WriteLine("\nÉ De: {0}", result);
                    Console.WriteLine("\nPress ENTER to Continue...");
                    Console.ReadKey();
                    Exec();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter With a Valid Name...");
                    Thread.Sleep(1500);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Number...");
                Thread.Sleep(1500);
                Exec();
            }
        }
    }
}