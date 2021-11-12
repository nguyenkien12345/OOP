using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class DaNangPepperoniPizza : Pizza
    {
        public DaNangPepperoniPizza()
        {
            name = "DaNang The Best Pepperoni Pizza";
            dough = "DaNang Thick dough";
            sauce = "DaNang Sweet sauce";
            toppings.Add("DaNang Tomato");
        }
    }
}
