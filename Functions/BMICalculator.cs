using System;
using System.Threading;


namespace AdvancedCalculator.Functions {
    class BMICalculator {
        public static void Exec()
        {
            double weight, height,imc;

            Console.Clear();

            Console.WriteLine("Cálculadora de Índice de Massa Corporal\n");
            Console.WriteLine("Digite seu peso em Kg: (0 - Voltar)");
            weight = double.Parse(Console.ReadLine());

            if(weight == 0){
                Program.Main();
            }

            Console.Clear();

            Console.WriteLine("Digite a sua altura em metros\n(Exemplo: 1,70)\n");
            height = double.Parse(Console.ReadLine());

            imc = weight/(height*height);

            Console.Clear();

            if (imc <= 18.5 & imc > 15){
                Console.WriteLine("Seu IMC é de {0:N2}\nVocê está abaixo do peso ideal\n",imc);
                ReturnIMC();
            }
            else if (imc>=18.6 & imc<=24.9){
                Console.WriteLine("Seu IMC é de {0:N2}\nVocê está no peso ideal\n",imc);
                ReturnIMC();
            }
            else if (imc>=25 & imc<=29.9){
                Console.WriteLine("Seu IMC é de {0:N2}\nVocê está acima do peso ideal\n",imc);
                ReturnIMC();
            }
            else if (imc>=30 & imc <=34.9){
                Console.WriteLine("Seu IMC é de {0:N2}\nVocê está em obesidade grau 1\n",imc);
                ReturnIMC();
            }
            else if (imc>=35 & imc<=39.9){
                Console.WriteLine("Seu IMC é de {0:N2}\nVocê está em obesidade grau 2\n",imc);
                ReturnIMC();
            }
            else if (imc>=40){
                Console.WriteLine("Seu IMC é de {0:N2}\nVocê está em obesidade grau 3 (Obesidade mórbida)\n",imc);
                ReturnIMC();
            }
            else{
                Console.WriteLine("Erro!");
                Thread.Sleep(2000);
                Exec();
            }
        }

        public static void ReturnIMC(){
            Console.WriteLine("Press ENTER To Continue...");
            Console.ReadKey();
            Exec();
        }
    }
}