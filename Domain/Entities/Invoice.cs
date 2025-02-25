using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        public DateTime Date { get; set; }
        public Order Order { get; set; }

        public Invoice(Order order)
        {
            this.Date = DateTime.Now;
            this.Order = order;
        }
    }
}
