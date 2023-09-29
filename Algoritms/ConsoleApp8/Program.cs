using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //leetcode questions
            string word1 =  "abc";
            string word2 =  "pqr";

            StringBuilder merged = new StringBuilder();
            int maxLength = word1.Length + word2.Length;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                {
                    merged.Append(word1[i]);
                }

                if (i < word2.Length)
                {
                    merged.Append(word2[i]);
                }
            }

            Console.WriteLine(merged);


        }
    }
}
