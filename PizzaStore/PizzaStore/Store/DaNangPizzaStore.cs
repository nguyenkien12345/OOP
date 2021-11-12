using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store.Base
{
    class DaNangPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new DaNangCheesePizza();
                    break;
                case "greek":
                    return new DaNangGreekPizza();
                    break;
                case "pepperoni":
                    return new DaNangPepperoniPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
