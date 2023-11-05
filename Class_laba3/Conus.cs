using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Class_laba3
{
    internal class Conus : Figura3D
    {
        int r = 0;
        public Conus(int r, int h)
        {
            this.r = r;
            h = h;
            figura = "Конус";
        }
        public override double S()
        {
            var l = Math.Sqrt(r * r + h * h);
            return Math.PI * l * r;
        }
        public override string Show()
        {
            return "Фігура - " + figura +
                "Висота = " + h.ToString()
                + "Радіус = " + r;
        }
    }
}
