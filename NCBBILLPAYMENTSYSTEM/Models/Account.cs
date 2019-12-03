using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.Models
{
    public class Account
    {
        public Account(string reference, Customer customer, string type)
        {
            Reference = reference;
            BalanceInCents = 0;
            Owner = customer ?? throw new ArgumentNullException(nameof(customer));
            Payments = new List<Payment>();
            Type = Type;
        }
        public long Id { get; protected set; }
        public string Reference { get; protected set; }
        public long BalanceInCents { get; set; }
        public Customer Owner { get; protected set; }
        public ICollection<Payment> Payments { get; protected set; }
        public string Type { get; protected set; }
    }
}