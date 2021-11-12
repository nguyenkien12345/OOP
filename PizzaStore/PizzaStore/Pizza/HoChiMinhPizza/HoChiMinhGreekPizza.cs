using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HoChiMinhGreekPizza : Pizza
    {
        public HoChiMinhGreekPizza()
        {
            name = "HoChiMinh A Good Greek Pizza";
            dough = "HoChiMinh Thin dough";
            sauce = "HoChiMinh Chilli sauce";
            toppings.Add("HoChiMinh Potato");
        }

        public override void Box()
        {
            // base.Box(); // Chạy hàm Box của Pizza. Còn nếu muốn ghi đè hàm Box của Pizza luôn thì không cần khai báo dòng này
            Console.WriteLine("Greek Pizza Is The Best"); 
        }
    }
}
