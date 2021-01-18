using KronotropOrder.Products.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KronotropOrder.Products.Interfaces
{
    public interface IAdditionService
    {
        public List<Addition> GetAll();
        public Addition GetById(int id);
        public void Add(Addition addition);
        public void Remove(Addition addition);
    }
}
