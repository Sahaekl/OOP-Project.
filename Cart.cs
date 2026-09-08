using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Cart
    {

        public List<CartItem> Items { get; set; }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddToCart(CartItem item)
        {
            Items.Add(item);
        }

        public void RemoveFromCart(CartItem item)
        {
            Items.Remove(item);
        }

        public void ViewCart()
        {
            foreach (CartItem item in Items)
            {
                Console.WriteLine($"Product: {item.Product.Name}");
                Console.WriteLine($"Quantity: {item.Quantity}");
                Console.WriteLine($"Subtotal: {item.Product.Price * item.Quantity}");
                Console.WriteLine();
            }

            Console.WriteLine($"Cart total: {CalculateTotal()}");
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
