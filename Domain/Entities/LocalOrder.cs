using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LocalOrder : Order
    {

        public LocalOrder(int orderId, Waiter waiter, Client client) : base(orderId, client)
        {
        }

        public override decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var productRecord in Products)
            {
                total += productRecord.Product.Price * productRecord.Quantity;
            }

            return total;
        }
    }
}
