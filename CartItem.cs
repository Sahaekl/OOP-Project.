using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class CartItem
    {

        public int Quantity { get; set; }
        public Product Product { get; set; }

        public CartItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
    }
}
