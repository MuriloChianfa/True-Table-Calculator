using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class InterestCalculator {
        public static string option;
        public static float value1, value2, value3, result;
        public static double num1, num2, num3, result2;
        public static void Exec()
        {
            Console.Clear();

            Console.WriteLine($"1 - Juros Simples\n2 - Juros compostos\n\n0 - Voltar\n");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();

                Console.WriteLine("Digite o capital inicial : ");
                value1 = float.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Digite a taxa: ");
                value2 = float.Parse(Console.ReadLine());

                value2 = value2/100;

                Console.Clear();

                Console.WriteLine("Digite o tempo em meses: ");
                value3=float.Parse(Console.ReadLine());

                result=value1*value2*value3+value1;

                Console.Clear();

                Console.WriteLine("O seu Resultado é de: {0:C2} , e seu capital inicial foi de: {1:C2}\n", result , value1);

                Console.WriteLine("Press ENTER To Continue...");
                Console.ReadKey();
                Exec();
            }
            else if(option == "0")
            {
                Program.Main();
            }
            else if(option == "2")
            {
                Console.Clear();

                Console.WriteLine("Digite o capital inicial: ");
                num1=double.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Digite a taxa: ");
                num2=double.Parse(Console.ReadLine());

                num2=num2/100;

                Console.Clear();

                Console.WriteLine("Digite o tempo em meses: ");
                num3=int.Parse(Console.ReadLine());

                result2=num1;

                for(int time=0 ; time<num3; time++)
                {
                    result2=result2*(1+num2);
                }

                Console.WriteLine("O capital final é de: {0:C2}, e seu capital inicial foi de {1:C2}\n", result2, num1);

                Console.WriteLine("Press ENTER To Continue...");
                Console.ReadKey();
                Exec();
            }
            else{
                Console.Clear();
                Console.WriteLine("Invalid Number...");
                Thread.Sleep(1500);
                Exec();
            }
        }
    }
}