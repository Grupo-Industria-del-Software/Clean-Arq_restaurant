using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Printers
{
    public class InvoicePrinter
    {
        private readonly ILogger _logger;

        public InvoicePrinter(ILogger logger)
        {
            _logger = logger;
        }   

        public void Print(Invoice invoice)
        {
            _logger.Log("----- FACTURA -----");
            _logger.Log($"Cliente: {invoice.Order.Client.Name} (ID: {invoice.Order.Client.Id})");
            _logger.Log("-------------------");
            _logger.Log($"Productos:");
            foreach (var product in invoice.Order.Products)
            {
                _logger.Log($"- {product.Product.Name} x{product.Quantity}: {product.Product.Price * product.Quantity:C}");
            }

            if (invoice.Order is DeliveryOrder deliveryOrder)
            {
                _logger.Log("-------------------");
                _logger.Log($"Costo de Entrega: {deliveryOrder.DeliveryCost:C}");
                _logger.Log("-------------------");
            }

            _logger.Log($"Total: {invoice.Order.CalculateTotal():C}");
            _logger.Log($"Fecha: {DateTime.Now}");
            _logger.Log("-------------------");
        }
    }
}
