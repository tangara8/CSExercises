using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



﻿namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
        int[] numbers = new int[20] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i, j, k = 0, x = 0, temp;
            for (i = 0; i < numbers.Length - 1; i++)
            {
                x = numbers[i + 1];
                for (j = i + 1; j < numbers.Length; j++)
                {
                    if (x < numbers[j])
                    {
                        x = numbers[j];
                        k = j;
                    }
                }
                if (numbers[i] < x)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[k];
                    numbers[k] = temp;
                }
            }
            Console.WriteLine("Descending order:");
            for (i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadLine();
        }    
        }
    }

