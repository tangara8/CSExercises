using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
           int factorial = 1;
            for (int i = 0; i < n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    
        public static void Main (String [] args){
            
            Console.Write("Pls enter a number");
            long n = Convert.ToInt32(Console.ReadLine());
            Factorial(n);
        }
    }
}

