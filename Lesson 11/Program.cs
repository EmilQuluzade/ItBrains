using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your information please");
            Console.WriteLine("Your name:");
            string inputName = Console.ReadLine();
            Console.WriteLine("Your Email:");
            string inputEmail = Console.ReadLine();
            Console.WriteLine("Your Password:");
            string inputPassword = Console.ReadLine();
            PasswordCheck(inputPassword);
            if (PasswordCheck(inputPassword))
            {
                Account account = new Account(inputName, inputEmail, inputPassword);
                Console.WriteLine("Account added");

                Console.WriteLine("Would You like to display your name and email?");

                string yesorno = Console.ReadLine();

                if (yesorno != "no")
                {
                    account.ShowInfo();
                }
            }
            else 
            {
                Console.WriteLine("Account not added, pls try again");
            }

            


        }

        public static bool PasswordCheck(string password)
        { 
            bool result = false;
            bool lowerCase = false;
            bool upperCase = false;
            bool length = false;

             
            for (int i = 0;i< password.Length; i++)
            {
                if (password[i] > 'a' && password[i] < 'z')
                {
                    lowerCase=true;
                }else if (password[i] > 'A' && password[i] < 'Z')
                {
                    upperCase=true;
                }
            }

            if (password.Length>7)
            {
                length = true;
            }
            

            if (lowerCase && upperCase && length)
            { 
                result = true;
            }
            return result;
        } 
    }
    public abstract class User
    {
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine(Name + "    " + Email);
        }
    }

    public class Account:User
    
    

    {
        public Account(string name, string email, string password) : base(name , email , password) { }
    }
}
