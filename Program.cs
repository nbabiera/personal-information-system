﻿using System;

namespace personal_information_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age = 0;
            double height = 0;
            const int LEGAL_DRINKING_AGE = 21;
            const int ageVerify = 18;
            double doubleAge = 0;
            int roundedHeight = 0;

            Console.WriteLine("Welcome to Your Personal Information System \n");

            Console.Write("Please enter your name:");
            name = Console.ReadLine();
            Console.Write("Please enter your age:");
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input, please enter a number");
                 Console.Write("Please enter your age:");
            }
            Console.Write("Please enter your height in meters:");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid input, please enter a number");
                Console.Write("Please enter your height in meters:");
            }

            doubleAge = Convert.ToDouble(age);
            roundedHeight = Convert.ToInt32(height);

            Console.WriteLine("\n------------------------\n\nName:{0}\nage:{1}\nheight:{2}", name, doubleAge, roundedHeight);
            Console.WriteLine("Age Check");
            if (age >= ageVerify)
            {
                Console.WriteLine("Welcome,{0}! You're eligible for additional features.\n", name);
            }
            else
            {
                Console.WriteLine("You are still a minor\n");
            }

            Console.WriteLine("Legal Drinking Age Verification:");
            if (age >= LEGAL_DRINKING_AGE)
            {
                Console.WriteLine("Cheers, {0}! You're legally allowed to enjoy alcoholic beverages.\n", name);
            }
            else
            {
                Console.WriteLine("Sorry, you are underage for drinking.\n");
            }

            Console.WriteLine("Personal Details Presentation:\nYour Personal Information: {0}, {1} years old, {2} meter/s tall", name, doubleAge, roundedHeight);
            Console.WriteLine("\n\n------------------------\nThank you for using your Personal Information System!\n");

            Main([]);

        }

    }
}