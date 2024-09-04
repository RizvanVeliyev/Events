using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class OverDrawnArgs:EventArgs
    {
        public decimal SubAmount { get; set; }
        public OverDrawnArgs(decimal subAmount)
        {
            SubAmount = subAmount;
        }
    }
}
