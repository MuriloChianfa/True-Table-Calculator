using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.NumericFunction {
    class NumericExpressionCalculator {
        public static bool success;
        public static int amount, operators, lengthExpression, lengthExpression2, condition1value, condition2value;
        public static string condition1, condition2, stringOperators;
        public static void Exec(){
            Console.Clear();

            Console.WriteLine("How many Variables will you use ?");
            Console.WriteLine("\n2 -  2 Variables (4 Possibilities)\n3 -  3 Variables (8 Possibilities)\n4 -  4 Variables (16 Possibilities)\n\n0 -  Return\n");
            success = int.TryParse(Console.ReadLine(), out amount);

            if(success){

            
                #region twoVariables
                if(amount == 2){

                    NumericTable.ShowTable2();

                    Console.WriteLine("Enter The 1st Variable:");
                    Console.WriteLine("A, B, !A, !B\n");
                    condition1 = Console.ReadLine();

                    int[] possibility1 = new int[4];
                    if(condition1 == "a" | condition1 == "A"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = NumericTable.A2[i];
                        }
                    }
                    else if(condition1 == "b" | condition1 == "B"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = NumericTable.B2[i];
                        }
                    }
                    else if(condition1 == "!A" | condition1 == "!a"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = NumericTable.nA2[i];
                        }
                    }
                    else if(condition1 == "!b" | condition1 == "!B"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = NumericTable.nB2[i];
                        }
                    }
                    else{
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option....");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        Exec();
                    }

                    Console.Clear();
                    Console.WriteLine("Whatch Operator Will You Use ?");
                    Console.WriteLine("1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR\n\n");
                    success = int.TryParse(Console.ReadLine(), out operators);
                    
                    if(success & operators != 1){

                        NumericTable.ShowTable2();

                        Console.WriteLine("Enter The 2nd Variable:");
                        Console.WriteLine("A, B, !A, !B\n");
                        condition2 = Console.ReadLine();

                        int[] possibility2 = new int[4];
                        if(condition2 == "a" | condition2 == "A"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = NumericTable.A2[i];
                            }
                        }
                        else if(condition2 == "b" | condition2 == "B"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = NumericTable.B2[i];
                            }
                        }
                        else if(condition2 == "!a" | condition2 == "!A"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = NumericTable.nA2[i];
                            }
                        }
                        else if(condition2 == "!b" | condition2 == "!B"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = NumericTable.nB2[i];
                            }
                        }
                        else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option....");
                            Thread.Sleep(1500);
                            Console.ResetColor();
                            Exec();
                        }  

                        //-----------Calculation---------------

                        //1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR

                        int[] result1Return = new int[4];
                        if(operators == 2){
                            stringOperators = ".";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = NumericOperations.and(condition1value, condition2value);
                            }
                        }
                        else if(operators == 3){
                            stringOperators = "_._";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = NumericOperations.nand(condition1value, condition2value);
                            }
                        }
                        else if(operators == 4){
                            stringOperators = "+";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = NumericOperations.or(condition1value, condition2value);
                            }
                        }
                        else if(operators == 5){
                            stringOperators = "_+_";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = NumericOperations.nor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 6){
                            stringOperators = "++";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = NumericOperations.xor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 7){
                            stringOperators = "_++_";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = NumericOperations.xnor(condition1value, condition2value);
                            }
                        }
                        else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option....");
                            Thread.Sleep(1500);
                            Console.ResetColor();
                            Exec();
                        }
                        
                        //-----------Show Result of Calcule-----------

                        Console.Clear();
                        Console.WriteLine("+------+ +------+  +--------+");
                        Console.WriteLine($"¦   {condition1}  ¦ ¦   {condition2}  ¦  ¦  {condition1} {stringOperators} {condition2} ¦");
                        Console.WriteLine("+------+ +------+  +--------+");
                        Console.WriteLine("+------+ +------+  +--------+");
                        for(int i = 0; i < result1Return.Length; i++)
                        {
                            Console.WriteLine("¦   {0}  ¦ ¦   {1}  ¦  ¦    " + result1Return[i] + "   ¦", possibility1[i], possibility2[i]);
                        }
                        Console.WriteLine("+------+ +------+  +--------+\n");

                        Console.WriteLine("Press ENTER to Continue...");
                        Console.ReadKey();
                        Exec();
                    }
                    else if(success & operators == 1){
                        stringOperators = ">";
                        int[] result1Return = new int[4];
                        for(int i = 0, j = 0, k = 0; i < NumericTable.A2.Length; i++, j++, k++) 
                        {
                            condition1value = possibility1[i];
                            result1Return[k] = NumericOperations.and(condition1value, condition2value);
                        }
                    }
                    else{
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please... Enter With A Valid Number.");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        Exec();
                    }
                }
                #endregion
                #region ThreeVariables
                else if(amount == 3){

                    NumericTable.ShowTable3();

                    Console.WriteLine("Enter The 1st Variable:");
                    Console.WriteLine("A, B, C, !A, !B, !C\n");
                    condition1 = Console.ReadLine();

                    int[] possibility1 = new int[8];
                    if(condition1 == "a" | condition1 == "A"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = NumericTable.A3[i];
                        }
                    }
                    else if(condition1 == "b" | condition1 == "B"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = NumericTable.B3[i];
                        }
                    }
                    else if(condition1 == "C" | condition1 == "c"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = NumericTable.C3[i];
                        }
                    }
                    else if(condition1 == "!a" | condition1 == "!A"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = NumericTable.nA3[i];
                        }
                    }
                    else if(condition1 == "!b" | condition1 == "!B"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = NumericTable.nB3[i];
                        }
                    }
                    else if(condition1 == "!c" | condition1 == "!C"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = NumericTable.nC3[i];
                        }
                    }
                    else{
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option....");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        Exec();
                    }

                    Console.Clear();
                    Console.WriteLine("Whatch Operator Will You Use ?");
                    Console.WriteLine("1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR\n\n");
                    success = int.TryParse(Console.ReadLine(), out operators);
                    
                    if(success & operators != 1){
                    
                        NumericTable.ShowTable3();

                        Console.WriteLine("Enter The 2nd Variable:");
                        Console.WriteLine("A, B, C, !A, !B, !C\n");
                        condition2 = Console.ReadLine();

                        int[] possibility2 = new int[8];
                        if(condition2 == "a" | condition2 == "A"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = NumericTable.A3[i];
                            }
                        }
                        else if(condition2 == "b" | condition2 == "B"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = NumericTable.B3[i];
                            }
                        }
                        else if(condition2 == "c" | condition2 == "C"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = NumericTable.C3[i];
                            }
                        }
                        else if(condition2 == "!a" | condition2 == "!A"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = NumericTable.nA3[i];
                            }
                        }
                        else if(condition2 == "!b" | condition2 == "!B"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = NumericTable.nB3[i];
                            }
                        }
                        else if(condition2 == "!c" | condition2 == "!C"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = NumericTable.nC3[i];
                            }
                        }
                        else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option....");
                            Thread.Sleep(1500);
                            Console.ResetColor();
                            Exec();
                        }  

                        //-----------Calculation---------------

                        //1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR

                        if(operators == 2){
                            stringOperators = ".";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result3Return[k] = NumericOperations.and(condition1value, condition2value);
                            }
                        }
                        else if(operators == 3){
                            stringOperators = "_._";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result3Return[k] = NumericOperations.nand(condition1value, condition2value);
                            }
                        }
                        else if(operators == 4){
                            stringOperators = "+";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result3Return[k] = NumericOperations.or(condition1value, condition2value);
                            }
                        }
                        else if(operators == 5){
                            stringOperators = "_+_";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result3Return[k] = NumericOperations.nor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 6){
                            stringOperators = "++";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result3Return[k] = NumericOperations.xor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 7){
                            stringOperators = "_++_";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result3Return[k] = NumericOperations.xnor(condition1value, condition2value);
                            }
                        }
                        else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option....");
                            Thread.Sleep(1500);
                            Console.ResetColor();
                            Exec();
                        }
                        
                        //-----------Show Result of Calcule-----------

                        string currentExpression = "(" + condition1 + " " + stringOperators + " " + condition2+ ")";
                        
                        lengthExpression = currentExpression.Length;

                        Console.Clear();

                        PrintPl(lengthExpression);
                        Console.WriteLine($"¦   {condition1}  ¦ ¦   {condition2}  ¦ ¦  {currentExpression} ¦");
                        PrintPl(lengthExpression);
                        PrintPl(lengthExpression);
                        for(int i = 0; i < NumericTable.result3Return.Length; i++)
                        {
                            if(condition1.Length == 2)
                                Console.Write("¦    {0}  ¦ ", possibility1[i]);
                            else
                                Console.Write("¦   {0}  ¦ ", possibility1[i]);
                                
                            if(condition2.Length == 2)
                                Console.Write("¦    {0}  ¦ ", possibility2[i]);
                            else
                                Console.Write("¦   {0}  ¦ ", possibility2[i]);

                            Console.Write("¦  ");
                            for (int j = 5; j < lengthExpression; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine("{0}     ¦", NumericTable.result3Return[i]);
                        }
                        PrintPl(lengthExpression);

                        Console.WriteLine("Press ENTER to Continue...");
                        Console.ReadKey();
                        ContinueExpression(currentExpression);
                    }
                    else if(success & operators == 1){
                        string currentExpression = "?";
                        if(condition1 == "!a" | condition1 == "!A")
                            currentExpression = "A";
                        else if(condition1 == "a" | condition1 == "A")
                            currentExpression = "!A";
                        if(condition1 == "!b" | condition1 == "!B")
                            currentExpression = "B";
                        else if(condition1 == "b" | condition1 == "B")
                            currentExpression = "!B";
                        if(condition1 == "!c" | condition1 == "!c")
                            currentExpression = "C";
                        else if(condition1 == "c" | condition1 == "c")
                            currentExpression = "!C";
                        
                        for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                        {
                            condition1value = possibility1[i];
                            NumericTable.result3Return[k] = NumericOperations.not(condition1value);
                        }
                        
                        lengthExpression = currentExpression.Length + 1;

                        Console.Clear();

                        PrintNot(lengthExpression);
                        Console.WriteLine($"¦   {condition1}  ¦ ¦  {currentExpression}  ¦");
                        PrintNot(lengthExpression);
                        PrintNot(lengthExpression);
                        for(int i = 0; i < NumericTable.result3Return.Length; i++)
                        {
                            if(condition1.Length == 2)
                                Console.Write("¦    {0}  ¦ ", possibility1[i]);
                            else
                                Console.Write("¦   {0}  ¦ ", possibility1[i]);

                            Console.Write("¦ ");
                            for (int j = 0; j < lengthExpression; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine("{0} ¦", NumericTable.result3Return[i]);
                        }
                        PrintNot(lengthExpression);

                        Console.WriteLine("Press ENTER to Continue...");
                        Console.ReadKey();
                        ContinueExpression(currentExpression);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please... Enter With A Valid Number.");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        Exec();
                    }
                }
                #endregion
                #region FourVariables
                else if(amount == 4){

                    NumericTable.ShowTable4();

                    Console.WriteLine("Enter The 1st Variable:");
                    Console.WriteLine("A, B, C, D, !A, !B, !C, !D,\n");
                    condition1 = Console.ReadLine();

                    int[] possibility1 = new int[16];
                    if(condition1 == "a" | condition1 == "A"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.A4[i];
                        }
                    }
                    else if(condition1 == "b" | condition1 == "B"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.B4[i];
                        }
                    }
                    else if(condition1 == "C" | condition1 == "c"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.C4[i];
                        }
                    }
                    else if(condition1 == "d" | condition1 == "D"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.D4[i];
                        }
                    }
                    else if(condition1 == "!a" | condition1 == "!A"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.nA4[i];
                        }
                    }
                    else if(condition1 == "!b" | condition1 == "!B"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.nB4[i];
                        }
                    }
                    else if(condition1 == "!c" | condition1 == "!C"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.nC4[i];
                        }
                    }
                    else if(condition1 == "!d" | condition1 == "!D"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = NumericTable.nD4[i];
                        }
                    }
                    else{
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option....");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        Exec();
                    }

                    Console.Clear();
                    Console.WriteLine("Whatch Operator Will You Use ?");
                    Console.WriteLine("1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR\n\n");
                    success = int.TryParse(Console.ReadLine(), out operators);
                    
                    if(success & operators != 1){
                    
                        NumericTable.ShowTable4();

                        Console.WriteLine("Enter The 2nd Variable:");
                        Console.WriteLine("A, B, C, D, !A, !B, !C, !D,\n");
                        condition2 = Console.ReadLine();

                        int[] possibility2 = new int[16];
                        if(condition2 == "a" | condition2 == "A"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.A4[i];
                            }
                        }
                        else if(condition2 == "b" | condition2 == "B"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.B4[i];
                            }
                        }
                        else if(condition2 == "c" | condition2 == "C"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.C4[i];
                            }
                        }
                        else if(condition2 == "d" | condition2 == "D"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.D4[i];
                            }
                        }
                        else if(condition2 == "!a" | condition2 == "!A"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.nA4[i];
                            }
                        }
                        else if(condition2 == "!b" | condition2 == "!B"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.nB4[i];
                            }
                        }
                        else if(condition2 == "!c" | condition2 == "!C"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.nC4[i];
                            }
                        }
                        else if(condition2 == "!d" | condition2 == "!D"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = NumericTable.nD4[i];
                            }
                        }
                        else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option....");
                            Thread.Sleep(1500);
                            Console.ResetColor();
                            Exec();
                        }  

                        //-----------Calculation---------------

                        //1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR

                        
                        if(operators == 2){
                            stringOperators = ".";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result4Return[k] = NumericOperations.and(condition1value, condition2value);
                            }
                        }
                        else if(operators == 3){
                            stringOperators = "_._";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result4Return[k] = NumericOperations.nand(condition1value, condition2value);
                            }
                        }
                        else if(operators == 4){
                            stringOperators = "+";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result4Return[k] = NumericOperations.or(condition1value, condition2value);
                            }
                        }
                        else if(operators == 5){
                            stringOperators = "_+_";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result4Return[k] = NumericOperations.nor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 6){
                            stringOperators = "++";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result4Return[k] = NumericOperations.xor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 7){
                            stringOperators = "_++_";
                            for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                NumericTable.result4Return[k] = NumericOperations.xnor(condition1value, condition2value);
                            }
                        }
                        else{
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option....");
                            Thread.Sleep(1500);
                            Console.ResetColor();
                            Exec();
                        }
                        
                        //-----------Show Result of Calcule-----------

                        string currentExpression = "(" + condition1 + " " + stringOperators + " " + condition2+ ")";
                        
                        lengthExpression = currentExpression.Length;

                        Console.Clear();

                        PrintPl(lengthExpression);
                        Console.WriteLine($"¦   {condition1}  ¦ ¦   {condition2}  ¦ ¦  {currentExpression} ¦");
                        PrintPl(lengthExpression);
                        PrintPl(lengthExpression);
                        for(int i = 0; i < NumericTable.result4Return.Length; i++)
                        {
                            if(condition1.Length == 2)
                                Console.Write("¦    {0}  ¦ ", possibility1[i]);
                            else
                                Console.Write("¦   {0}  ¦ ", possibility1[i]);
                                
                            if(condition2.Length == 2)
                                Console.Write("¦    {0}  ¦ ", possibility2[i]);
                            else
                                Console.Write("¦   {0}  ¦ ", possibility2[i]);

                            Console.Write("¦  ");
                            for (int j = 5; j < lengthExpression; j++)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine("{0}     ¦", NumericTable.result4Return[i]);
                        }
                        PrintPl(lengthExpression);

                        Console.WriteLine("Press ENTER to Continue...");
                        Console.ReadKey();
                        ContinueFourExpression(currentExpression);
                    }
                    else if(success & operators == 1){
                        stringOperators = ">";
                        for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                        {
                            condition1value = possibility1[i];
                            NumericTable.result4Return[k] = NumericOperations.not(condition1value);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please... Enter With A Valid Number.");
                        Thread.Sleep(2000);
                        Console.ResetColor();
                        Exec();
                    }
                }
                #endregion
                else if(amount == 0){
                    NumericMenu.Exec();
                }
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option....");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Exec();
                }
            }else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please... Enter With A Valid Number.");
                Thread.Sleep(2000);
                Console.ResetColor();
                Exec();
            }
        }

        public static void PrintPl(int lengthExpression){
            if(condition1.Length == 2)
                Console.Write("+-------+");
            else
                Console.Write("+------+");

            Console.Write(" ");

            if(condition2.Length == 2)
                Console.Write("+-------+");
            else
                Console.Write("+------+");

            Console.Write(" ");

            Console.Write("+");
            for (int i = -3; i < lengthExpression; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public static void PrintNot(int lengthExpression){
            if(condition1.Length == 2)
                Console.Write("+-------+");
            else
                Console.Write("+------+");

            Console.Write(" ");

            Console.Write("+");
            for (int i = -3; i < lengthExpression; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        #region ContinueThreeExpressions
        public static void ContinueExpression(string currentExpression){
            int[] possibility1 = new int[8];
            for(int i = 0; i < 8; i++){
                possibility1[i] = NumericTable.result3Return[i];
            }
            
            Console.Clear();
            Console.WriteLine("Whatch Operator Will You Use ?");
            Console.WriteLine("1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR\n0 - Return\n\n");
            success = int.TryParse(Console.ReadLine(), out operators);

            if(operators == 0){
                NumericMenu.Exec();
            }

            Console.Clear();
            
            NumericTable.ShowTable3();

            Console.WriteLine("Enter The Other Variable:");
            Console.WriteLine("A, B, C, !A, !B, !C\n");
            condition2 = Console.ReadLine();

            int[] possibility2 = new int[8];
            if(condition2 == "p"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = NumericTable.A3[i];
                }
            }
            else if(condition2 == "b" | condition2 == "B"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = NumericTable.B3[i];
                }
            }
            else if(condition2 == "c" | condition2 == "C"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = NumericTable.C3[i];
                }
            }
            else if(condition2 == "!a" | condition2 == "!A"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = NumericTable.nA3[i];
                }
            }
            else if(condition2 == "!b" | condition2 == "!B"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = NumericTable.nB3[i];
                }
            }
            else if(condition2 == "!c" | condition2 == "!C"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = NumericTable.nC3[i];
                }
            }
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option....");
                Thread.Sleep(1500);
                Console.ResetColor();
                Exec();
            }

            if(success){

                //-----------Calculation---------------

                if(operators == 2){
                    stringOperators = ".";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result3Return[k] = NumericOperations.and(condition1value, condition2value);
                    }
                }
                else if(operators == 3){
                    stringOperators = "_._";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result3Return[k] = NumericOperations.nand(condition1value, condition2value);
                    }
                }
                else if(operators == 4){
                    stringOperators = "+";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result3Return[k] = NumericOperations.or(condition1value, condition2value);
                    }
                }
                else if(operators == 5){
                    stringOperators = "_+_";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result3Return[k] = NumericOperations.nor(condition1value, condition2value);
                    }
                }
                else if(operators == 6){
                    stringOperators = "++";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result3Return[k] = NumericOperations.xor(condition1value, condition2value);
                    }
                }
                else if(operators == 7){
                    stringOperators = "_++_";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result3Return[k] = NumericOperations.xnor(condition1value, condition2value);
                    }
                }
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option....");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Exec();
                }
                
                //-----------Show Result of Calcule-----------

                string currentExpression2 = "(" + currentExpression + " " + stringOperators + " " + condition2+ ")";

                lengthExpression = currentExpression.Length;
                lengthExpression2 = currentExpression2.Length;

                Console.Clear();
                PrintComPL(lengthExpression, lengthExpression2);
                Console.WriteLine($"¦   {currentExpression}  ¦ ¦   {condition2}  ¦ ¦ {currentExpression2} ¦");
                PrintComPL(lengthExpression, lengthExpression2);
                PrintComPL(lengthExpression, lengthExpression2);
                for(int i = 0; i < NumericTable.result3Return.Length; i++)
                {
                    Console.Write("¦  ");
                    for (int j = 3; j < lengthExpression; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("{0}     ¦ ", possibility1[i]);

                    //----------------------------
                        
                    if(condition2.Length == 2)
                        Console.Write("¦    {0}  ¦ ", possibility2[i]);
                    else
                        Console.Write("¦   {0}  ¦ ", possibility2[i]);

                    //--------------------------

                    Console.Write("¦       {0}", NumericTable.result3Return[i]);
                    for (int j = 6; j < lengthExpression2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("¦");
                }
                PrintComPL(lengthExpression, lengthExpression2);

                Console.WriteLine("\nPress ENTER to Continue...");
                Console.ReadKey();
                ContinueExpression(currentExpression2);
            }
        }
        public static void PrintComPL(int lengthExpression, int lengthExpression2){
            Console.Write("+");
            for (int i = -5; i < lengthExpression; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            Console.Write(" ");

            if(condition2.Length == 2)
                Console.Write("+-------+");
            else
                Console.Write("+------+");

            Console.Write(" ");

            Console.Write("+");
            for (int i = -2; i < lengthExpression2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
        #endregion
        #region ContinueFourExpressions
        public static void ContinueFourExpression(string currentExpression){
            int[] possibility1 = new int[16];
            for(int i = 0; i < 16; i++){
                possibility1[i] = NumericTable.result4Return[i];
            }
            
            Console.Clear();
            Console.WriteLine("Whatch Operator Will You Use ?");
            Console.WriteLine("1 - NOT\n2 - AND\n3 - NAND\n4 - OR\n5 - NOR\n6 - XOR\n7 - XNOR\n0 - Return\n\n");
            success = int.TryParse(Console.ReadLine(), out operators);

            if(operators == 0){
                NumericMenu.Exec();
            }

            Console.Clear();
            
            NumericTable.ShowTable4();

            Console.WriteLine("Enter The Other Variable:");
            Console.WriteLine("A, B, C, D, !A, !B, !C, !D\n");
            condition2 = Console.ReadLine();

            int[] possibility2 = new int[16];
            if(condition2 == "p"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.A4[i];
                }
            }
            else if(condition2 == "b" | condition2 == "B"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.B4[i];
                }
            }
            else if(condition2 == "c" | condition2 == "C"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.C4[i];
                }
            }
            else if(condition2 == "d" | condition2 == "D"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.D4[i];
                }
            }
            else if(condition2 == "!a" | condition2 == "!A"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.nA4[i];
                }
            }
            else if(condition2 == "!b" | condition2 == "!B"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.nB4[i];
                }
            }
            else if(condition2 == "!c" | condition2 == "!C"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.nC4[i];
                }
            }
            else if(condition2 == "!d" | condition2 == "!D"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = NumericTable.nD4[i];
                }
            }
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option....");
                Thread.Sleep(1500);
                Console.ResetColor();
                Exec();
            }

            if(success){

                //-----------Calculation---------------

                if(operators == 2){
                    stringOperators = ".";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result4Return[k] = NumericOperations.and(condition1value, condition2value);
                    }
                }
                else if(operators == 3){
                    stringOperators = "_._";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result4Return[k] = NumericOperations.nand(condition1value, condition2value);
                    }
                }
                else if(operators == 4){
                    stringOperators = "+";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result4Return[k] = NumericOperations.or(condition1value, condition2value);
                    }
                }
                else if(operators == 5){
                    stringOperators = "_+_";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result4Return[k] = NumericOperations.nor(condition1value, condition2value);
                    }
                }
                else if(operators == 6){
                    stringOperators = "++";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result4Return[k] = NumericOperations.xor(condition1value, condition2value);
                    }
                }
                else if(operators == 7){
                    stringOperators = "_++_";
                    for(int i = 0, j = 0, k = 0; i < NumericTable.A4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        NumericTable.result4Return[k] = NumericOperations.xnor(condition1value, condition2value);
                    }
                }
                else{
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option....");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Exec();
                }
                
                //-----------Show Result of Calcule-----------

                string currentExpression2 = "(" + currentExpression + " " + stringOperators + " " + condition2+ ")";

                lengthExpression = currentExpression.Length;
                lengthExpression2 = currentExpression2.Length;

                Console.Clear();
                PrintComPL(lengthExpression, lengthExpression2);
                Console.WriteLine($"¦   {currentExpression}  ¦ ¦   {condition2}  ¦ ¦ {currentExpression2} ¦");
                PrintComPL(lengthExpression, lengthExpression2);
                PrintComPL(lengthExpression, lengthExpression2);
                for(int i = 0; i < NumericTable.result4Return.Length; i++)
                {
                    Console.Write("¦  ");
                    for (int j = 3; j < lengthExpression; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("{0}     ¦ ", possibility1[i]);

                    //----------------------------
                        
                    if(condition2.Length == 2)
                        Console.Write("¦    {0}  ¦ ", possibility2[i]);
                    else
                        Console.Write("¦   {0}  ¦ ", possibility2[i]);

                    //--------------------------

                    Console.Write("¦       {0}", NumericTable.result4Return[i]);
                    for (int j = 6; j < lengthExpression2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("¦");
                }
                PrintComPL(lengthExpression, lengthExpression2);

                Console.WriteLine("\nPress ENTER to Continue...");
                Console.ReadKey();
                ContinueFourExpression(currentExpression2);
            }
        }
        #endregion
    }
}