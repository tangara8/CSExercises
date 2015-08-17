using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random number = new Random();
            int secretNumber = number.Next(10); // between 0 and 9
            int guess;
            
            do
            {       
                int noOftimes = 0;
                Console.WriteLine("Enter a number :");
                guess = Convert.ToInt32(Console.ReadLine());
                noOftimes++;
                if (noOftimes >= 2)
                {
                    Console.WriteLine("You are a Wizard!");
                    Console.ReadLine();
                }
                else if (noOftimes >= 3 || noOftimes <= 5)
                {
                    Console.WriteLine("You are a a good guess");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are lousy");
                    Console.ReadLine();
                }
                Console.WriteLine("Try again");
               // noOftimes = noOftimes+ 1;
            }
            while (guess != secretNumber);     

            }
            
        }
    }
        
