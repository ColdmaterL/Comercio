using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Orders.Entities;
using Orders.Entities.Enums;

namespace Orders.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItens)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Price:F2}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal():F2}");
            }
            sb.AppendLine($"Total price: ${Total():F2}");
            return sb.ToString();
        }
    }
}
