using System.Collections.Generic;

namespace KronotropOrder.Products.Models
{
    public class Menu
    {
        public Menu()
        {
            //Default ürünlerin eklenmesi
            Beverages = new List<Beverage>();
            Beverages.Add(new Beverage { Id = 1, Name = "Black Coffee" });
            Beverages.Add(new Beverage { Id = 2, Name = "Latte" });
            Beverages.Add(new Beverage { Id = 3, Name = "Mocha" });
            Beverages.Add(new Beverage { Id = 4, Name = "Tea" });

            //Default additionların eklenmesi
            Additions = new List<Addition>();
            Additions.Add(new Addition { Id = 1, Name = "Milk" });
            Additions.Add(new Addition { Id = 1, Name = "Chocalate sauce" });
            Additions.Add(new Addition { Id = 1, Name = "Hazelnut Syrup" });

        }
        public List<Beverage> Beverages { get; private set; }
        public List<Addition> Additions { get; private set; }

    }
}
