using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store.Base
{
    class HoChiMinhPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HoChiMinhCheesePizza();
                    break;
                case "greek":
                    return new HoChiMinhGreekPizza();
                    break;
                case "pepperoni":
                    return new HoChiMinhPepperoniPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
