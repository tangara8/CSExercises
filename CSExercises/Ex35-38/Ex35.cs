using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            int totalVowels = 0;
            
            Console.WriteLine("Enter a phrase :");
            String phrase = Console.ReadLine();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u')
                {
                    totalVowels++;
                }
            }
            Console.WriteLine("Number of vowels: {0}", totalVowels);
            Console.ReadLine();

            //b
            
          
            Console.WriteLine("Please enter a phrase:");
            string s1 = Console.ReadLine();

            char[] a = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int  j, k = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                k = 0;
                for (j = 0; j < s1.Length; j++)
                {
                    if (s1[j] == a[i])
                    {
                        k++;
                    }
                }
                Console.WriteLine("Number of {1}:{0}", k, a[i]);
                Console.ReadLine();
            }
            }
        }
        
