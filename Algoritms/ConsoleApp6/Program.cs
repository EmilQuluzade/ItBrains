using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text here");
            //abcabcbb
            string input = Console.ReadLine();

            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < output.Length; j++)
                {
                    if (input[i] == output[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    output += input[i];
                }
            }

            Console.WriteLine(output.Length);
            Console.WriteLine(output);
        }

    }
}
