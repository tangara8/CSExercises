using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int X1;
            int Y1;
            int X2;
            int Y2;

            Console.Write("Enter x1 : ");
            Console.Write("Enter y1 : ");
            Console.Write("Enter x2 : ");
            Console.Write("Enter y2 : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Distance is " + (Math.Sqrt(x2 - x1) * (x2 - x1) + Math.Sqrt(y2 - y1) * (y2 - y1)));
            Console.ReadLine();
        }
    }
}
