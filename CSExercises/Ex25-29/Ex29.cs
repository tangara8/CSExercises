using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                } }
                if (sum == number)
                {
                    Console.WriteLine("Perfect Number");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Not perfect number");
                    Console.Read();
                }
            }
        }
    }
        
