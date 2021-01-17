using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rectangle:GeometricShape
    {
        private decimal _shortEdge;
        private decimal _longEdge;

        public decimal ShortEdge
        {
            get { return _shortEdge; }
            set { _shortEdge = value; }
        }

        public decimal LongEdge
        {
            get { return _longEdge; }
            set { _longEdge = value; }
        }

    }
}
