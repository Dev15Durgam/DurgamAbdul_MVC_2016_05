using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgam_AbdulAmir_Uppgift3
{
    public class Speed
    {
        public double CalSpeed(string Distance, string Time)
        {
            double distance = double.Parse(Distance);
            double time = double.Parse(Time);
            double Speed = distance / time;
            return Speed;
            //throw new NotImplementedException();
        }
    }
}
