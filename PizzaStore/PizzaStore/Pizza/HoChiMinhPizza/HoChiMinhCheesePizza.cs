using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HoChiMinhCheesePizza : Pizza
    {
        public HoChiMinhCheesePizza()
        {
            name = "HoChiMinh The Best Cheese Pizza";
            dough = "HoChiMinh Very thin dough";
            sauce = "HoChiMinh Very spicy sauce";
            toppings.Add("HoChiMinh Black Olives");
            toppings.Add("HoChiMinh Cheese");
        }

        public override void Box()
        {
            // base.Box(); // Chạy hàm Box của Pizza. Còn nếu muốn ghi đè hàm Box của Pizza luôn thì không cần khai báo dòng này
            Console.WriteLine("Cheese Pizza Is The Best");
        }
    }
}
