using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem!");
            Console.WriteLine("User need to follow pre-defined Mobile Format!");
            string phonenumber = @"^[0-9]{2,}[ ][0-9]{10}$";

            Regex regex = new Regex(phonenumber);
            Console.WriteLine("Enter Phone Number:");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}