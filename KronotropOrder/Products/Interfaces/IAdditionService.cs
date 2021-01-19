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
        public List<Addition> Add(Addition addition);
        public List<Addition> Remove(Addition addition);
    }
}
