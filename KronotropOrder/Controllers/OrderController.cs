using KronotropOrder.Products.Interfaces;
using KronotropOrder.Products.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KronotropOrder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IBeverageService _beverageService;
        private readonly IAdditionService _additionService;
        public OrderController(IOrderService orderService, IBeverageService beverageService, IAdditionService additionService)
        {
            _orderService = orderService;
            _additionService = additionService;
            _beverageService = beverageService;
        }
        [HttpGet]
        [Route("/api/orders/list")]
        public OrderList GetOrderList()
        {
            OrderList orders = _orderService.GetOrderList();
            return orders;
        }

        [HttpGet]
        [Route("/api/orders/add")]
        public OrderList AddNewOrderItem(int beverageId, [FromQuery] int[] additionIds)
        {
            /*
             * Additionları Queryden integer array olarak alıyorum ve listeye çevirip orders'a ekliyorum.
             * Örneğin 2x milk için addition listte 2xMilk olacak. 
             */

            List<Addition> additions = new List<Addition>();
            for (int i = 0; i < additionIds.Length; i++)
            {
                additions.Add(_additionService.GetById(additionIds[i]));
            }

           var _beverage = _beverageService.GetById(beverageId);
           return _orderService.AddNewOrderItem(new Order { beverage = _beverage, addition = additions });
        }
        [HttpGet]
        [Route("/api/orders/remove")]
        public OrderList RemoveOrderItem(int id)
        {
            return _orderService.RemoveOrderItem(id);            
        }




    }
}
