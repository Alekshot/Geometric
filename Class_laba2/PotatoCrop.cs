using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Class_laba2
{
    internal class PotatoCrop : Crop
    {
        private double s = 5;

        public PotatoCrop(double r, double s) : base(r)
        {
            this.s = s;
        }

        public double S
        {
            get { return s; }
            set { s = value; }
        }

        public double TotalYield(double k)
        {
            return YieldPerUnitArea(k) * S;
        }
    }
}
