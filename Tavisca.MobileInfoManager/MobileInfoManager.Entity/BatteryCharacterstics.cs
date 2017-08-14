using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.MobileInfoManager.Entity
{
    public class BatteryCharacterstics
    {
        public BatteryType BatteryType { get; set; }
        public double IdleHours { get; set; }
        public double TalkHours { get; set; }
        public string BatteryModel { get; set; }

        public BatteryCharacterstics(double idleHours, double talkHours, BatteryType batteryType, string batteryModel)
        {
            IdleHours = idleHours;
            TalkHours = talkHours;
            BatteryType = batteryType;
            BatteryModel = batteryModel;
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            var idleHours = $"Idle hours : {IdleHours}";
            var talkHours = $"Idle hours : {TalkHours}";
            var batteryType = $"Battery Type : {BatteryType}";
            str.Append(idleHours).Append("\n").Append(talkHours).Append("\n").Append(batteryType).Append("\n");
            return str.ToString();

        }
    }

}
