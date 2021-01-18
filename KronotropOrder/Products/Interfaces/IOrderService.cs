using KronotropOrder.Products.Models;
using System.Collections.Generic;

namespace KronotropOrder.Products.Interfaces
{
    public interface IOrderService
    {
        public OrderList GetOrderList();
        public OrderList AddNewOrderItem(Order item);
        public OrderList RemoveOrderItem(int id);

    }
}
