using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



﻿namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            public static void Main(string[] args)
        {
           

            for (int i = 2; i <= 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {                    
                    if (i % j == 0)
                    {
                        sum +=j;
                    }
                    if (sum == i)
                    {
                        Console.WriteLine("The pefect number are : {0}", sum);
                        break;


                    }
                        //Console.Read();
                    }
                }
            }
        }
    }

        
