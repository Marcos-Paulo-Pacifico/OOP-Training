using System.Globalization;
using System.Text;

namespace Exercicios.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }   
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = Product.Price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product.Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantity: " + Quantity + ", ");
            sb.Append("Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}