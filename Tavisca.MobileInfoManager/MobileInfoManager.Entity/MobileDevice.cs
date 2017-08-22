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
        public BatteryCharacterstics Battery { get; set; }
        public MobileDisplay DisplayCharacterstics { get; set; }

        public MobileDevice(
            string model, 
            string manufacturer, 
            double price, 
            string ownerName, 
            BatteryCharacterstics battery, 
            MobileDisplay displayCharacterstics)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            OwnerName = ownerName;
            Battery = battery;
            DisplayCharacterstics = displayCharacterstics;
        }
    }
}
