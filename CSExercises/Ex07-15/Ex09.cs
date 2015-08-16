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
            int x;
            int xSq = x * x;
            Console.Write("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            ConsoleWriteLine("Y = " + (2*(x*x)) - (4*x) + 3));
        }
    }
}
