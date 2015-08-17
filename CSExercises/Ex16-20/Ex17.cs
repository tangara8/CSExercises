using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            public static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Please enter your name:");
            String gender;
            name = Console.ReadLine();
            Console.WriteLine("Please enter your gender(M/F):");
            gender = Console.ReadLine();
            //int age;
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());            
            if ((gender == "M" || gender == "m") && (age >= 40))
                Console.WriteLine("Good Morning Uncle " + name);
            else
                Console.WriteLine("Good Morning Mr " + name);
            if ((gender == "F" || gender == "f") && (age >= 40))
                Console.WriteLine("Good Morning Aunty " + name);
            else
                Console.WriteLine("Good Morning Ms " + name);
            Console.ReadLine();    
        }
    }
}
        
