using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotConsoleApp
{
    public class Pineapple : ISlotSymbol
    {
        public double Coefficient => 0.8; 
        public string Display() => "P";
    }
}
