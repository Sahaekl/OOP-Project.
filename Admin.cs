using System;
using System.Collections.Generic;

namespace test
{
    internal class Admin : User
    {
        public Admin(string id, string username, string password)
            : base(id, username, password)
        {
        }

        public void AddProduct(List<Product> products, Product product)
        {
            products.Add(product);
            Console.WriteLine($"Admin '{Username}' added product: {product.Name}");
        }

        public void UpdateProduct(Product product, string name, double price, int stockQuantity)
        {
            product.Name = name;
            product.Price = price;
            product.StockQuantity = stockQuantity;
            Console.WriteLine($"Admin '{Username}' updated product: {product.Name}");
        }

        public void DeleteProduct(List<Product> products, Product product)
        {
            products.Remove(product);
            Console.WriteLine($"Admin '{Username}' deleted product: {product.Name}");
        }
    }
}
