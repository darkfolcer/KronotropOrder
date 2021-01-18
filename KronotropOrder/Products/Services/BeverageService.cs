using KronotropOrder.Products.Interfaces;
using KronotropOrder.Products.Models;
using System.Collections.Generic;
using System.Linq;

namespace KronotropOrder.Products.Services
{
    public class BeverageService : IBeverageService {

        List<Beverage> tempData { get; set; }

        public BeverageService()
        {
            tempData = new List<Beverage>();
            tempData.Add(new Beverage { Id = 1, Name = "Black Coffee" });
            tempData.Add(new Beverage { Id = 2, Name = "Latte" });
            tempData.Add(new Beverage { Id = 3, Name = "Mocha" });
            tempData.Add(new Beverage { Id = 4, Name = "Tea" });
        }

        public List<Beverage> GetAll()
        {
            return tempData;
        }
        public void Add(Beverage beverage)
        {
            tempData.Add(beverage);
        }
   

        public Beverage GetById(int id)
        {
           return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Beverage beverage)
        {
            GetAll().Remove(beverage);
        }
    }
}
