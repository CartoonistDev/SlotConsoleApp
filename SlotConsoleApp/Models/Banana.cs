using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotConsoleApp
{
    public class Banana : ISlotSymbol
    {
        public double Coefficient => 0.6; 
        public string Display() => "B";

    }
}
