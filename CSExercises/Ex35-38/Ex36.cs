using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Please write a wor: ");
            string word = Console.ReadLine();
                      
            int i;
            
            bool yes = true;

            for (i = 0; i <= word.Length / 2; i++)
            {
                
                if ((word.Substring(i, 1) == (word.Substring(word.Length - 1 - i, 1))))
                {
                    yes = true;
                }
                else
                {
                    yes = false;
                    break;
                }
                
            }
            if (yes)
            {
                Console.Write("Word is pandirome");
            }
            else
            {
                Console.Write("Word is not pandirome");
            }
        }
    }
}


        
