using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




﻿namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Pls enter a number : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if ((Number % 2 == 0) && (Number / Number == 1))
            {
                Console.WriteLine("The number is a prime number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number is not a prime number");
                Console.ReadLine();

            }
        }
    }
} 
        
