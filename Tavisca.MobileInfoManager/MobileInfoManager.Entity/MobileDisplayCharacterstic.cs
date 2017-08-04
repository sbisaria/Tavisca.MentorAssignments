using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tavisca.MobileInfoManager.Entity
{
    public class MobileDisplayCharacterstic
    {
        public double Size { get; set; }
        public List<string> Colours { get; set; }

        public MobileDisplayCharacterstic(double size,string colour)
        {
            size = Size;
            colour = Colours;
        }
    }
}
