Using System;

﻿namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
             int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int X;
            int HCF;
            int LCM;

            do
            {
                if (A > B)
                {
                    X = A - B;
                    Console.WriteLine();
                    HCF = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    X = B - A;
                    Console.WriteLine();
                    HCF = Convert.ToInt32(Console.ReadLine());
                }
                LCM = (A * B) / HCF;
                Console.WriteLine();
                Console.ReadLine();
            }
            while (A == B);
            }}
    }


        
