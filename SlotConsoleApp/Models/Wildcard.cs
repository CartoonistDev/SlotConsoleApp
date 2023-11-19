using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotConsoleApp
{
    public class Wildcard : ISlotSymbol
    {
        public double Coefficient => 0; 
        public string Display() => "*";
    }
}
