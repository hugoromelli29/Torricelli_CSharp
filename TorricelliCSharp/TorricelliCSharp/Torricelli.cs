using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorricelliCSharp
{
    internal class Torricelli:Delta_S
    {
        public double V0 { get; set; }
        public double a { get; set; }
        public void CalcTorricelli()
        {
            double v_quadrado = ((double)Math.Pow(V0, 2)) + (2 * a * base.CalcDelta_S());
            double velocidade = (double)Math.Sqrt(v_quadrado);
            Console.WriteLine(velocidade);
        }
    }
}
