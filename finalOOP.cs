using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test
{
    internal class Program
    {



        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Admin admin = new Admin("1", "Admin", "1234");

            Product phone = new Product(1, "iPhone", 30000, 5);
            Product airPods = new Product(2, "AirPods", 5000, 10);

            admin.AddProduct(products, phone);
            admin.AddProduct(products, airPods);

            Customer customer = new Customer("2", "Ahmed", "password");

            customer.Cart.AddToCart(new CartItem(1, phone));
            customer.Cart.AddToCart(new CartItem(2, airPods));

            customer.Cart.ViewCart();

            Payment payment = new CreditCardPayment();
            customer.Checkout(payment);

            Console.WriteLine("\nRemaining stock:");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name}: {product.StockQuantity}");
            }



        }
    }
}
