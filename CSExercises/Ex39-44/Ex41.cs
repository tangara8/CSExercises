using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




﻿namespace CSExercises
{
    public class Ex41
    {
        
        public static void Main(string[] args)
        {

            Console.Write("Pls enter a string :");
            String s1 = Convert.ToString(Console.ReadLine());
            Console.Write("Pls enter a string :");
            String s2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("{0}", InString(s1, s2));
            Console.Read();
        }
    
        public static bool InString(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                return true;
            }
            else { 
            return false;
        }
            for (int i = 0; i < s1.Length; i++){
                for (int j = 0; j < s2.Length; j++){
                    if (s1[i].CompareTo(s2[j]) == 0) // the two strings are the same
                    {
                        return true;
                    }else {
                        return false;
                    }}}}
    }
}
    
