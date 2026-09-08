using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Order
    {
        public List<CartItem> Items { get; set; }
        public double TotalPrice { get; set; }
        public Payment PaymentMethod { get; set; }

        public Order()
        {
            Items = new List<CartItem>();
            TotalPrice = 0;
        }

        public void AddItem(CartItem item)
        {
            Items.Add(item);
        }

        public double CalculateTotal()
        {
            double total = 0;

            foreach (CartItem item in Items)
            {
                total += item.Product.Price * item.Quantity;
            }

            return total;
        }
    }
}
