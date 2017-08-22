using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tavisca.MobileInfoManager.Entity
{
    public class Call
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string DialedNumber { get; set; }
        public int Duration { get; set; }
        public Call()
        {

        }
    }
}
