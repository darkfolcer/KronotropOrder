using KronotropOrder.Products.Interfaces;
using KronotropOrder.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KronotropOrder.Products.Services
{
    public class AdditionService : IAdditionService
    {
        List<Addition> tempData { get; set; }

        public AdditionService()
        {
            tempData = new List<Addition>();
            tempData.Add(new Addition { Id = 1, Name = "Milk" });
            tempData.Add(new Addition { Id = 1, Name = "Chocalate sauce" });
            tempData.Add(new Addition { Id = 1, Name = "Hazelnut Syrup" });
        }
        public void Add(Addition addition)
        {
            tempData.Add(addition);
        }

        public List<Addition> GetAll()
        {          
            return tempData;
        }

        public Addition GetById(int id)
        {
           return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(Addition addition)
        {
            GetAll().Remove(addition);
        }
    }
}
