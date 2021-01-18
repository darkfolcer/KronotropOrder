﻿using KronotropOrder.Products.Interfaces;
using KronotropOrder.Products.Models;

namespace KronotropOrder.Products.Services
{
    public class MenuService : IMenuService
    {
        Menu _menu { get; set; }

        public MenuService()
        {
            _menu = new Menu();
        }
        public Menu GetMenu()
        {
            return _menu;
        }
    }
}
