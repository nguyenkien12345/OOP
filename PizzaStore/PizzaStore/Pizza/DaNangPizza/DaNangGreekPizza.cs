using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class DaNangGreekPizza : Pizza
    {
        public DaNangGreekPizza()
        {
            name = "DaNang A Good Greek Pizza";
            dough = "DaNang Thin dough";
            sauce = "DaNang Chilli sauce";
            toppings.Add("DaNang Potato");
        }

        public override void Box()
        {
            // base.Box(); // Chạy hàm Box của Pizza. Còn nếu muốn ghi đè hàm Box của Pizza luôn thì không cần khai báo dòng này
            Console.WriteLine("Greek Pizza Is The Best"); 
        }
    }
}
