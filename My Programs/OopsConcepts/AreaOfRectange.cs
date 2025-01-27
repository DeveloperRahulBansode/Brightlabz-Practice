using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class AreaOfRectange
    {
        private double _length;
        private double _breadth;

        public AreaOfRectange(double length, double breadth)
        {
            _length = length;
            _breadth = breadth;
        }

        public double AreaOfRecta()
        {
             

            return _length * _breadth ;
        }






    }
}
