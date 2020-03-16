using System;
using System.Collections.Generic;

using AdvancedCalculator.Functions;

namespace AdvancedCalculator {
    public class Program {
        public static void Main() {
            var menu = new MainMenu(new Dictionary<string, Action>() {
                // Fundamentos
                {"Calculator", Calculator.Exec},
                {"BMI Calculator", BMICalculator.Exec},
                {"Average Calculator", AverageCalculator.Exec},
                {"Matrix Calculator", MatrixCalculator.Exec},
                {"Area Calculator", AreaCalculator.Exec},
                {"Interest Calculator", InterestCalculator.Exec},
                {"Converter", Converter.Exec},
                {"Multiplication Table", MultiplicationTable.Exec},
            });

            menu.SelecionarEExecutar();
        }
    }
}