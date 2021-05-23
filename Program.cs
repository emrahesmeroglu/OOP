using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            IndividualCustomer cust1 = new IndividualCustomer();
            CorporateCustomer cust2 = new CorporateCustomer();

            CustomerManager.Add(cust1);
            CustomerManager.Add(cust2);

            ICreditManager housingCredit = new HousingCredit();
            ICreditManager autoCredit = new AutoCredit();

            housingCredit.CalculateInterestRate();
            autoCredit.CalculateInterestRate();

            ILoggerService dbLog = new DataBaseLoggerService();
            ILoggerService fileLog = new FileLoggerService();

            ApplyingManager.ApplyForCredit(housingCredit,dbLog);
            ApplyingManager.ApplyForCredit(autoCredit,fileLog);

            List<ICreditManager> credits = new List<ICreditManager>();
            credits.Add(housingCredit);
            credits.Add(autoCredit);

            ApplyingManager.CreditPreNotification(credits);
        }
    }
}
