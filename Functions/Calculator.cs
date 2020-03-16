using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class Calculator {
        public static float result, value1, value2;
        public static int currentExponent, exponent = 1; 
        public static string option;
        public static void Exec(){
            Console.Clear();
            Console.WriteLine("Menu\n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potencia\n");
            Console.WriteLine("0 - Voltar");

            option = Console.ReadLine();
            
            if(option != "0" & option != "5"){
                Console.Clear();
                Console.WriteLine("Digite o Primeiro Valor");
                value1 = float.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o Segundo Valor");
                value2 = float.Parse(Console.ReadLine());
                Console.Clear();

                if (option == "1")
                {
                    result = value1 + value2;
                    Console.Clear();
                    ContinueToCalculator2(result);
                }
                else if (option == "2")
                {
                    result = value1 - value2;
                    Console.Clear();
                    ContinueToCalculator2(result);
                }
                else if (option == "3")
                {
                    result = value1 * value2;
                    Console.Clear();
                    ContinueToCalculator2(result);
                }
                else if (option == "4")
                {
                    result = value1 / value2;
                    Console.Clear();
                    ContinueToCalculator2(result);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida... Desculpe-nos");
                    Thread.Sleep(2500);
                    Exec();
                }
            }
            else if(option == "5"){
                Console.Clear();
                Console.WriteLine("Digite o Valor Da Base: ");
                value1 = float.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite o Valor Do Expoente(Apenas Numeros Inteiros): ");
                exponent = int.Parse(Console.ReadLine());

                if(exponent == 2){
                    result = value1 * value1;
                    Console.Clear();
                    Console.WriteLine($"OPERAÇÂO: {value1}^{exponent}\n");
                    Console.WriteLine($"{value1} * {value1}\n{result}\n");
                    Console.WriteLine("Pressione ENTER Para Continuar...");
                    Console.ReadKey();
                    Exec();
                }
                else if(exponent != 2){
                    result = value1;
                    Console.Clear();
                    Console.WriteLine($"OPERAÇÂO: {value1}^{exponent}\n");
                    for(currentExponent = 1; currentExponent < exponent; currentExponent++){
                        Console.WriteLine($"{result} * {value1}");
                        result *= value1;
                        Console.WriteLine($"{result}\n");
                    }
                    Console.WriteLine("Pressione ENTER Para Continuar...");
                    Console.ReadKey();
                    Exec();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Opção Invalida... Desculpe-nos");
                    Thread.Sleep(2500);
                    Exec();
                }

            }
            else{
                Program.Main();
            }
        }

        public static void Calculator2(float result){
            Console.Clear();
            Console.WriteLine($"O Que Deseja Fazer Com: {result}\n");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Elevar\n");
            Console.WriteLine("0 - Voltar");

            option = Console.ReadLine();
            Console.Clear();
            if(option == "1"){
                Console.WriteLine($"Digite outro valor para SOMAR com {result}");
            }
            else if(option == "2"){
                Console.WriteLine($"Digite outro valor para SUBTRAIR com {result}");
            }
            else if(option == "3"){
                Console.WriteLine($"Digite outro valor para MULTPLICAR com {result}");
            }
            else if(option == "4"){
                Console.WriteLine($"Digite outro valor para DIVIDIR com {result}");
            }
            else if(option == "0"){
                Exec();
            }
            else{
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(3500);
                Calculator2(result);
            }
            value2 = float.Parse(Console.ReadLine());

            if (option == "1")
            {
                Console.Clear();
                result = result + value2;
                Continue(result);
            }
            else if (option == "2")
            {
                Console.Clear();
                result = result - value2;
                Continue(result);
            }
            else if (option == "3")
            {
                Console.Clear();
                result = result * value2;
                Continue(result);
            }
            else if (option == "4")
            {
                Console.Clear();
                result = result / value2;
                Continue(result);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Calculator2(result);
            }
        }

        public static void ContinueToCalculator2(float result){
            Console.WriteLine($"o seu resultado é de: {result}\nDeseja Fazer Mais Alguma Operação ?");
            Console.WriteLine("S - Sim\nN - não");
                
            option = Console.ReadLine();

            if(option == "s" | option == "S"){
                Calculator2(result);
            }
            else if(option == "n" | option == "N"){
                Exec();
            }
            else{
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Exec();
            }
        }

        public static void Continue(float result){
            Console.WriteLine($"o seu resultado é de: {result}\nDeseja Fazer Mais Alguma Operação ?");
            Console.WriteLine("S - Sim\nN - não");
                
            option = Console.ReadLine();

            if(option == "s" | option == "S"){
                Calculator2(result);
            }
            else if(option == "n" | option == "N"){
                Program.Main();
            }
            else{
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Continue(result);
            }
        }
    }
}