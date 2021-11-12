using PizzaStore.Store.Base;
using System;
using System.Collections.Generic;

namespace PizzaStore
{
    class Program : Pizza
    {
        static void Main(string[] args)
        {
            var hue_pizzaStore = new HuePizzaStore();
            hue_pizzaStore.OrderPizza("cheese");

            var hcm_pizzaStore = new HoChiMinhPizzaStore();
            hcm_pizzaStore.OrderPizza("greek");

            var danang_pizzaStore = new DaNangPizzaStore();
            danang_pizzaStore.OrderPizza("pepperoni");
        }
    }
}
