using System.Security.Cryptography.X509Certificates;

namespace List_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListOfIntegers();

        }
        public static void ListOfIntegers()
        {
            List<int> list1 = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                list1.Add(rand.Next(10, 21));
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear(); // Optional
            int choice = 0;
            Console.WriteLine("Here is the List of numbers: ");

            while (choice != 8)
            {   
                string printThis = "[";
                foreach (int i in list1)
                    printThis += ($"{i}, ");
                printThis = printThis.Trim().Trim(',');
                printThis += "]";
                Console.WriteLine(printThis);

                Console.WriteLine("\nHere is the looping problems menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - remove a number (by value)");
                Console.WriteLine("4 - add a value to the list");
                Console.WriteLine("5 - count the number of occurences of a specified number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - print the smallest value");
                Console.WriteLine("8 - Quit");
                Console.WriteLine("9 - Print the sum and average of the numbers in the list");
                Console.WriteLine("10 - Determine the most frequently occuring value(s)");
                Console.WriteLine("11 - Allow the user to specify a value and tell them the number of occurences of that value in the list");
                Console.WriteLine();
                Int32.TryParse(Console.ReadLine(), out choice);
                Console.WriteLine();

                if (choice == 1)
                {
                    Console.Clear();
                    list1.Sort();
                    Console.WriteLine("Here is your sorted list of Numbers: ");
                }
                else if (choice == 2)
                    NewRandomList(list1);
                else if (choice == 3)
                    RemoveValue(list1);
                else if (choice == 4)
                    AddValueToList(list1);
                else if (choice == 5)
                    CountNumberOfRepeats(list1);
                else if (choice == 8)
                    Console.WriteLine("Goodbye");

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
            
        }
        public static void AddValueToList(List<int> list)
        {
            Console.Clear ();
            Random rand = new Random();
            int choice = 2;
            while (choice == 2)
            {
                int numToAdd = rand.Next(10, 21);
                Console.WriteLine($"Would you like to add the number {numToAdd} to the list?");
                Console.WriteLine("Type 1 to Confirm or type 2 to re roll.");
                choice = TestForInt(1, 2);
                if (choice == 1)
                    list.Add(numToAdd);
                Console.Clear();
            }
            Console.WriteLine("Here is your updated list: ");
        }
        public static void CountNumberOfRepeats(List<int> list)
        {
            Console.Clear();
            Console.WriteLine("Which number do you want to count the occurences of?");
            int numCount = TestForInt(10, 20);
            int counter = 0;
            for (int i = 0; i < list.Count; i++){
                if (list[i] == numCount)
                    counter++;
            }
            Console.WriteLine($"The number {numCount} has {counter} occurences");
            Console.WriteLine("Press enter to return to the main menu");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is the list of numbers: ");
        }
        public static void NewRandomList(List<int> list)
        {
            Console.Clear();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                list[i]=(rand.Next(10, 21));
            }
            Console.WriteLine("Here is your new list of Numbers");
        }
        public static void RemoveValue(List<int> list)
        {
            Console.Clear();
            Console.WriteLine("Please input a value to be removed from the list");
            int numRemove = TestForInt(10, 20);
            while (true)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == numRemove)
                        list.RemoveAt(i);
                }
                int counter = 0;
                for (int i =0; i < list.Count; i++)
                {
                    if (list[i] != numRemove)
                        counter++;
                }
                if (counter == list.Count)
                    break;
            }
            Console.Clear();
            Console.WriteLine("Here is the updated list: ");
        }
        public static int TestForInt(int min, int max)
        {
            bool success = Int32.TryParse(Console.ReadLine(), out int numToTest);
            if (numToTest < min || numToTest > max)
                success = false;
            while (success == false)
            {
                Console.WriteLine("Please input a valid option.");
                success = Int32.TryParse(Console.ReadLine(), out numToTest);
                if (numToTest < min || numToTest > max)
                    success = false;
            }
            return (numToTest);
        }
    }
}