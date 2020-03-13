using System;
using System.Threading;

/// _____________________ ///
///                       ///
///  Writed by Murilo >.< ///
///  Writed by Fernando >.< ///
///  Writed by Bruno >.< ///
///                       ///
/// _____________________ ///

namespace CalculadoraDeMatrizes
{
    class Program
    {
        //variables \/
        #region Variables
        public static string exit, option, errorOption;
        public static int currentExponent = 1, matrixResult, exponent;
        public static int value11, value12, value13;
        public static int value21, value22, value23;
        public static int value31, value32, value33;

        public static float result, value1, value2,value3;
        public static double num1,num2,num3,result2,result3;
            //testando
        #endregion 
        //functions \/
        public static void Main(){
            Console.Clear();
            Console.WriteLine("Selecione o Que Deseja:");
            Console.WriteLine("1 - Calculadora\n2 - Calculadora De Matriz\n3 - Converter \n4 - Calculadora de juros simples e composto\n5 - Tabuada\n6 - Calculadora De Media\n7 - Calculadora De IMC\n8 - Calculadora De Area e Volume\n\n0 - Sair");
            option = Console.ReadLine();

            if (option == "1")
            {
                Calculator();
            }
            else if (option == "2")
            {
                Matrix();
            }
            else if (option == "3")
            {
                Converter();
            } 
            else if (option == "4")
            {
                Interest();
            }
            else if (option == "5")
            {
                MultiplicationTable();
            }
            else if (option == "6")
            {
                Average();
            }
            else if (option == "7")
            {
                IMC();
            }
            else if (option == "8")
            {
                Area();
            }
            else if (option == "0")
            {
                Exit();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Main();
            }
        }

