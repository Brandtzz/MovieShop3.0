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
    public class OrderController : ApiController
    {
        OrderConverter orderConverter = new OrderConverter();
        DALFacade dalFacade = new DALFacade();

        public IEnumerable<OrderDto> GetOrders()
        {
            var order = dalFacade._orderRepository.GetAll();
            return orderConverter.Convert(order);
        }

        public OrderDto GetOrder(int id)
        {
            var order = dalFacade._orderRepository.Get(id);
            return orderConverter.Convert(order);
        }

        public OrderDto PostOrder(OrderDto orderDto)
        {
            return orderDto;
        }

        public OrderDto PutOrder(Order order)
        {

            var orders = dalFacade._orderRepository.Edit(order);
            return orderConverter.Convert(orders);
        }

        public OrderDto DeleteOrder(int id)
        {
            var order = dalFacade._orderRepository.Remove(id);
            return orderConverter.Convert(order);
        }
    }
}

