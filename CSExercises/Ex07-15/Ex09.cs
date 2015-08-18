using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
             Console.Write("Input a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int xSq = x * x;
            Console.WriteLine("Y = " + (2*(xSq) - (4*x) + 3))
        }
    }
}
