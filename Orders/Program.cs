using System;
using System.Collections.Generic;
using System.Text;
using Orders.Entities;
using Orders.Entities.Enums;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Order Pedido;
            Client Cliente;
            OrderStatus StatusDoPedido;
            OrderItem ItemPedido;
            int NumeroDePedidos, i, QuantidadeDeProdutos;
            double PrecoProduto;
            string NomeCliente, EmailCliente, NomeProduto;
            DateTime DataDeNascimento;

            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            NomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            EmailCliente = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DataDeNascimento = DateTime.Parse(Console.ReadLine());
            Cliente = new Client(NomeCliente, EmailCliente, DataDeNascimento);

            Console.WriteLine("Enter order data; ");
            Console.Write("Status: ");
            StatusDoPedido = Enum.Parse<OrderStatus>(Console.ReadLine());
            Pedido = new Order(DateTime.Now, StatusDoPedido, Cliente);

            Console.Write("How many itens to this order? ");
            NumeroDePedidos = int.Parse(Console.ReadLine());
            for (i = 0; i < NumeroDePedidos; i++)
            {
                Console.Write("Product Name: ");
                NomeProduto = Console.ReadLine();
                Console.Write("Product Price: ");
                PrecoProduto = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                QuantidadeDeProdutos = int.Parse(Console.ReadLine());
                ItemPedido = new OrderItem(QuantidadeDeProdutos, PrecoProduto, NomeProduto);
                Pedido.OrderItens.Add(ItemPedido);
            }
            Console.WriteLine($"\n{Pedido}");
        }
    }
}
