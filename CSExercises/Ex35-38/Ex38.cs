using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


﻿namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
             int[] Marks = new int[5] { 63, 29, 75, 82, 55 };

            int temp = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                for (int j = i + 1; j < Marks.Length; j++) // descending order
                {
                    if (Marks[i] < Marks[j])
                    {
                        temp = Marks[j];
                        Marks[j] = Marks[i];
                        Marks[i] = temp;
                    }
                }
                Console.WriteLine("{0}", Marks[i]);
            }
            Console.ReadLine();                                
          
                     
            
            String[] Name = new String[5] { "John", "Venkat", "Mary", "Victor", "Betty" };

            String temp1 = "";
            for (int k = 0; k < Name.Length; k++)
            {
                for (int m = k + 1; m < Name.Length; m++)
                {

                    if (Name[k].CompareTo(Name[m]) == 1) // ==1 means greater than
                    { 
                        temp1 = Name[m];
                        Name[m] = Name[k];
                        Name[k] = temp1;
                    }
                }

                Console.WriteLine("{1}", Name[k]);
            }
            Console.ReadLine();

        }
    }
}
