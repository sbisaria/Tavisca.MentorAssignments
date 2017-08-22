using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    public class BookingEngine
    {
        public bool PlaceOrder()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.ShowItems();
            return true;
        }
    }
}
