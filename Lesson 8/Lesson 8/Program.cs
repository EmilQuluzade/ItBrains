using System;

namespace Lesson_8
{
    internal class Program
    {
        private static Student[] students;
        static void Main(string[] args)
        {
            students = new Student[]
            {
                new Student("Aysel", 'A', 18),
                new Student("Nijat", 'B', 20),
                new Student("Samir", 'C', 22),
                new Student("Sevda", 'A', 19),
                new Student("Tural", 'B', 21),
                new Student("Leyla", 'C', 23),
                new Student("Seymur", 'A', 18),
                new Student("Elmira", 'B', 20),
                new Student("Arif", 'C', 22),
                new Student("Aysu", 'A', 19),
                new Student("Ayaz", 'B', 21),
                new Student("Aynur", 'C', 23),
                new Student("Vugar", 'A', 18),
                new Student("Gunay", 'B', 20),
                new Student("Narmin", 'C', 22),
                new Student("Namiq", 'A', 19),
                new Student("Aygul", 'B', 21),
                new Student("Turkan", 'C', 23),
                new Student("Togrul", 'A', 18),
                new Student("Nigar", 'B', 20)
            };
            void GetBirthYear()
            {
                Console.WriteLine(" Whose birthday do you want to check?");
                string studentName = Console.ReadLine();
                bool found = false;
                foreach (var item in students)
                {
                    if (item.Name == studentName)
                    {
                        Console.WriteLine($"Birth year is {2023 - item.Age}");
                        found = true;
                        break;
                    }
                    
                }

                if (!found) 
                {
                    Console.WriteLine("Wrong Name");
                        }

            }

            void CheckStudentCount()
            {
                Console.WriteLine("Enter group letter you want to check (A, B, C)");
                var groupName = Console.ReadLine();

                int groupCount = 0; 

                foreach (var student in students)
                {
                    if (student.Group == groupName[0])
                    {
                        groupCount++;
                    }
                }

                if (groupCount > 0)
                {
                    Console.WriteLine($"Number of students in group {groupName}: {groupCount}");
                }
                else
                {
                    Console.WriteLine($"No students found in group {groupName}");
                }
            }







            while (true)
            {
                Console.WriteLine("1. Get student's birthday");
                Console.WriteLine("2. Get how many students are there in each group");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice by number");                
                int inputChoice = Convert.ToInt32(Console.ReadLine());

                switch (inputChoice)
                {
                    case 1:
                        GetBirthYear();
                        break;
                        case 2:
                        CheckStudentCount();
                        break;
                        case 3:
                        return;
                        break;
                    default: 
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
                  

        
        }
    }

    class Student
    {
        public string Name { get; set; }
        public char Group { get; set; }
        public int Age { get; set; }

        public Student(string name, char group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }
    }
}
