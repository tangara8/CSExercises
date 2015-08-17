namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Please enter your name:");
            String gender;
            name = Console.ReadLine();
            Console.WriteLine("Please enter your gender(M/F):");
            gender = Console.ReadLine();
            if (gender == "M" || gender == "m")
                Console.WriteLine("Good Morning Mr " + name);
                else 
                Console.WriteLine("Good Morning Ms " + name);
            Console.ReadLine();    
        }
    }
        }
        
