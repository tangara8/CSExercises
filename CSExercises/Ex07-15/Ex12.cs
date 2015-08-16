using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double fixedCharge = 2.40;
            int distanceTravelled;
            Console.Write("Enter distance travelled : ");
            distanceTravelled = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("${0:N2}", (distanceTravelled * 0.4) + fixedCharge);           
            Console.ReadLine();
        }
        }
    }
}
