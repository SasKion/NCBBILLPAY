using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.ViewModels
{
    public class PaymentRequest
    {
        public long AmountInCents { get; }
        public DateTime DatePaid { get; }
    }
}