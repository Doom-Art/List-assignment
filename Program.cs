﻿using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace List_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int choice = 0;
            while (choice != 3)
            {
                Console.Clear();
                Console.WriteLine("Here is the list assignment menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Go to the Integer List Menu");
                Console.WriteLine("2 - Go to the String List Menu");
                Console.WriteLine("3 - Quit");
                Console.WriteLine();
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                    ListOfIntegers();
                else if (choice == 2)
                    ListOfStrings();
                else if (choice == 3)
                    Console.WriteLine("Goodbye");
                else{
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public static void ListOfStrings()
        {
            List<string> list1 = new List<string>() {"CARROT", "BEET", "CELERY", "RADISH", "CABBAGE"};
            int choice = 0;
            while (choice != 7)
            {
                Console.Clear();
                Console.WriteLine("Vegetables");
                for (int i =0 ; i < list1.Count; i++)
                {
                    Console.WriteLine($"{i+1} - {list1[i]}");
                }
                Console.WriteLine("\nHere is the String List menu. Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Remove a vegetable by index");
                Console.WriteLine("2 - ");
                Console.WriteLine("3 - ");
                Console.WriteLine("4 - ");
                Console.WriteLine("5 - ");
                Console.WriteLine("6 - ");
                Console.WriteLine("7 - Quit");
                Console.WriteLine();
                Int32.TryParse(Console.ReadLine(), out choice);

                if (choice == 1){

                }
                else if (choice == 2) { }
                    
                else if (choice == 3) { }
                    
                else if (choice == 4) { }
                    
                else if (choice == 5) { }
                    
                else if (choice == 6) { }
                    
                else if (choice == 7)
                    Console.WriteLine("Goodbye");
                else{
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public static void RemoveByIndex(List<String> list)
        {

        }
        public static void ListOfIntegers()
        {
            List<int> list1 = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                list1.Add(rand.Next(10, 21));
            }
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

                Console.WriteLine("\nHere is the Integer List menu. Please select an option:");
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

                if (choice == 1){
                    Console.Clear();
                    list1.Sort();
                    Console.WriteLine("Here is your sorted list of Numbers: ");
                }
                else if (choice == 2){
                    Console.Clear();
                    for (int i = 0; i < 25; i++)
                    {
                        list1.Add(rand.Next(10, 21));
                    }
                    Console.WriteLine("Here is your new list of Numbers");
                }
                else if (choice == 3)
                    RemoveValue(list1);
                else if (choice == 4)
                    AddValueToList(list1);
                else if (choice == 5)
                    CountNumberOfRepeats(list1);
                else if (choice == 6)
                    FindLargestVal(list1);
                else if (choice == 7)
                    FindSmallestVal(list1);
                else if (choice == 8)
                    Console.WriteLine("Goodbye");
                else if (choice == 9)
                    SumAverage(list1);
                else if (choice == 10)
                    MostOccuringVal(list1);
                else if (choice == 11)
                    CountNumberOfRepeats(list1);
                else{
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public static void MostOccuringVal(List<int> list)
        {
            Console.Clear();
            int count; int maxCount = 0;
            string val = "";
            for (int i = 10; i < 21; i++)
            {
                count = 0;
                for (int j =0; j<list.Count; j++)
                {
                    if (list[j] ==i)
                        count++;
                }
                if (count > maxCount){
                    maxCount = count;
                    val = Convert.ToString(i);
                }
                else if (count == maxCount){
                    val += ($", {i}");
                }
            }
            if (Int32.TryParse(val, out int valInt))
                Console.WriteLine($"The number {val} has the most occurences with {maxCount} occurences");
            else
                Console.WriteLine($"The numbers {val} have the most occurences with {maxCount} occurences each");
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is the list of integers: ");
        }
        public static void SumAverage(List<int> list)
        {
            Console.Clear();
            int totalVal = 0;
            for (int i = 0; i < list.Count; i++)
            {
                totalVal += list[i];
            }
            Console.WriteLine($"The sum of the numbers is {totalVal} and the average is {totalVal/list.Count}");
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is the list of integers: ");
        }
        public static void FindLargestVal(List <int> list)
        {
            Console.Clear();
            int largest = 0;
            for (int i =0; i < list.Count; i++)
            {
                if (list[i] > largest)
                    largest = list[i];
            }
            Console.WriteLine($"The largest value is {largest}");
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is the list of integers: ");
        }
        public static void FindSmallestVal(List<int> list)
        {
            Console.Clear();
            int smallest = 21;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                    smallest = list[i];
            }
            Console.WriteLine($"The smallest value is {smallest}");
            Console.WriteLine("Press enter to return to the menu");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is the list of integers: ");
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