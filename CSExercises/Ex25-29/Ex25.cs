namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
        Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());


            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

                Console.Write("The factorial of the number is " + factorial);
                Console.ReadLine();
            }
        }
    }
}
       
