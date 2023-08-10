using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many item do you want to add");
            int count = Convert.ToInt32(Console.ReadLine());
             
            ArrayList items = new ArrayList();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter item name:");
                items.Add(Console.ReadLine()); 
            }

            foreach (string item in items) 
            {
            Console.WriteLine(item);
            }

            Console.WriteLine("Enter item name you want to check");

            if (items.Contains(Console.ReadLine()))
            {
                Console.WriteLine("Item is in the list");
            }
            else
            {
                Console.WriteLine("Item doesn't exists");
            }
        }
    }
}
