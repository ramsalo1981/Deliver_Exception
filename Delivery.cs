using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExeptions
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

        public override string ToString()
        {
            return $"{{\n   Id: {Id},\n   Customer: {CustomerName},\n   Address: {Address},\n   Status: {DeliveryStatus}\n}}";
        }
    }
}
