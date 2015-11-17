using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreDTO
{
    [DataContract(IsReference = true)]
    public class AddressDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]
        public int ZipCode { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}
