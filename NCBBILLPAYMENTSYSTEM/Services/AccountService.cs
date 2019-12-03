using NCBBILLPAYMENTSYSTEM.Models;
using NCBBILLPAYMENTSYSTEM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBBILLPAYMENTSYSTEM.Services
{
    public class AccountService
    {
        private AccountsContext db = new AccountsContext();

        public bool DoesAccountExist(string accountId)
        {
            return db.Accounts.Any(account => account.Reference == accountId);
        }

        public void AddPayment(string accountId, PaymentRequest request)
        {
            var account = db.Accounts.SingleOrDefault(a => a.Reference == accountId);
            account?.Payments.Add(new Payment(request.AmountInCents, request.DatePaid, account));
            db.SaveChanges();
        }

        public Account CreateAccount(string reference, string type, string name, string line1, string line2)
        {
            var address = new Address(line1, line2);
            var customer = new Customer(name, address);
            var account = new Account(reference, customer, type);
            return account;
        }
    }
}