using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.MobileInfoManager.Entity
{
    public class BatteryCharacterstics
    {
        public BatteryCharacterstics Battery { get; set; }
        public double IdleHours { get; set; }
        public double TalkHours { get; set; }
    }
}
