using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DeliveryOrder : Order
    {
        public string DeliveryAddress { get; set; }
        public decimal DeliveryCost { get; set; }

        public DeliveryOrder(int orderId, string address, Client client, decimal deliveryCost) : base(orderId, client)
        {
            DeliveryCost = deliveryCost;
            DeliveryAddress = address;
        }

        public override decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var productRecord in Products)
            {
                total += productRecord.Product.Price * productRecord.Quantity;
            }

            return total + DeliveryCost;
        }
    }
}
