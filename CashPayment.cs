using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class CashPayment : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Cash.");
        }
    }
}
