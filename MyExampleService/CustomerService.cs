using Model.Model;
using MyExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleService
{
    public class CustomerService
    {
        private CustomerRepository _customerRepository;

        /// <summary>
        /// customerlist stores in-memory copy of repository (cached).
        /// </summary>
        private static List<Customer> _customerList;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public IEnumerable<Customer> Get()
        {
            if (_customerList == null)
            {
                _customerList = _customerRepository.Get().ToList();
            }
            return _customerList;
        }

        public IEnumerable<Customer> Get(string customerId)
        {
            if (_customerList != null)
                return _customerList.Where(c => c.Id == customerId);
            else return _customerRepository.Get(customerId);
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
            if (_customerList != null)
                _customerList.Add(customer);
        }

       
    }
}
