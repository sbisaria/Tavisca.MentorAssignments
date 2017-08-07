using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.MobileInfoManager.Entity
{
    public class MobileDevice
    {
        /*
        Problem Statement
        Define a class that holds information about a mobile phone device: 
        model, manufacturer, price, owner, 
        battery characteristics (model, hours idle and hours talk) 
        and display characteristics (size and number of colors).
        Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
        */
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string OwnerName { get; set; }
        public BatteryCharacterstics Battery { get; set; }
        public MobileDisplay DisplayCharacterstics { get; set; }
    }
}
