using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.Models
{
    public class Address
    {
        public Address(string line1, string line2)
        {
            Line1 = line1;
            Line2 = line2;
        }
        public long Id { get; protected set; }
        public string Line1 { get; protected set; }
        public string Line2 { get; protected set; }
    }
}