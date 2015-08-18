using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            
            double G = Convert.ToDouble((r.Next(1, N)));
            while(Math.Round(G*G, 5) > N+0.000005 || (Math.Round(G*G, 5)< N-0.000005))
            {
                G = (G + N/G)/2;
            }
        Console.Write("G is Correct");
        }
    }
}
