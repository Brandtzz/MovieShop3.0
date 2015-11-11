using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreDTO
{
    [DataContract(IsReference = true)]
    public class OrderDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public CustomerDto Customer { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public List<OrderLineDto> OrderLine{ get; set; }
        public double GetOrderSum()
        {
            return OrderLine.Sum(orderLine => orderLine.GetOrderLineSum());
        }
    }
}
