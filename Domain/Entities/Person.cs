using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }

        protected Person(string name, int id, string phone)
        {
            Name = name;
            Id = id;
            Phone = phone;
        }

    }
}
