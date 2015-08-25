using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



﻿namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
             int[,] Marks = new int[12, 4]
            {    
                {56, 84, 68, 29},
                {94, 73, 31, 89},
                {41, 63, 36, 90},
                {99, 9, 18, 17},
                {62, 3, 65, 75},
                {40, 96, 53, 23},
                {81, 15, 27, 30},
                {21, 70, 100, 22},
                {88, 50, 13, 12},
                {48, 54, 52, 78},
                {64, 71, 67, 25},
                {16, 93, 46, 72},
                };
            int sum;

            for (int i = 0; i < Marks.GetLength(0); i++)
            {

                sum = 0; // putting sum here so that the Marks for row 1 will not be add on to row 2 and so on
                for (int j = 0; j < Marks.GetLength(1); j++)
                {
                    sum = sum + Marks[i, j];

                }

                Console.WriteLine("student {0}, {1}", i + 1, sum);
            }

            //b

            for (int j = 0; j < Marks.GetLength(1); j++)
            {
                sum = 0;
                for (int i = 0; i < Marks.GetLength(0); i++)
                {
                    sum = sum + Marks[i, j];

                }

                Console.WriteLine("subject {0}, {1}", j + 1, sum / 12);
            }
            //c

            int sum1 = 0;
            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                //  sum = 0;
                for (int j = 0; j < Marks.GetLength(1); j++)
                {
                    sum1 = sum1 + Marks[i, j];
                }
            }
                Console.WriteLine("{0}", sum1/48);
            }
        }
    }


    



    
        
