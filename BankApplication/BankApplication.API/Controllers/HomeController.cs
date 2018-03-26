using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApplication.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankApplication.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        BankApplicationContext _context;
        public HomeController(BankApplicationContext context)
        {
            _context = context;
        }
        // GET: api/Home
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            //Account usr = new Account()
            //{
            //    AccountNo = 2,
            //    AccType = "Savings",
            //    Balance = 1
            //};
            //_context.Accounts.Add(usr);
            //_context.SaveChanges();
            var accList = _context.Accounts.ToList();
            Console.WriteLine(accList[0].AccID);
            return accList;
        }

        // GET: api/Home/5
        [HttpGet("{accNo}", Name = "Get")]
        public Account Get(int accNo)
        {
            Account reqAcc = _context.Accounts.FirstOrDefault(acc => acc.AccNo == accNo);
            return reqAcc;
        }
        
        // POST: api/Home
        [HttpPost]
        public void Post([FromBody]Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            RedirectToAction("Get");
        }
        
        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
