using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{
    class ParkingIndexOutOfRangeException : Exception
    {
        public ParkingIndexOutOfRangeException() :
               base (" На парковке нет машины по такому месту") { }
    }
}
