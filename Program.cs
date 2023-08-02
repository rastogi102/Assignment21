using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment21
{
    internal class Program
    {
        static List<string> fruitsList = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Mango", "Watermelon", "Strawberry", "Pineapple", "Cherry", "Kiwi" };
        static List<string> daysList = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        static List<string> monthsList = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        static Dictionary<string, string> wordsMeaningsDict = new Dictionary<string, string>
        {
            { "happy", "feeling or showing pleasure or contentment" },
            { "brave", "ready to face and endure danger or pain" },
            { "beautiful", "pleasing the senses or mind aesthetically" },
            { "kind", "having or showing a friendly, generous, and considerate nature" },
            { "clever", "quick to understand, learn, and devise or apply ideas" }
        };

        static void DisplayDays()
        {
            Console.WriteLine("Days:");
            foreach (var day in daysList)
            {
                Thread.Sleep(2000); // Wait for 2 seconds
                Console.WriteLine(day);
            }
        }

        static void DisplayMonths()
        {
            Console.WriteLine("\nMonths:");
            foreach (var month in monthsList)
            {
                Thread.Sleep(2000); // Wait for 2 seconds
                Console.WriteLine(month);
            }
        }

        static void DisplayFruitsAndWords()
        {
            Console.WriteLine("\nFruits:");
            foreach (var fruit in fruitsList)
            {
                Thread.Sleep(1000); // Wait for 1 second
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nWords and Meanings:");
            foreach (var word in wordsMeaningsDict)
            {
                Thread.Sleep(1000); // Wait for 1 second
                Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }
            static void Main(string[] args)
            {
            Console.WriteLine("----------------Welcome to Learning------------------");

            // Create and start the threads
            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsWordsThread = new Thread(DisplayFruitsAndWords);

            daysThread.Start();
            daysThread.Join(); // Wait for daysThread to finish before starting monthsThread

            monthsThread.Start();
            monthsThread.Join(); // Wait for monthsThread to finish before starting fruitsWordsThread

            fruitsWordsThread.Start();
            fruitsWordsThread.Join(); // Wait for fruitsWordsThread to finish

            Console.WriteLine("Learning Completed!");

            Console.ReadKey();

        }
        }
    }
