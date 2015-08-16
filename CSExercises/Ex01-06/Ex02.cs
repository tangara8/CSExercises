using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {

        public static void Main(string[] args)
        {
            int myInt1;

            Console.WriteLine("Please enter a number :");
            
            myInt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myInt1*myInt1);
        }
    }
}
