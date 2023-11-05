using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Class_laba2
{
    internal class Crop
    {
        private double r;

        
        public Crop()
        {
            r = 5; 
        }

        
        public Crop(double r)
        {
            this.r = r; 
        }

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        
        public double YieldPerUnitArea(double k)
        {
            return k * R;
        }
    }
}
