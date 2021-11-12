using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HuePepperoniPizza : Pizza
    {
        public HuePepperoniPizza()
        {
            name = "Hue The Best Pepperoni Pizza";
            dough = "Hue Thick dough";
            sauce = "Hue Sweet sauce";
            toppings.Add("Hue Tomato");
        }
    }
}
