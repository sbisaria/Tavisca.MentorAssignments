using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tavisca.MobileInfoManager.Entity
{
    public class MobileDisplay
    {
        public string Size { get; set; }
        public List<string> Colours { get; set; }

        public MobileDisplay(string size, List<string> colours)
        {
            Size = size;
            Colours = colours;
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            var size = $"Size : {Size}";
            var colours = $"Colours available : {string.Join(",", Colours)}";
            str.Append(size).Append("\n").Append(colours).Append("\n");
            return str.ToString();
        }
    }
}
