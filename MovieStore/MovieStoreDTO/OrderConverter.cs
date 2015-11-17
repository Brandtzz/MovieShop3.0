using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreDAL;

namespace MovieStoreDTO
{
    public class OrderConverter : AbstractDTOConverter<Order, OrderDto>
    {
        public override OrderDto Convert(Order order)
        {
            var dto = new OrderDto()
            {
                Id = order.Id,
                Date = order.Date,
                CustomerId = order.CustomerId
            };
            return dto;
        }  
    } 
}
