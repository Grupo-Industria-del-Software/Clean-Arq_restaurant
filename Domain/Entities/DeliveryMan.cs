using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DeliveryMan : Employee, IAttend
    {
        private readonly ILogger _logger;
        public DeliveryMan(string name, int id, string phone, int employeeId, ILogger logger) : base(name, id, phone, employeeId)
        {
            _logger = logger;
        }

        public void Attend(Order order)
        {
            DeliveryOrder? orderD = order as DeliveryOrder;

            _logger.Log($"{Name} entregó la orden numero {order.OrderId} en {orderD?.DeliveryAddress}.");
            order.Status = "Entregado";
        }
    }
}
