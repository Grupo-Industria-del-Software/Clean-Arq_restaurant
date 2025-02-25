using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PaymentService
    {
        private readonly IPay _pay;

        public PaymentService(IPay pay)
        {
            _pay = pay;
        }

        public Invoice Pay(Client client, Order order)
        {
            return _pay.Pay(client, order);
        }
    }
}
