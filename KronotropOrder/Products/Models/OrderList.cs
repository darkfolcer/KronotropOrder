using KronotropOrder.Products.Models;
using System.Collections.Generic;

namespace KronotropOrder.Products.Models
{
    public class OrderList
    {

        public OrderList()
        {
            Items = new List<Order>();
        }

        public IList<Order> Items { get; private set; }
    }
}
