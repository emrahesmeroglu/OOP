using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class AutoCredit : ICreditManager
    {
        public void ApplyForCredit()
        {
            Console.WriteLine("Auto Credit Applied!");
        }

        public void CalculateInterestRate()
        {
            // Do AutoCredit Math

            Console.WriteLine("Auto Credit Rate Calculated!");
        }
    }
}
