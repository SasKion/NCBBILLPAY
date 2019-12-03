using NCBBILLPAYMENTSYSTEM.Services;
using NCBBILLPAYMENTSYSTEM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NCBBILLPAYMENTSYSTEM.Controllers
{
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("api/accounts/{accountId}")]
        public IHttpActionResult IsAccountValid(string accountId)
        {
            var service = new AccountService();
            var exists = service.DoesAccountExist(accountId);
            return Ok(exists);
        }

        [HttpPost]
        [Route("api/accounts/{accountId}/payments")]
        public IHttpActionResult AddPayment(string accountId, [FromBody]ViewModels.PaymentRequest payment)
        {
            var service = new AccountService();

            service.AddPayment(accountId, payment);
            return Ok();
        }

        [HttpPost]
        [Route("api/accounts")]
        public IHttpActionResult AddAccount(CreateCustomerRequest request, string type)
        {
            var service = new AccountService();
            var account = service.CreateAccount(Guid.NewGuid().ToString(), type, 
                request.Name, request.Line1, request.Line2);

            return Created($"api/accounts/{account.Reference}", account);
        }
    }
}
