using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApi.Controllers
{
    public class CustomerController : ApiController
    {


        Customer[] customers = new Customer[]
        {
            new Customer { Id = 1, FName = "Pooja", LName = "Pandey", Address = "Cary" },
            new Customer { Id = 2, FName = "Pooja2", LName = "Pandey", Address = "Cary" },
            new Customer { Id = 3, FName = "Pooja3", LName = "Pandey", Address = "RTP" },
        };

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        public IHttpActionResult GetCustomer(int id)
        {
            var cust = customers.FirstOrDefault((p) => p.Id == id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }


        // POST: api/customers
        public void Post([FromBody]string value)
        {
            customers.ToList().Add(new Customer { Id = 1, FName = "Pooja", LName = "Pandey", Address = "Cary" });
        }

        // PUT: api/customer/5
        public void Put(int id, [FromBody]string value)
        {
            customers.ToList().Add(new Customer { Id = 1, FName = "Pooja", LName = "Pandey", Address = "Cary" });
        }

        // DELETE: api/customer/5
        public void Delete(int id)
        {
            customers.ToList().Add(new Customer { Id = 1, FName = "Pooja", LName = "Pandey", Address = "Cary" });
        }
    }
}