        #region Calculator
        public static void Calculator(){
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
                    Calculator();
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
                    Calculator();
                }
                else if(exponent != 2){
                    result = value1;
                    Console.Clear();
                    Console.WriteLine($"OPERAÇÂO: {value1}^{exponent}\n");
                    for(currentExponent = 1; currentExponent < exponent; currentExponent++){
                        Console.WriteLine($"{result} * {value1}");
                        result = result * value1;
                        Console.WriteLine($"{result}\n");
                    }
                    Console.WriteLine("Pressione ENTER Para Continuar...");
                    Console.ReadKey();
                    Calculator();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Opção Invalida... Desculpe-nos");
                    Thread.Sleep(2500);
                    Calculator();
                }

            }
            else{
                Main();
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
                Calculator();
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
                Calculator();
            }
            else{
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Calculator();
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
                Main();
            }
            else{
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Continue(result);
            }
        }
        #endregion

        #region Matrix

        private static void Matrix()
        {
            Console.Clear();
            Console.WriteLine("Selecione o Tamanho da Matriz:");
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
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Matrix();
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
            exit = Console.ReadLine(); //atribui o caracter digitado a variavel exit
            //caso o caracter digitado for s ou S ele retorna a funcao main
            if (exit == "s" | exit == "S")
            {
                Matrix();
            }
            //senao ele chama a funcao 
            else if(exit == "n" | exit == "N"){
                Main();
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

        #endregion

        #region Simple Interest and Compound Interest
        //abaixo é uma
        public static void Interest()
        {
            Console.Clear();
            Console.WriteLine($"1 - Juros Simples\n2 - Juros compostos");

            option=Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.WriteLine("Digite o capital inicial : ");
                value1=float.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite a taxa: ");
                value2=float.Parse(Console.ReadLine());
                value2=value2/100;
                Console.Clear();
                Console.WriteLine("Digite o tempo em meses: ");
                value3=float.Parse(Console.ReadLine());
                result=value1*value2*value3+value1;
                Console.Clear();
                Console.WriteLine("O seu Resultado é de: {0:C2} , e seu capital inicial foi de: {1:C2}", result , value1);
            }
            else
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
                Console.WriteLine("O capital final é de: {0:C2}, e seu capital inicial foi de {1:C2}", result2, num1);
            }
        }  
        #endregion

        #region Converter
         public static void Converter()
        {
            Console.Clear();
            Console.WriteLine("Selecione qual o tipo de conversão você deseja fazer:\n");
            Console.WriteLine("1 - Temperatura");
            Console.WriteLine("2 - Distância");
            option = Console.ReadLine();

            if (option == "1"){
                Console.Clear();
                Console.WriteLine("Escolha a conversão a ser feita\n");
                Console.WriteLine("1 - Celsius -> Fahrenheit");
                Console.WriteLine("2 - Fahrenheit -> Celsius\n");
                Console.WriteLine("3 - Celsius -> Kelvin");
                Console.WriteLine("4 - Kelvin -> Celsius\n");
                Console.WriteLine("5 - Fahrenheit -> Kelvin");
                Console.WriteLine("6 - Kelvin -> Fahrenheit"); 
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
            }
            else if (option == "2"){
                Console.Clear();
                Console.WriteLine("Escolha a conversão a ser feita\n");
                //Continuar daqui -------------------------------------------------------------------------------------------------
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
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Converter outro valor");
            Console.WriteLine("2 - Sair");
            option = Console.ReadLine();
            if (option == "1"){
             Converter();
            }

        }
        public static void CF()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em Celsius(°C) a ser convertida");
            value1 = float.Parse(Console.ReadLine());
            result = (value1 * 1.8f) + 32;
            Console.Clear();
            Console.WriteLine(value1 + "°C são " +  result + "°F\n\n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Converter outro valor");
            Console.WriteLine("2 - Sair");
            option = Console.ReadLine();
            if (option == "1"){
             Converter();
            }
            
        }

        public static void CK()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em Celsius(°C) a ser convertida");
            value1 = float.Parse(Console.ReadLine());
            result = value1 + 273;
            Console.WriteLine(value1 + "°C são " +  result + "K\n\n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Converter outro valor");
            Console.WriteLine("2 - Sair");
            option = Console.ReadLine();
            if (option == "1"){
             Converter();
            }
        }

        public static void KC()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em Kelvin(K) a ser convertida");
            value1 = float.Parse(Console.ReadLine());
            result = value1 - 273.15f;
            Console.WriteLine(value1 + "K são " +  result + "°C\n\n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Converter outro valor");
            Console.WriteLine("2 - Sair");
            option = Console.ReadLine();
            if (option == "1"){
             Converter();
            }
        }
        
        public static void FK()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em Fahrenheit(°F) a ser convertida");
            value1 = float.Parse(Console.ReadLine());
            result = (value1 - 32)/ 1.8f + (273.15f); 
            Console.Clear();
            Console.WriteLine(value1 + "°F são " + result + "K\n\n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Converter outro valor");
            Console.WriteLine("2 - Sair");
            option = Console.ReadLine();
            if (option == "1"){
             Converter();
            }
        }

        public static void KF()
        {
            Console.Clear();
            Console.WriteLine("Digite a temperatura em Kelvin(K) a ser convertida");
            value1 = float.Parse(Console.ReadLine());
            result = (value1 - 273.15f)* 1.8f + (32);
            Console.WriteLine(value1 + "K são " +  result + "°F\n\n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Converter outro valor");
            Console.WriteLine("2 - Sair");
            option = Console.ReadLine();
            if (option == "1"){
             Converter();
            }
        }

        #endregion

        #region MultiplicationTable
        public static void MultiplicationTable(){
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
            Main();
        }
        #endregion

        #region Average
        public static void Average(){

        }
        #endregion

        #region IMC
        public static void IMC(){

        }
        #endregion

        #region Area
        public static void Area(){

        }
        #endregion

        public static void Exit() //funcao exit
        {
            Console.Clear();
            Console.WriteLine("Exiting The Program.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Exiting The Program..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Exiting The Program...");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Exiting The Program....");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Exiting The Program.....");
            Thread.Sleep(800);
            Console.Clear();
            System.Environment.Exit(1); //sai do programa
        }
    }
}