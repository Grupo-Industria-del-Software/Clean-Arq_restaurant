using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : Person
    {
        public Client(string name, int id, string phone) : base(name, id, phone)
        {
        }

    }
}
