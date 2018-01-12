using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() :
               base ("такой самолет уже есть") { }
    }
}
