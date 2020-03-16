using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class MatrixCalculator {
        public static string option, exit;
        public static int currentExponent = 1, matrixResult;
        public static int value11, value12, value13;
        public static int value21, value22, value23;
        public static int value31, value32, value33; 
        public static void Exec()
        {
            Console.Clear();
            Console.WriteLine("Selecione o Tamanho da Matriz:\n");
            Console.WriteLine("1 - 2x2\n2 - 3x3\n\n0 - Voltar");
            option = Console.ReadLine();

            if (option == "1")
            {
                Matrix2x2();
            }
            else if (option == "2")
            {
                Matrix3x3();
            }
            else if (option == "0")
            {
                Program.Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Exec();
            }
        }

        public static void Matrix2x2()
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
            matrixResult = (value11 * value22) - (value12 * value21);
            RedirectToMatrix(matrixResult);
        }

        public static void Matrix3x3()
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
            matrixResult = ((value11 * value22 * value33) + (value12 * value23 * value31) + (value13 * value21 * value32)) - ((value13 * value22 * value31) + (value11 * value23 * value32) + (value12 * value21 * value33));
            RedirectToMatrix(matrixResult);
        }

        public static void RedirectToMatrix(float matrixResult){
            Console.WriteLine($"O Resultado é De: {matrixResult}\n"); //escreve no console o resultado da variavel matrixResult
            Console.WriteLine("Você Deseja Calcular Mais Alguma Matriz ?");
            Console.WriteLine("S - Sim\nN - Não\n");
            exit = Console.ReadLine();
            if (exit == "s" | exit == "S")
            {
                Exec();
            }
            //senao ele chama a funcao 
            else if(exit == "n" | exit == "N"){
                Program.Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Console.Clear();
                RedirectToMatrix(matrixResult);
            }
        }
    }
}