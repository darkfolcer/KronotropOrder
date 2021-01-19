using KronotropOrder.Products.Models;
using System.Collections.Generic;

namespace KronotropOrder.Products.Interfaces
{
    public interface IMenuService
    {
        public Menu GetMenu();
        public Menu AddNewAddition(Addition addition);
        public Menu AddNewBeverage(Beverage beverage);



    }
}
