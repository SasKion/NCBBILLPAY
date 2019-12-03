using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.Models
{
    public class Payment
    {
        public Payment(long amountInCents, DateTime datePaid, Account account)
        {
            AmountInCents = amountInCents;
            DatePaid = datePaid;
            DateReceived = DateTime.Now;
            Account = account ?? throw new ArgumentNullException(nameof(account));
        }
        public long Id { get; protected set; }
        public long AmountInCents { get; protected set; }
        public DateTime DatePaid { get; protected set; }
        public DateTime DateReceived { get; protected set; }
        public Account Account { get; protected set; }
    }
}