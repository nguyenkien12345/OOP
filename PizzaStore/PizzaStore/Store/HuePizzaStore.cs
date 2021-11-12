using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store.Base
{
    class HuePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HueCheesePizza();
                    break;
                case "greek":
                    return new HueGreekPizza();
                    break;
                case "pepperoni":
                    return new HuePepperoniPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
