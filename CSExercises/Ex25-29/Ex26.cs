using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



﻿namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No\t Inverse \t Square Root \t Square ");
            
            for (int i = 1; i <= 10; i++) {
                double number = i;
                double inverse = 1 / number;
                double squareroot = Math.Sqrt(number);
                double square = number * number;
                   
                    Console.WriteLine("{0:0.0}\t  {1:0.00} \t  {2:0.00}\t {3:0.00}", number , inverse, squareroot, square);
            }    
                Console.ReadLine();

                } 
            }
        }
    
        
