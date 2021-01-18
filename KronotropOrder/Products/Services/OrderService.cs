using KronotropOrder.Products.Interfaces;
using KronotropOrder.Products.Models;
using System.Linq;

namespace KronotropOrder.Products.Services
{
    class OrderService : IOrderService
    {
        OrderList _orders { get; set; }

        public OrderService()
        {
            _orders = new OrderList();
        }

        public OrderList GetOrderList()
        {
            return _orders;
        }
        public OrderList AddNewOrderItem(Order item)
        {
            _orders.Items.Add(item);
            return _orders;
        }

        public OrderList RemoveOrderItem(int itemId)
        {
            var orderItem = _orders.Items.FirstOrDefault(x => x.Id == itemId);
            _orders.Items.Remove(orderItem);
            return _orders;
        }

     
    }
}
