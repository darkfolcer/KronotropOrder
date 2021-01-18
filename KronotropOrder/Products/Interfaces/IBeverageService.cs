using KronotropOrder.Products.Models;
using System.Collections.Generic;

namespace KronotropOrder.Products.Interfaces
{
    public interface IBeverageService
    {
        public List<Beverage> GetAll();
        public Beverage GetById(int id);
        public void Add(Beverage beverage);
        public void Remove(Beverage beverage);
    }
}
