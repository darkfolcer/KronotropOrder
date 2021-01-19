using KronotropOrder.Products.Models;
using System.Collections.Generic;

namespace KronotropOrder.Products.Interfaces
{
    public interface IBeverageService
    {
        public List<Beverage> GetAll();
        public Beverage GetById(int id);
        public List<Beverage> Add(Beverage beverage);
        public List<Beverage> Remove(Beverage beverage);
    }
}
