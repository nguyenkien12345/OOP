using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class DaNangCheesePizza : Pizza
    {
        public DaNangCheesePizza()
        {
            name = "DaNang The Best Cheese Pizza";
            dough = "DaNang Very thin dough";
            sauce = "DaNang Very spicy sauce";
            toppings.Add("DaNang Black Olives");
            toppings.Add("DaNang Cheese");
        }

        public override void Box()
        {
            // base.Box(); // Chạy hàm Box của Pizza. Còn nếu muốn ghi đè hàm Box của Pizza luôn thì không cần khai báo dòng này
            Console.WriteLine("Cheese Pizza Is The Best");
        }
    }
}
