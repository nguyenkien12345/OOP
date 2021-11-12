using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HueGreekPizza : Pizza
    {
        public HueGreekPizza()
        {
            name = "Hue A Good Greek Pizza";
            dough = "Hue Thin dough";
            sauce = "Hue Chilli sauce";
            toppings.Add("Hue Potato");
        }

        public override void Box()
        {
            // base.Box(); // Chạy hàm Box của Pizza. Còn nếu muốn ghi đè hàm Box của Pizza luôn thì không cần khai báo dòng này
            Console.WriteLine("Greek Pizza Is The Best"); 
        }
    }
}
