﻿namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
        Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {

                int j = 1;
                j = j * i;
                Console.Write("The factorial of the number is" + j);
                Console.ReadLine();
            }
        }
    }
}
       
