using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HueCheesePizza : Pizza
    {
        public HueCheesePizza()
        {
            name = "Hue The Best Cheese Pizza";
            dough = "Hue Very thin dough";
            sauce = "Hue Very spicy sauce";
            toppings.Add("Hue Black Olives");
            toppings.Add("Hue Cheese");
        }

        public override void Box()
        {
            // base.Box(); // Chạy hàm Box của Pizza. Còn nếu muốn ghi đè hàm Box của Pizza luôn thì không cần khai báo dòng này
            Console.WriteLine("Cheese Pizza Is The Best");
        }
    }
}
