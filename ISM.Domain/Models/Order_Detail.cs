using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM.Domain.Models
{
    public class Order_Detail
    {
        public int Id { get; set; }
        public long QuantityOrdered { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int StorageId { get; set; }
        public Storage Storage { get; set; }
    }
}
