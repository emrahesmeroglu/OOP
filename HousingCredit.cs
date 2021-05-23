using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class HousingCredit : ICreditManager
    {
        public void ApplyForCredit()
        {
            Console.WriteLine("Housing Credit Applied!");

        }

        public void CalculateInterestRate()
        {
            //Do some housing math
            Console.WriteLine("Housing Credit Rate Calculated!");      
        }
    }
}
