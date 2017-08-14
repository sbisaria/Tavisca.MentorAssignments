using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.MobileInfoManager.Entity
{
    public class Gsm
    {
        public BatteryCharacterstics Battery { get; set; }
        public MobileDisplay Display { get; set; }

        public static Gsm iphone4s;

        public Gsm Iphone4s { get { return iphone4s; } set { iphone4s = value; } }
        public Gsm(BatteryCharacterstics battery, MobileDisplay display, Gsm iphone4s)
        {
            Battery = battery;
            Display = display;
            Iphone4s = iphone4s;
        }
        public void DisplayAllInfo()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            var battery = $"Battery characterstics : {Battery}";
            var display = $"Mobile display characterstics : {Display}";
            var iphone4s = $"Gsm phone : {Iphone4s}";
            str.Append(battery).Append("\n").Append(display).Append("\n").Append(iphone4s);
            return str.ToString();
        }
    }
}
