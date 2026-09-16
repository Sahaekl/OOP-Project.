using System;

namespace test
{
    internal class Customer : User
    {
        public Cart Cart { get; set; }

        public Customer(string id, string username, string password)
            : base(id, username, password)
        {
            Cart = new Cart();
        }

        public void Checkout(Payment paymentMethod)
        {
            Order order = new Order();

            foreach (CartItem item in Cart.Items)
            {
                order.AddItem(item);
                item.Product.StockQuantity -= item.Quantity;
            }

            order.TotalPrice = order.CalculateTotal();
            order.PaymentMethod = paymentMethod;

            OrderService orderService = new OrderService();
            orderService.ProcessOrder(order);

            Cart.Items.Clear();
        }
    }
}
