using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotConsoleApp
{
    public class Apple : ISlotSymbol
    {
        public double Coefficient => 0.4; 
        public string Display() => "A";

    }
}
