using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lesson8task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            while (true)
            {
                AddAccount(accounts);
            }
        }

        static void AddAccount(List<Account> accounts)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!IsNameValid(name))
            {
                Console.WriteLine("Invalid name format. Only letters and numbers are allowed.");
                return;
            }

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (!IsPasswordValid(password))
            {
                Console.WriteLine("Invalid password format.");
                return;
            }

            Account newAccount = new Account(name, password);
            accounts.Add(newAccount);

            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.Number}, Name: {account.Name}, Password: {account.Password}");
            }
        }

        static bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z0-9]+$");
        }

        static bool IsPasswordValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[!@#$%^&*(),.?""\:{}|<>])(?=.*[A-Z])(?=.*\d).{8,25}$");
        }
    }

    class Account
    {
        private static int nextAccountNumber = 1;

        public string Number { get; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Account(string name, string password)
        {
            Number = nextAccountNumber.ToString();
            nextAccountNumber++;
            Name = name;
            Password = password;
        }
    }
}
