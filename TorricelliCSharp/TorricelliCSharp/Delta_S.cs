using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorricelliCSharp
{
    internal class Delta_S
    {
        public double S0 { get; set; }
        public double Sf { get; set; }
        public double CalcDelta_S()
        {
            double delta_S = Sf - S0;
            return delta_S;
        }
    }
}
