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
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

