using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{

    // Mình không muốn bất kì class nào có thể tạo ra 1 cái instance Pizza nên ở đây mình phải để nó là abstract class 
   
    abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        protected string type;

        // Chuẩn bị nguyên vật liệu
        public void Prepare() 
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            // ? Nếu toppings null cũng sẽ không lỗi.
            toppings?.ForEach(topping => Console.WriteLine(topping + "  "));
        }

        // Nướng bánh
        public void Bake()
        {
            Console.WriteLine("Baking " + name + " in 30 minutes");
        }

        // Cắt bánh
        public void Cut()
        {
            Console.WriteLine("Cutting " + name);
        }

        // Đóng hộp. (Muốn những class khác có thể override lại hàm Box thì thêm từ khoá virtual)
        public virtual void Box()
        {
            Console.WriteLine("Boxing " + name);
        }
    }
}

