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
            
            Console.Write("Enter x1 : ");
            Console.Write("Enter y1 : ");
            Console.Write("Enter x2 : ");
            Console.Write("Enter y2 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Distance is " + (Math.Sqrt(x2 - x1) * (x2 - x1) + Math.Sqrt(y2 - y1) * (y2 - y1)));
            Console.ReadLine();
        }
    }
}
