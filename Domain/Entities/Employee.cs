using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Employee : Person
    {
        public int EmployeeId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }

        public Employee(string name, int id, string phone, int employeeId) : base(name, id, phone)
        {
            this.EmployeeId = employeeId;
        }
    }
}
