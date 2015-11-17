using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieStoreDAL;
using MovieStoreDTO;

namespace MovieStoreRestApi.Controllers
{
    public class CustomerController : ApiController
    {
        CustomerConverter customerConverter = new CustomerConverter();
        DALFacade dalFacade = new DALFacade();

        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customer = dalFacade._customersRepository.GetAll();
            return customerConverter.Convert(customer);
        }

        public CustomerDto GetCustomer(int id)
        {
            var customer = dalFacade._customersRepository.Get(id);
            return customerConverter.Convert(customer);
        }

        public CustomerDto PostCustomer(CustomerDto customerDto)
        {
            return customerDto;
        }

        public CustomerDto PutCustomer(Customer customer)
        {

            var customers = dalFacade._customersRepository.Edit(customer);
            return customerConverter.Convert(customers);
        }

        public CustomerDto DeleteCustomer(int id)
        {
            var customer = dalFacade._customersRepository.Remove(id);
            return customerConverter.Convert(customer);
        }
    }
}
