﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double myInt1;           

            Console.WriteLine("Please enter a number :");

            myInt1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(myInt1));         
            Console.ReadLine();
        }
    }
}
