using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





﻿namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            String[] Month = new String[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
                int[] Sales = new int[12] { 1000, 1250, 2200, 1200, 3400, 1000, 3500, 5000, 2000, 1000, 10000, 5400 };
                for (int i = 0; i <= 11; i++)

                Console.WriteLine("Enter sales for the month {0}\t {1}", i, Sales[i]);   
                Console.WriteLine("Maximum Sales : {0}", Month[10]); // note: have to put in {0} otherwise the figure won't show
                Console.WriteLine("Minimum Sales : {0}\t {1}\t {2}\t", Month[0], Month[5], Month[9]);
                int AverageSales = Sales[0] + Sales[1] + Sales[2] + Sales[3] + Sales[4] + Sales[5] + Sales[6] + Sales[7] + Sales[8] + Sales[9] + Sales[10] + Sales[11] / 12;
                Console.WriteLine("Average Sales: {0} ", AverageSales);
                Console.ReadLine();
        }
    }
}
