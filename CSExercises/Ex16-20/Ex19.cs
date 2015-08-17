using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance travelled in km :");

            double distanceTravelledInKilometre = Convert.ToDouble(Console.ReadLine());
            double distanceTravelledInMetre = distanceTravelledInKilometre * 100;
            double minCharges = 2.40;
            double nextCharge = 85 * 0.04;
            double distanceTravelledAfter = (distanceTravelledInMetre - 90) * 0.05; // for distance travlled more than 9km
            double totalCost;
            if (distanceTravelledInKilometre >= 9)
            {

                totalCost = minCharges + nextCharge + distanceTravelledAfter;
                Console.WriteLine("${0:.00}", totalCost);
                Console.ReadLine();
            }
            else if (distanceTravelledInKilometre < 9)
            {
                totalCost = minCharges + nextCharge;
                Console.WriteLine("${0:.00}", totalCost);
                Console.ReadLine();
            }
        }
    }
}
       
