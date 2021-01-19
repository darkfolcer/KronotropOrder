using KronotropOrder.Products.Models;
using System.Collections.Generic;

namespace KronotropOrder.Products.Models
{
    public class OrderList
    {

        public OrderList()
        {
            items = new List<Order>();
        }

        public List<Order> items { get; private set; }
    }
}
