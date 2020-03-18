using System;
using System.Threading;

namespace AdvancedCalculator.TrueTable.LogicalFunction {
    class LogicalExpressionCalculator {
        public static bool success;
        public static int amount, operators, lengthExpression, lengthExpression2;
        public static string condition1, condition2, stringOperators, condition1value, condition2value;
        public static void Exec(){
            Console.Clear();

            Console.WriteLine("How Many Propositions Will You Use ?");
            Console.WriteLine("\n2 -  2 Propositions (4 Possibilities)\n3 -  3 Propositions (8 Possibilities)\n4 -  4 Propositions (16 Possibilities)\n\n0 -  Return\n");
            success = int.TryParse(Console.ReadLine(), out amount);

            if(success){

            
                #region twoPropositions
                if(amount == 2){

                    LogicalTable.ShowTable2();

                    Console.WriteLine("Enter The 1st Proposition:");
                    Console.WriteLine("p, q, ~p, ~q\n");
                    condition1 = Console.ReadLine();

                    string[] possibility1 = new string[4];
                    if(condition1 == "p"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = LogicalTable.p2[i];
                        }
                    }
                    else if(condition1 == "q"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = LogicalTable.q2[i];
                        }
                    }
                    else if(condition1 == "~p"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = LogicalTable.np2[i];
                        }
                    }
                    else if(condition1 == "~q"){
                        for(int i = 0; i < 4; i++){
                            possibility1[i] = LogicalTable.nq2[i];
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
                    Console.WriteLine("1 - ^\n2 - v\n3 - v_\n4 - ->\n5 - <->\n\n");
                    success = int.TryParse(Console.ReadLine(), out operators);

                    if(success){

                        LogicalTable.ShowTable2();

                        Console.WriteLine("Enter The 2nd Proposition:");
                        Console.WriteLine("p, q, ~p, ~q\n");
                        condition2 = Console.ReadLine();

                        string[] possibility2 = new string[4];
                        if(condition2 == "p"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = LogicalTable.p2[i];
                            }
                        }
                        else if(condition2 == "q"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = LogicalTable.q2[i];
                            }
                        }
                        else if(condition2 == "~p"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = LogicalTable.np2[i];
                            }
                        }
                        else if(condition2 == "~q"){
                            for(int i = 0; i < 4; i++){
                                possibility2[i] = LogicalTable.nq2[i];
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

                        string[] result1Return = new string[4];
                        if(operators == 1){
                            stringOperators = "^";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = LogicalOperations.and(condition1value, condition2value);
                            }
                        }
                        else if(operators == 2){
                            stringOperators = "v";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = LogicalOperations.or(condition1value, condition2value);
                            }
                        }
                        else if(operators == 3){
                            stringOperators = "v_";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = LogicalOperations.xor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 4){
                            stringOperators = "->";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = LogicalOperations.ifthen(condition1value, condition2value);
                            }
                        }
                        else if(operators == 5){
                            stringOperators = "<->";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p2.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                result1Return[k] = LogicalOperations.ifonlyif(condition1value, condition2value);
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
                #region ThreePropositions
                else if(amount == 3){

                    LogicalTable.ShowTable3();

                    Console.WriteLine("Enter The 1st Proposition:");
                    Console.WriteLine("p, q, r, ~p, ~q, ~r\n");
                    condition1 = Console.ReadLine();

                    string[] possibility1 = new string[8];
                    if(condition1 == "p"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = LogicalTable.p3[i];
                        }
                    }
                    else if(condition1 == "q"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = LogicalTable.q3[i];
                        }
                    }
                    else if(condition1 == "r"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = LogicalTable.r3[i];
                        }
                    }
                    else if(condition1 == "~p"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = LogicalTable.np3[i];
                        }
                    }
                    else if(condition1 == "~q"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = LogicalTable.nq3[i];
                        }
                    }
                    else if(condition1 == "~r"){
                        for(int i = 0; i < 8; i++){
                            possibility1[i] = LogicalTable.nr3[i];
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
                    Console.WriteLine("1 - ^ (AND)\n2 - v (OR)\n3 - v_ (XOR)\n4 - -> (IF THEN)\n5 - <-> (IF ONLY IF)\n");
                    success = int.TryParse(Console.ReadLine(), out operators);
                    
                    if(success){
                    
                        LogicalTable.ShowTable3();

                        Console.WriteLine("Enter The 2nd Proposition:");
                        Console.WriteLine("p, q, r, ~p, ~q, ~r\n");
                        condition2 = Console.ReadLine();

                        string[] possibility2 = new string[8];
                        if(condition2 == "p"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = LogicalTable.p3[i];
                            }
                        }
                        else if(condition2 == "q"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = LogicalTable.q3[i];
                            }
                        }
                        else if(condition2 == "r"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = LogicalTable.r3[i];
                            }
                        }
                        else if(condition2 == "~p"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = LogicalTable.np3[i];
                            }
                        }
                        else if(condition2 == "~q"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = LogicalTable.nq3[i];
                            }
                        }
                        else if(condition2 == "~r"){
                            for(int i = 0; i < 8; i++){
                                possibility2[i] = LogicalTable.nr3[i];
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

                        if(operators == 1){
                            stringOperators = "^";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result3Return[k] = LogicalOperations.and(condition1value, condition2value);
                            }
                        }
                        else if(operators == 2){
                            stringOperators = "v";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result3Return[k] = LogicalOperations.or(condition1value, condition2value);
                            }
                        }
                        else if(operators == 3){
                            stringOperators = "v_";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result3Return[k] = LogicalOperations.xor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 4){
                            stringOperators = "->";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result3Return[k] = LogicalOperations.ifthen(condition1value, condition2value);
                            }
                        }
                        else if(operators == 5){
                            stringOperators = "<->";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result3Return[k] = LogicalOperations.ifonlyif(condition1value, condition2value);
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
                        for(int i = 0; i < LogicalTable.result3Return.Length; i++)
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
                            Console.WriteLine("{0}     ¦", LogicalTable.result3Return[i]);
                        }
                        PrintPl(lengthExpression);

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
                #region FourPropositions
                else if(amount == 4){

                    LogicalTable.ShowTable4();

                    Console.WriteLine("Enter The 1st Proposition:");
                    Console.WriteLine("p, q, r, s, ~p, ~q, ~r, ~s\n");
                    condition1 = Console.ReadLine();

                    string[] possibility1 = new string[16];
                    if(condition1 == "p"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.p4[i];
                        }
                    }
                    else if(condition1 == "q"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.q4[i];
                        }
                    }
                    else if(condition1 == "r"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.r4[i];
                        }
                    }
                    else if(condition1 == "s"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.s4[i];
                        }
                    }
                    else if(condition1 == "~p"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.np4[i];
                        }
                    }
                    else if(condition1 == "~q"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.nq4[i];
                        }
                    }
                    else if(condition1 == "~r"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.nr4[i];
                        }
                    }
                    else if(condition1 == "~s"){
                        for(int i = 0; i < 16; i++){
                            possibility1[i] = LogicalTable.ns4[i];
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
                    Console.WriteLine("1 - ^ (AND)\n2 - v (OR)\n3 - v_ (XOR)\n4 - -> (IF THEN)\n5 - <-> (IF ONLY IF)\n");
                    success = int.TryParse(Console.ReadLine(), out operators);
                    
                    if(success){
                    
                        LogicalTable.ShowTable4();

                        Console.WriteLine("Enter The 2nd Proposition:");
                        Console.WriteLine("p, q, r, s, ~p, ~q, ~r, ~s\n");
                        condition2 = Console.ReadLine();

                        string[] possibility2 = new string[16];
                        if(condition2 == "p"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.p4[i];
                            }
                        }
                        else if(condition2 == "q"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.q4[i];
                            }
                        }
                        else if(condition2 == "r"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.r4[i];
                            }
                        }
                        else if(condition2 == "s"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.s4[i];
                            }
                        }
                        else if(condition2 == "~p"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.np4[i];
                            }
                        }
                        else if(condition2 == "~q"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.nq4[i];
                            }
                        }
                        else if(condition2 == "~r"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.nr4[i];
                            }
                        }
                        else if(condition2 == "~s"){
                            for(int i = 0; i < 16; i++){
                                possibility2[i] = LogicalTable.ns4[i];
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

                        if(operators == 1){
                            stringOperators = "^";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result4Return[k] = LogicalOperations.and(condition1value, condition2value);
                            }
                        }
                        else if(operators == 2){
                            stringOperators = "v";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result4Return[k] = LogicalOperations.or(condition1value, condition2value);
                            }
                        }
                        else if(operators == 3){
                            stringOperators = "v_";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result4Return[k] = LogicalOperations.xor(condition1value, condition2value);
                            }
                        }
                        else if(operators == 4){
                            stringOperators = "->";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result4Return[k] = LogicalOperations.ifthen(condition1value, condition2value);
                            }
                        }
                        else if(operators == 5){
                            stringOperators = "<->";
                            for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                            {
                                condition1value = possibility1[i];
                                condition2value = possibility2[j];
                                LogicalTable.result4Return[k] = LogicalOperations.ifonlyif(condition1value, condition2value);
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
                        for(int i = 0; i < LogicalTable.result4Return.Length; i++)
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
                            Console.WriteLine("{0}     ¦", LogicalTable.result4Return[i]);
                        }
                        PrintPl(lengthExpression);

                        Console.WriteLine("Press ENTER to Continue...");
                        Console.ReadKey();
                        ContinueFourExpression(currentExpression);
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
                    LogicalMenu.Exec();
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

        #region ContinueThreeExpressions
        public static void ContinueExpression(string currentExpression){
            string[] possibility1 = new string[8];
            for(int i = 0; i < 8; i++){
                possibility1[i] = LogicalTable.result3Return[i];
            }
            
            Console.Clear();
            Console.WriteLine("Whatch Operator Will You Use ?");
            Console.WriteLine("1 - ^ (AND)\n2 - v (OR)\n3 - v_ (XOR)\n4 - -> (IF THEN)\n5 - <-> (IF ONLY IF)\n\n0 - Return\n");
            success = int.TryParse(Console.ReadLine(), out operators);

            if(operators == 0){
                LogicalMenu.Exec();
            }

            Console.Clear();
            
            LogicalTable.ShowTable3();

            Console.WriteLine("Enter The Other Proposition:");
            Console.WriteLine("p, q, r, ~p, ~q, ~r\n");
            condition2 = Console.ReadLine();

            string[] possibility2 = new string[8];
            if(condition2 == "p"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = LogicalTable.p3[i];
                }
            }
            else if(condition2 == "q"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = LogicalTable.q3[i];
                }
            }
            else if(condition2 == "r"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = LogicalTable.r3[i];
                }
            }
            else if(condition2 == "~p"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = LogicalTable.np3[i];
                }
            }
            else if(condition2 == "~q"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = LogicalTable.nq3[i];
                }
            }
            else if(condition2 == "~r"){
                for(int i = 0; i < 8; i++){
                    possibility2[i] = LogicalTable.nr3[i];
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

                if(operators == 1){
                    stringOperators = "^";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result3Return[k] = LogicalOperations.and(condition1value, condition2value);
                    }
                }
                else if(operators == 2){
                    stringOperators = "v";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result3Return[k] = LogicalOperations.or(condition1value, condition2value);
                    }
                }
                else if(operators == 3){
                    stringOperators = "v_";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result3Return[k] = LogicalOperations.xor(condition1value, condition2value);
                    }
                }
                else if(operators == 4){
                    stringOperators = "->";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result3Return[k] = LogicalOperations.ifthen(condition1value, condition2value);
                    }
                }
                else if(operators == 5){
                    stringOperators = "<->";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p3.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result3Return[k] = LogicalOperations.ifonlyif(condition1value, condition2value);
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
                for(int i = 0; i < LogicalTable.result3Return.Length; i++)
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

                    Console.Write("¦       {0}", LogicalTable.result3Return[i]);
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
            string[] possibility1 = new string[16];
            for(int i = 0; i < 16; i++){
                possibility1[i] = LogicalTable.result4Return[i];
            }
            
            Console.Clear();
            Console.WriteLine("Whatch Operator Will You Use ?");
            Console.WriteLine("1 - ^ (AND)\n2 - v (OR)\n3 - v_ (XOR)\n4 - -> (IF THEN)\n5 - <-> (IF ONLY IF)\n\n0 - Return\n");
            success = int.TryParse(Console.ReadLine(), out operators);

            if(operators == 0){
                LogicalMenu.Exec();
            }

            Console.Clear();
            
            LogicalTable.ShowTable4();

            Console.WriteLine("Enter The Other Proposition:");
            Console.WriteLine("p, q, r, s, ~p, ~q, ~r, ~s\n");
            condition2 = Console.ReadLine();

            string[] possibility2 = new string[16];
            if(condition2 == "p"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.p4[i];
                }
            }
            else if(condition2 == "q"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.q4[i];
                }
            }
            else if(condition2 == "r"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.r4[i];
                }
            }
            else if(condition2 == "s"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.s4[i];
                }
            }
            else if(condition2 == "~p"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.np4[i];
                }
            }
            else if(condition2 == "~q"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.nq4[i];
                }
            }
            else if(condition2 == "~r"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.nr4[i];
                }
            }
            else if(condition2 == "~s"){
                for(int i = 0; i < 16; i++){
                    possibility2[i] = LogicalTable.ns4[i];
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

                if(operators == 1){
                    stringOperators = "^";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result4Return[k] = LogicalOperations.and(condition1value, condition2value);
                    }
                }
                else if(operators == 2){
                    stringOperators = "v";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result4Return[k] = LogicalOperations.or(condition1value, condition2value);
                    }
                }
                else if(operators == 3){
                    stringOperators = "v_";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result4Return[k] = LogicalOperations.xor(condition1value, condition2value);
                    }
                }
                else if(operators == 4){
                    stringOperators = "->";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result4Return[k] = LogicalOperations.ifthen(condition1value, condition2value);
                    }
                }
                else if(operators == 5){
                    stringOperators = "<->";
                    for(int i = 0, j = 0, k = 0; i < LogicalTable.p4.Length; i++, j++, k++) 
                    {
                        condition1value = possibility1[i];
                        condition2value = possibility2[j];
                        LogicalTable.result4Return[k] = LogicalOperations.ifonlyif(condition1value, condition2value);
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
                for(int i = 0; i < LogicalTable.result4Return.Length; i++)
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

                    Console.Write("¦       {0}", LogicalTable.result4Return[i]);
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