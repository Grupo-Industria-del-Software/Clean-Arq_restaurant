using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Waiter : Employee, IAttend
    {
        ILogger _logger;
        public Waiter(string name, int id, string phone, int employeeId, ILogger logger) : base(name, id, phone, employeeId)
        {
            _logger = logger;
        }

        public void Attend(Order order)
        {
            order.Status = "Entregado";
            _logger.Log($"{Name} entregó la orden numero {order.OrderId} en la mesa.");
        }
    }
}
