using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double Salary;
            double TotalIncome;
            Console.WriteLine("Enter your salary:");
            Salary = Convert.ToDouble((Console.ReadLine()));
            double HousingAllowance = 0.1 * Salary;
            double TransportAllowance = 0.03 * Salary;
            TotalIncome = Salary + HousingAllowance + TransportAllowance;            
            Console.WriteLine("Your TotalIncome is : " + TotalIncome);
        }
    }
}
