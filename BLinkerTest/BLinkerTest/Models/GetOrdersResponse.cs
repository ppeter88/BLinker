using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.Models
{
    public class GetOrdersResponse
    {
        public string status { get; set; }
        public List<Order> orders { get; set; }

        public Order GetObject(int orderId)
        {
            var order = orders.SingleOrDefault(o => o.order_id == orderId);
            return order;
        }
    }
}
