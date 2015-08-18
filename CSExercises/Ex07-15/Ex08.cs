using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a temperature:");
            double temperature = Convert.ToDouble(Console.Read());
            double tempInF = ((1.8*temperature) + 32);
            Console.WriteLine(tempInF);
        }
    }
}
        
