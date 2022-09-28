using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    abstract class Account
    {
        public static string customer { get; set; }
        public static double balance { get; set; }
        public static double monthlyRateOfInterest { get; set; }


        public abstract void DepositMoney();
        public abstract void WithdrawMoney();
        
    }
}
