using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // Mình không muốn bất kì class nào có thể tạo ra 1 cái instance PizzaStore nên ở đây mình phải để nó là abstract class 
    abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        // CreatePizza chỉ được implement hoặc là chỉ được sử dụng ở class con mà kế thừa class PizzaStore.
        protected abstract Pizza CreatePizza(string type);

    }
}
