using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public List<ProductRecord> Products { get; set; }
        public string Status { get; set; }
        public Client Client { get; set; }

        public Order(int orderId, Client client)
        {
            this.OrderId = orderId;
            this.Products = new List<ProductRecord>();
            this.Status = "Pendiente";
            this.Client = client;
        }

        public abstract decimal CalculateTotal();
    }
}
