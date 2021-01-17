using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GeometricShape
    {
        private decimal _area;
        private decimal _perimeter;

        public decimal Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public decimal Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }

        public decimal Rec_Perimeter(decimal s, decimal l)
        {
            decimal per = (s * 2 + l * 2);
            return per;
        }

        public decimal Rec_Area(decimal s, decimal l)
        {
            decimal ar = s * l;
            return ar;
        }

        public decimal Squ_Perimeter(decimal k)
        {
            decimal per = 4 * k;
            return per;
        }

        public decimal Squ_Area(decimal k)
        {
            decimal ar = k * k;
            return ar;
        }

    }
}
