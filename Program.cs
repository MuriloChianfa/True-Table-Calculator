using System;



/// _____________________ ///
///                       ///
///  Writed by Murilo >.< ///
///                       ///
/// _____________________ ///



namespace CalculadoraDeMatrizes
{
    class Program
    {
        //variaveis \/

        public static string exit;
        public static int option, result;
        public static int value11, value12, value13;
        public static int value21, value22, value23;
        public static int value31, value32, value33;

        //funcoes \/
        private static void Main()
        {
            Console.Clear();
            Console.WriteLine("░░░░░▒▒▒▒▒▒▒▓▓▓ Writed by Murilo >.< ▓▓▓▒▒▒▒▒▒▒░░░░░\n");
            Console.WriteLine("Selecione o Tamanho da Matriz:");
            Console.WriteLine("1 - 2x2\n2 - 3x3\n\n0 - Sair");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Matriz2x2();
            }
            else if (option == 2)
            {
                Matriz3x3();
            }
            else if (option == 0)
            {
                Exit();
            }
            else
            {
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Main();
            }
        }

        public static void Matriz2x2()
        {
            Console.Clear();
            Console.WriteLine("A11");
            value11 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A12");
            value12 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A21");
            value21 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A22");
            value22 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{value11} {value12}\n{value21} {value22}\n");
            Console.WriteLine($"({(value11 * value22)})  -  ({(value12 * value21)})\n");
            result = (value11 * value22) - (value12 * value21);
            RedirectToMain(result);
        }

        public static void Matriz3x3()
        {
            Console.Clear();
            Console.WriteLine("A11");
            value11 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A12");
            value12 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A13");
            value13 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A21");
            value21 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A22");
            value22 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A23");
            value23 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A31");
            value31 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A32");
            value32 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("A33");
            value33 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"{value11} {value12} {value13} | {value11} {value12}\n{value21} {value22} {value23} | {value21} {value22}\n{value31} {value32} {value33} | {value31} {value32}\n");
            Console.WriteLine($"({-1* value13 * value22 * value31} {-1 *value11 * value23 * value32} {-1 *value12 * value21 * value33})  +  ({value11 * value22 * value33} {value12 * value23 * value31} {value13 * value21 * value32})\n");
            Console.WriteLine($"{(-1 * value13 * value22 * value31) + (-1 * value11 * value23 * value32) + (-1 * value12 * value21 * value33)} + {(value11 * value22 * value33) + (value12 * value23 * value31) + (value13 * value21 * value32)}\n");
            result = ((value11 * value22 * value33) + (value12 * value23 * value31) + (value13 * value21 * value32)) - ((value13 * value22 * value31) + (value11 * value23 * value32) + (value12 * value21 * value33));
            RedirectToMain(result);
        }

        public static void RedirectToMain(float result){
            Console.WriteLine($"O Resultado é de: {result}\n"); //escreve no console o resultado da variavel result
            Console.WriteLine("Você deseja ir ao menu ?");
            Console.WriteLine("S - Sim\nN - Não\n");
            exit = Console.ReadLine(); //atribui o caracter digitado a variavel exit
            //caso o caracter digitado for s ou S ele retorna a funcao main
            if (exit == "s" | exit == "S")
            {
                Main();
            }
            //senao ele chama a funcao exit
            else
            {
                Exit();
            }
        }

        private static void Exit() //funcao exit
        {
            Console.Clear(); //limpa o console
            System.Environment.Exit(1); //sai do programa
        }
    }
}