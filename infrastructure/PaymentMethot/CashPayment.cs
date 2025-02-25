using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.PaymentMethot
{
    public class CashPayment : IPay
    {
        private readonly ILogger _logger;

        public CashPayment(ILogger logger)
        {
            _logger = logger;
        }

        public Invoice Pay(Client client, Order order)
        {
            _logger.Log($"{client.Name} pago la factura en efectivo");
            return new Invoice(order);
        }
    }
}
