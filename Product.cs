using System;

namespace test
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(int id, string name, double price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
    }
}
