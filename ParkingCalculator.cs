using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCalculator
{
    public class ParkingCalculator
    {
        public static double CalculateParkingFee(int hours)
        {
            double result = 0;
            // TODO: Uzupełnij implementację kalkulatora opłat za parkowanie

            switch (hours)
            {

                case (<= 1):
                    result = 5;
                    break;
                case (> 1):
                    result = (hours * 3) + 2;
                    break;
                default:
                    Console.WriteLine("Wrong value");
                    break;

            }

            return result;
        }
    }
}
