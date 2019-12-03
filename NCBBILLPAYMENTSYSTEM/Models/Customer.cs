using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.Models
{
    public class Customer
    {
        [Obsolete]
        public Customer() { }
        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }
        public string Name { get; protected set; }
        public Address Address { get; protected set; }
        public long Id { get; protected set; }
        public ICollection<Account> Accounts { get; protected set; }
    }
}