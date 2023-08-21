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

            // Keep adding accounts indefinitely
            while (true)
            {
                AddAccount(accounts);
            }

            // This code won't be reached because of the infinite loop above
        }

        static void AddAccount(List<Account> accounts)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Validate user-entered name
            if (!IsNameValid(name))
            {
                Console.WriteLine("Invalid name format. Only letters and numbers are allowed.");
                return;
            }

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate user-entered password
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
            // Password validation: Length 8-25, at least 1 symbol, 1 uppercase letter, and 1 digit
            return Regex.IsMatch(password, @"^(?=.*[!@#$%^&*(),.?""\:{}|<>])(?=.*[A-Z])(?=.*\d).{8,25}$");
        }
    }

    class Account
    {
        private static int nextAccountNumber = 1; // Start with account number 1

        public string Number { get; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Account(string name, string password)
        {
            Number = nextAccountNumber.ToString(); // Assign the current account number
            nextAccountNumber++; // Increment for the next account
            Name = name; // Set the account holder's name
            Password = password; // Set the account password
        }
    }
}
