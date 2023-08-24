using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.CHeck number if its odd or not");
                Console.WriteLine("2.CHeck number if its even or not");
                Console.WriteLine("3.CHeck number if it contains number or not");
                Console.WriteLine("4.Letter");
                Console.WriteLine("5.Digit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ExtentionMethods.IsOdd();
                        break;


                    case 2:
                        ExtentionMethods.IsEven();
                        break;

                    case 3:
                        ExtentionMethods.IsContainsDigit();
                        break; 

                        case 4:
                        ExtentionMethods.GetValueIndexes();
                        break;
                        case 5:
                        ExtentionMethods.GetValueIndexesNumber();
                        break;
                    default: Console.WriteLine("Wrong input");
                        break;
                }















            }



        }
    }

    static class ExtentionMethods
    {
        public static void IsOdd()
        {
            Console.WriteLine("Enter number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());


            if (inputNumber > 1)
            {
                int number = inputNumber % 2;

                if (number == 0)
                {
                    Console.WriteLine($"{inputNumber} is even.");
                }
                else if (number == 1)
                {
                    Console.WriteLine($"{inputNumber} is odd.");
                }
            }
            else if (inputNumber == 0)
            {
                Console.WriteLine("0 is neither odd or even");
            }
            else
            {
                Console.WriteLine("Wrong input tyr again");
            }



        }

        public static void IsEven()
        {
            Console.WriteLine("Enter number");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > 1)
            {
                int number = inputNumber % 2;

                if (number == 1)
                {
                    Console.WriteLine($"{inputNumber} is odd.");
                }
                else if (number == 1)
                {
                    Console.WriteLine($"{inputNumber} is even.");
                }
            }
            else if (inputNumber == 0)
            {
                Console.WriteLine("0 is neither odd or even");
            }
            else
            {
                Console.WriteLine("Wrong input tyr again");
            }

        }

        public static void IsContainsDigit()
        {
            Console.WriteLine("Enter text you want to check");
            string inputText = Console.ReadLine();

            bool result = false;

            foreach (char c in inputText)
            {
                if (c >= '0' && c <='9') 
                {
                    result = true; break;

                }

            }

            if (result)
            {
                Console.WriteLine("It contains digit");
            }
            else
                {
                Console.WriteLine("It does not contain a digit");
            }
        }

        public static void GetValueIndexes()
        {
            Console.WriteLine("Enter text");
            string values = Console.ReadLine();
            Console.WriteLine("Enter letter");
            char letter = Convert.ToChar(Console.ReadLine());

           List<int> indexes = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == letter)
                {
                   indexes.Add(i);
                }
            }

            if (indexes.Count > 0)
            {
                Console.WriteLine($"Indexes where '{letter}' occurs: {string.Join(", ", indexes)}");
            }
            else
            {
                Console.WriteLine($"The letter '{letter}' was not found in the input string.");
            }
        }

        public static void GetValueIndexesNumber()
        {
            Console.WriteLine("Enter text");
            string values = Console.ReadLine();
            Console.WriteLine("Enter digit");
            char charToFind = Console.ReadLine()[0]; // Read the first character entered

            List<int> indexNumbers = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == charToFind)
                {
                    indexNumbers.Add(i);
                }
            }

            if (indexNumbers.Count > 0)
            {
                Console.WriteLine($"Indexes where '{charToFind}' occurs: {string.Join(", ", indexNumbers)}");
            }
            else
            {
                Console.WriteLine($"The letter '{charToFind}' was not found in the input string.");
            }
        }



    }
}
