using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, string name)
        {
            Product = new Product(name, price);
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
