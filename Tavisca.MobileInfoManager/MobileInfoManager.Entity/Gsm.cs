using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.MobileInfoManager.Entity
{
    public class Gsm
    {
        public Battery Battery;
        public Display Display;

        public Gsm(Battery battery,Display display)
        {
            Battery = battery;
            Display = display;
        }
    }
}
