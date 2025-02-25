using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.PaymentMethot
{
    public class CreditCardPayment : IPay
    {
        private ILogger _logger;

        public CreditCardPayment(ILogger logger)
        {
            _logger = logger;
        }

        public Invoice Pay(Client client, Order order)
        {
            _logger.Log($"{client.Name} pagó la factura con tarjeta de credito");
            return new Invoice(order);
        }
    }
}
