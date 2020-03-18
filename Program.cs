using System;
using System.Collections.Generic;

using AdvancedCalculator.Functions;
using AdvancedCalculator.TrueTable;

namespace AdvancedCalculator {
    public class Program {
        public static void Main() {
            var menu = new MainMenu(new Dictionary<string, Action>() {
                {"Calculator", Calculator.Exec},
                {"BMI Calculator", BMICalculator.Exec},
                {"Average Calculator", AverageCalculator.Exec},
                {"Matrix Calculator", MatrixCalculator.Exec},
                {"Area Calculator", AreaCalculator.Exec},
                {"Interest Calculator", InterestCalculator.Exec},
                {"Converter", Converter.Exec},
                {"Multiplication Table", MultiplicationTable.Exec},
                {"TrueTable", TrueTableMenu.Exec},
            });

            menu.SelecionarEExecutar();
        }
    }
}