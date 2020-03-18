using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedCalculator {
    public class MainMenu {
        Dictionary<string, Action> Funcs;

        public MainMenu(Dictionary<string, Action> hotfunc) {
            Funcs = hotfunc; 
        }

        public void SelecionarEExecutar() {
            int i = 1;

            Console.Clear();

            Console.WriteLine("Selecione Uma Opção:\n");

            foreach (var function in Funcs) {
                Console.WriteLine("{0} - {1}", i, function.Key);
                i++;
            }

            Console.WriteLine("\n0 - Sair\n");

            bool succes = int.TryParse(Console.ReadLine(), out int num);
            if(!succes){
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Program.Main();
            }

            if(num == 0)
                Exit();

            bool numValido = num > 0 && num <= Funcs.Count;
            num = numValido ? num - 1 : Funcs.Count - 1;
            

            if(!numValido){
                Console.Clear();
                Console.WriteLine("Opção Invalida... Desculpe-nos");
                Thread.Sleep(2500);
                Program.Main();
            }

            string nameOfFunc = Funcs.ElementAt(num).Key;


            Action executar = Funcs.ElementAt(num).Value;
            try {
                executar();
            } catch(Exception e) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
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