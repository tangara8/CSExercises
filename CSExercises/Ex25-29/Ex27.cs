using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
             //Console.Write("Input a number between -5 to 5 : ");
            // int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X\t Y");
            for (int x = -5; x < 5; x++)           
            {
                
                int xSq = x * x;
                int Y = 2 * (xSq) - (4 * x) + 3;            

                Console.WriteLine("{0}   {1}", x, Y);
            }
                Console.ReadLine();
        }
    }
        
