using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. Reverse text"
                    + "\n6. Recursion"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        ReverseText();
                        break;
                    case '6':
                        Recursion();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            /*
             * 1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir
             *    genomförbar.
             *
             * 2. När ökar listans kapacitet ? (Alltså den underliggande arrayens storlek)
             *    Listans kapacitet ökar när man försöker lägga till ett element och listans kapacitet är full.
             *
             * 3. Med hur mycket ökar kapaciteten?
             *    Kapaciteten på listan fördubblas när den ökar.
             *
             * 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
             *    Listans kapacitet ökar endast när den underliggande arrayen är full för att inte behöva kopiera innehållet varje gång ett element läggs till.
             *    Istället tar man höjd för framtida tillägg genom att öka kapaciteten med en större mängd än bara ett element.
             *
             * 5. Minskar kapaciteten när element tas bort ur listan?
             *    Nej, kapaciteten minskar inte automatiskt.
             *
             * 6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
             *    När kapaciteten är känd på förhand och inte kommer behöva ändras.
             */
            Console.WriteLine("Enter +item to add an item, -item to remove an item or 0 to exit to main menu");
            List<string> list = [];
            do
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (input.Length == 0)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                char nav = input[0];
                string value = input[1..];
                int oldCapacity = list.Capacity;

                switch (nav)
                {
                    case '0':
                        return;
                    case '+' when value.Length > 0:
                        list.Add(value);
                        Console.WriteLine($"Added {value} to the list");
                        break;
                    case '-':
                        if (list.Remove(value))
                            Console.WriteLine($"Removed {value} from the list");
                        else
                            Console.WriteLine($"{value} was not found in the list");
                        break;
                    default:
                        Console.WriteLine("Please use +item or -item to add or remove items from the list, or 0 to go back");
                        continue;
                }
                Console.WriteLine($"List now contains {list.Count} items with a capacity of {list.Capacity}");
                if (oldCapacity != list.Capacity)
                    Console.WriteLine($"List capacity has changed from {oldCapacity}!");
            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> queue = [];
            do
            {
                Console.WriteLine("Enter +item to enqueue, - to dequeue or 0 to exit to main menu");
                string input = Console.ReadLine() ?? string.Empty;
                if (input.Length == 0)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                char nav = input[0];
                string value = input[1..];
                switch (nav)
                {
                    case '0':
                        return;
                    case '+':
                        queue.Enqueue(value);
                        Console.WriteLine($"{value} was added to the queue.");
                        break;
                    case '-':
                        if (queue.Count > 0)
                        {
                            string dequeued = queue.Dequeue();
                            Console.WriteLine($"{dequeued} was removed from the queue.");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty, cannot dequeue.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please use +item to enqueue or - to dequeue items from the queue, or 0 to exit to main menu");
                        continue;
                }
                Console.WriteLine($"Queue now contains {queue.Count} items.");
            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> stack = [];
            do
            {
                Console.WriteLine("Enter +item to push, - to pop or 0 to exit to main menu");
                string input = Console.ReadLine() ?? string.Empty;
                if (input.Length == 0)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                char nav = input[0];
                string value = input[1..];
                switch (nav)
                {
                    case '0':
                        return;
                    case '+':
                        stack.Push(value);
                        Console.WriteLine($"{value} was added to the stack.");
                        break;
                    case '-':
                        if (stack.Count > 0)
                        {
                            string popped = stack.Pop();
                            Console.WriteLine($"{popped} was removed from the stack.");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty, cannot pop.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please use +item to push or - to pop items from the stack, or 0 to exit to main menu");
                        continue;
                }
            } while (true);
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            do
            {
                Console.WriteLine("Enter a string to check for correct parens matching or 0 to exit to main menu");
                string input = Console.ReadLine() ?? string.Empty;
                if (input.Length == 0)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                if (input == "0")
                    return;

                if (ValidateParenMatch(input))
                    Console.WriteLine("Parens match");
                else
                    Console.WriteLine("Parens don't match");
            } while (true);

            static bool ValidateParenMatch(string input)
            {
                Stack<char> stack = [];
                foreach (char next in input)
                {
                    switch (next)
                    {
                        case '(':
                        case '{':
                        case '[':
                            stack.Push(next);
                            break;
                        case ')':
                        case '}':
                        case ']':
                            if (stack.Count == 0)
                                return false;
                            char prev = stack.Pop();
                            bool match = (prev, next) switch
                            {
                                ('(', ')') => true,
                                ('{', '}') => true,
                                ('[', ']') => true,
                                _ => false,
                            };
                            if (!match)
                                return false;
                            break;
                    }
                }
                return stack.Count == 0;
            }
        }

        public static void ReverseText()
        {
            do
            {
                Console.WriteLine("Enter text to reverse or 0 to exit to main menu");
                string input = Console.ReadLine() ?? string.Empty;
                if (input.Length == 0)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                if (input == "0")
                    return;
                PrintReverseWithStack(input);
            } while (true);

            static void PrintReverseWithStack(string input)
            {
                Stack<char> stack = new(input);
                //foreach (char c in input)
                //    stack.Push(c);
                while (stack.Count > 0)
                    Console.Write(stack.Pop());
                Console.WriteLine();
            }
        }

        private static void Recursion()
        {
            do
            {
                Console.WriteLine($"Select an option:");
                Console.WriteLine("1. Recursive Even");
                Console.WriteLine("2. Recursive Fibonacci");
                Console.WriteLine("3. Recursive Fibonacci (tail call)");
                Console.WriteLine("4. Iterative Even");
                Console.WriteLine("5. Iterative Fibonacci");
                Console.WriteLine("0. Exit to main menu");

                string input = Console.ReadLine() ?? string.Empty;
                if (input.Length == 0)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                Dictionary<string, Func<int,int>> menu = new()
                {
                    {"1", RecursiveEven},
                    {"2", RecursiveFibonacci},
                    {"3", RecursiveFibonacciTailCall},
                    {"4", IterativeEven},
                    {"5", IterativeFibonacci},
                };

                if (input == "0")
                    return;

                if (!menu.ContainsKey(input))
                {
                    Console.WriteLine($"Please enter a valid choice!");
                    continue;
                }

                Console.WriteLine("Enter a number n to compute:");
                if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
                {
                    Console.WriteLine("Please enter a valid non-negative integer!");
                    continue;
                }

                int result = menu[input].Invoke(n);
                Console.WriteLine($"Result: {result}");
            } while (true);
        }


        // 5.2. Skriv en RecursiveEven(int n) metod som rekursivt beräknar det n:te jämna talet.
        public static int RecursiveEven(int n)
        {
            if (n <= 0) return 0;
            return RecursiveEven(n - 1) + 2;
        }

        // 5.3. Implementera en rekursiv funktion för att beräkna tal i fibonaccisekvensen: (f(n) =f(n-1) + f(n-2))
        public static int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        // Fib with tail recursion for possible tail call optimization
        public static int RecursiveFibonacciTailCall(int n) => RecursiveFibonacciTailCall(n, 0, 1);
        public static int RecursiveFibonacciTailCall(int n, int x, int y)
        {
            if (n <= 0) return x;
            if (n == 1) return y;
            return RecursiveFibonacciTailCall(n-1, y, x+y);
        }

        // 6.2. Skapa en IterativeEven(int n) funktion för att iterativt beräkna det n:te jämna talet.
        public static int IterativeEven(int n)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
                result += 2;
            return result;
        }

        // 6.3. Implementera en iterativ version av fibonacciberäknaren
        public static int IterativeFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int x = 0;
            int y = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = x + y;
                x = y;
                y = result;
            }
            return result;
        }

        // Fråga: Utgå ifrån era nyvunna kunskaper om iteration, rekursion och
        // minneshantering. Vilken av ovanstående funktioner är mest
        // minnesvänlig och varför?
        //
        // Den rekursiva versionen skapar en ny stack frame för varje anrop
        // vilket gör att call stacken växer och använder mer minne. Den
        // iterativa versionen behöver inget extra minne för varje iteration,
        // utan använder bara några variabler för resultat och
        // mellanlagring. Det gör den iterativa versionen mer minnesvänlig.
        // Om Tail Call Optimization (TCO) är implementerat i kompilatorn kan
        // den rekursiva versionen med tail call vara lika minnesvänlig som
        // den iterativa versionen, eftersom TCO kan optimera bort stack
        // frames och göra om det till iteration.
    }
}

