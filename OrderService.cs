using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class OrderService
    {
        public void ProcessOrder(Order order)
        {
            order.PaymentMethod.Pay(order.TotalPrice);

            Console.WriteLine("Order processed successfully!");
            Console.WriteLine("Notification sent to customer.");
        }
    }
}
