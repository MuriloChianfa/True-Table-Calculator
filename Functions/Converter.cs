using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class Converter {
        public static string option;
        public static float value1, result;
         public static void Exec()
        {
            Console.Clear();
            Console.WriteLine("Selecione qual o tipo de conversão você deseja fazer:\n");
            Console.WriteLine("1 - Temperatura");
            Console.WriteLine("2 - Distância\n");
            Console.WriteLine("0 - Voltar\n");
            option = Console.ReadLine();

            if (option == "1"){
                Console.Clear();
                Console.WriteLine("Escolha a conversão a ser feita\n");
                Console.WriteLine("1 - Celsius -> Fahrenheit");
                Console.WriteLine("2 - Fahrenheit -> Celsius\n");
                Console.WriteLine("3 - Celsius -> Kelvin");
                Console.WriteLine("4 - Kelvin -> Celsius\n");
                Console.WriteLine("5 - Fahrenheit -> Kelvin");
                Console.WriteLine("6 - Kelvin -> Fahrenheit\n");
                Console.WriteLine("0 - Voltar\n"); 
                option = Console.ReadLine();

                if (option == "1"){
                    CF();
                }
                else if (option == "2"){
                    FC();
                }
                else if (option == "3")
                {
                    CK();
                }
                else if (option == "4")
                {
                    KC();
                }
                else if (option == "5")
                {
                    FK();
                }
                else if (option == "6")
                {
                    KF();
                }
                else if (option == "0")
                {
                    Exec();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Invalid Number...");
                    Thread.Sleep(2000);
                    Exec();
                }
            }
            else if (option == "2"){
                Console.Clear();
                Console.WriteLine("Desculpe,esta operação está em construção");
                Thread.Sleep(2000);
                Exec();
            }
            else if (option == "0")
            {
                Program.Main();
            }
            else{
                Console.Clear();
                Console.WriteLine("Invalid Number...");
                Thread.Sleep(2000);
                Exec();
            }
            
        }

        public static void FC()
        {
            Console.Clear();

            Console.WriteLine("Digite a temperatura em Fahrenheit(°F) a ser convertida");
            value1 = float.Parse(Console.ReadLine());

            result = (value1 - 32)/ 1.8f;

            Console.Clear();

            Console.WriteLine(value1 + "°F são " + result + "°C\n\n");

            ReturnConverter();
        }
        public static void CF()
        {
            Console.Clear();

            Console.WriteLine("Digite a temperatura em Celsius(°C) a ser convertida");
            value1 = float.Parse(Console.ReadLine());

            result = (value1 * 1.8f) + 32;

            Console.Clear();

            Console.WriteLine(value1 + "°C são " +  result + "°F\n\n");

            ReturnConverter();
            
        }

        public static void CK()
        {
            Console.Clear();

            Console.WriteLine("Digite a temperatura em Celsius(°C) a ser convertida");
            value1 = float.Parse(Console.ReadLine());

            result = value1 + 273;

            Console.WriteLine(value1 + "°C são " +  result + "K\n\n");

            ReturnConverter();
        }

        public static void KC()
        {
            Console.Clear();

            Console.WriteLine("Digite a temperatura em Kelvin(K) a ser convertida");
            value1 = float.Parse(Console.ReadLine());

            result = value1 - 273.15f;

            Console.WriteLine(value1 + "K são " +  result + "°C\n\n");

            ReturnConverter();
        }
        public static void FK()
        {
            Console.Clear();
            
            Console.WriteLine("Digite a temperatura em Fahrenheit(°F) a ser convertida");
            value1 = float.Parse(Console.ReadLine());

            result = (value1 - 32)/ 1.8f + (273.15f); 

            Console.Clear();

            Console.WriteLine(value1 + "°F são " + result + "K\n\n");

            ReturnConverter();
        }
        public static void KF()
        {
            Console.Clear();

            Console.WriteLine("Digite a temperatura em Kelvin(K) a ser convertida");
            value1 = float.Parse(Console.ReadLine());

            result = (value1 - 273.15f)* 1.8f + (32);

            Console.WriteLine(value1 + "K são " +  result + "°F\n\n");

            ReturnConverter();
        }
        public static void ReturnConverter(){
            Console.WriteLine("Press ENTER To Continue...");
            Console.ReadKey();
            Exec();
        }
    }
}