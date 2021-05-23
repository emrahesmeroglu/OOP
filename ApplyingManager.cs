using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ApplyingManager
    {                                     //Dependency Injection  
        public static void ApplyForCredit(ICreditManager creditManager,ILoggerService loggerService)
        {

            creditManager.CalculateInterestRate();
            loggerService.Log();
            creditManager.ApplyForCredit();
        }

        public static void CreditPreNotification(List<ICreditManager> credits)
        {
            foreach(ICreditManager credit in credits)
            {
                credit.CalculateInterestRate();
            }
        }
    }
}
