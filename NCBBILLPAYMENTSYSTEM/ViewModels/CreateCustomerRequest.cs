using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.ViewModels
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
    }
}