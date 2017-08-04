using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.MobileInfoManager.Entity
{
    public class MobileDevice
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string OwnerName { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
    }
}
