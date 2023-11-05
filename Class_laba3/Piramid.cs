using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Class_laba3
{
    internal class Piramid : Figura3D
    {
        int a;
        public Piramid(int a, int h)
        {
            this.a = a;
            h = h;
            figura = "Піраміда";
        }
        public override double S()
        {
            var s4 = 0.5 * a * h;
            return 4 * s4 + a * a;
        }
        public override string Show()
        {
            return "Фігура - " + figura +
                " Висота = " + h.ToString()
                + "Сторона = " + a;
        }
    }
}
