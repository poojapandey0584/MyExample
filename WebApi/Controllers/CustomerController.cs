using Model.Model;
using MyExampleService;
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

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        // GET: api/Customer
        public HttpResponseMessage Get()
        {
            var customers = _customerService.Get();
            if (customers != null)
                return Request.CreateResponse(HttpStatusCode.OK, customers);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound
                                    , "No customers found");
        }

        // GET: api/Customer/5
        public HttpResponseMessage Get(string id)
        {
            var customer = _customerService.Get(id);
            if (customer != null)
                return Request.CreateResponse(HttpStatusCode.OK, customer);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound
                                    , "Customer with Id " + id + " does not exist");
        }

        // POST: api/Customer
        public HttpResponseMessage Post([FromBody]Customer customer)
        {
            _customerService.Add(customer);

            var message = Request.CreateResponse(HttpStatusCode.Created);
            message.Headers.Location = new Uri(Request.RequestUri + customer.Id);
            return message;
        }


    }
}

