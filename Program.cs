﻿using System;
using System.ComponentModel.Design;
using System.Globalization;


namespace Petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();

            Console.WriteLine("------------------ Define the dog's weight ------------------");

            do
            {
                try
                {
                    Console.Write(">> ");
                    dog1.Weight = double.Parse(Console.ReadLine());

                    if (dog1.Weight > 0 && dog1.Weight <= 50)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Enter only values between 0.1kg and 50kg");
                        Console.WriteLine();
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Enter only numbers between 0.1kg and 50kg");
                }
            } while (true);



            Console.WriteLine("------------------- Define the fur length -------------------");
            Console.WriteLine("------------- S = Short | M = Medium | L = Long -------------");
            do
            {
                Console.Write(">> ");
                dog1.Fur = Console.ReadLine().ToUpper();

                if (dog1.Fur == "S" || dog1.Fur == "M" || dog1.Fur == "L")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Enter only the valid options: S/M/L");
                    Console.WriteLine();
                }
            } while (true);

            Console.WriteLine("------------------ Choose extra services ------------------");
            Console.WriteLine("Enter the option (1) to cut the nails - R$10.00");
            Console.WriteLine("Enter the option (2) to brush the teeth - R$12.00");
            Console.WriteLine("Enter the option (3) to clean the dog's ears - R$15.00");
            Console.WriteLine("Enter the option (0) if you don't want any additional services");

            string extra;
            do
            {
                Console.Write(">> ");
                extra = Console.ReadLine();
            
               
                switch (extra)
                {
                    case "1":
                        dog1.ExtraValue += 10.00;
                        break;
                    case "2":
                        dog1.ExtraValue += 12.00;
                        break;
                    case "3":
                        dog1.ExtraValue += 15.00;
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Enter only the valid options: (0) - (1) - (2) - (3)");
                        break;
                }
            } while (extra != "0");

            Console.WriteLine();
            Console.WriteLine($"Value to pay: ${dog1.Calculate().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}