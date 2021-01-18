using System.Collections.Generic;

namespace KronotropOrder.Products.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Beverage beverage { get; set; }
        public List<Addition> addition { get; set; }
    }
}
