namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int number, remainder, sum = 0;
            Console.Write("Enter the no: ");
            number = int.Parse(Console.ReadLine());
            for(int i = number; i > 0, i = i/10)
            {
                remainder = i%10;
                sum = sum + remainer*remainder*remainder;
            }
            if (sum == number)
            {
                Console.Write("Enter no is an ArmStrong no");
            }
            else
                 Console.Write("Enter no is not an ArmStrong no");
                 Console.ReadLine();    
        }
    }
}
