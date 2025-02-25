using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Chef : Employee, IAttend
    {
        private readonly ILogger _logger;
        public Chef(string name, int id, string phone, int employeeId, ILogger logger) : base(name, id, phone, employeeId)
        {
            _logger = logger;
        }

        public void Attend(Order order)
        {
            order.Status = "Preparado";
            _logger.Log($"{this.Name} está preparando la orden numero: {order.OrderId}");
        }
    }
}
