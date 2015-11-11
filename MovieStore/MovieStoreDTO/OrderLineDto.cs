using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreDTO
{
    [DataContract(IsReference = true)]
    public class OrderLineDto
    {
        private int amount;

        [DataMember]
        public int Amount
        {
            get { return amount; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Amount must be above 1");
                }
                amount = value;
            }
        }
        [DataMember]
        public int MovieId { get; set; }
        [DataMember]
        public MovieDto Movie { get; set; }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public OrderDto Order { get; set; }
        public double GetOrderLineSum()
        {
            return amount*Movie.Price;
        }
    }
}
