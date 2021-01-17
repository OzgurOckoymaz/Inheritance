using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Square:GeometricShape
    {
        private decimal _edge;

        public decimal Edge
        {
            get { return _edge; }
            set { _edge = value; }
        }

    }
}
