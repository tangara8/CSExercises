using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




﻿namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            
        for (int i = 5; i <= 10000; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        count++; // not prime number
                }
                if (count < 1) // prime
                {
                    Console.WriteLine("{0}", i);                  
                }

            }
        }
    }
}
