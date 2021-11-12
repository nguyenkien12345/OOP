using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HoChiMinhPepperoniPizza : Pizza
    {
        public HoChiMinhPepperoniPizza()
        {
            name = "HoChiMinh The Best Pepperoni Pizza";
            dough = "HoChiMinh Thick dough";
            sauce = "HoChiMinh Sweet sauce";
            toppings.Add("HoChiMinh Tomato");
        }
    }
}
