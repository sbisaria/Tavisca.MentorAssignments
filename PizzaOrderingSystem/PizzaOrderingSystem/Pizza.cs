using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystem
{
    public class Pizza
    {
        public List<string> Type { get; set; }
        public List<string> Base { get; set; }
        public List<string> Toppings { get; set; }
    }
}
