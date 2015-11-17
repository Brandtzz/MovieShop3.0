using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieStoreDTO
{
    public class CustomerConverter : AbstractDTOConverter<Customer, CustomerDto>
    {
        public override CustomerDto Convert(Customer customer)
        {
            var dto = new CustomerDto()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
            };
            return dto;
        }
    }
}
