using Exercicios.Entities.Enums;
using System.Text;

namespace Exercicios.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(OrderStatus orderStatus, Client client)
        {
            Moment = DateTime.Now;
            Status = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) 
        { 
            Items.Remove(item); 
        }

        public double Total()
        {
            double sum = 0.00;

            foreach (var item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString());
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");

            foreach(var item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: " + Total().ToString());

            return sb.ToString();
        }
    }
}