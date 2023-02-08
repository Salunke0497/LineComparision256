using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Length
    {
        int PointX1, _pointY1, poIntX2, pointY2;
        public Length(int pointX1, int pointY1, int pointX2, int pointY2)
        {
            this.PointX1 = pointX1;
            _pointY1 = pointY1;
            poIntX2 = pointX2;
            this.pointY2 = pointY2;
        }

        public void CalculateLength()
        {
            double length = Math.Sqrt(Math.Pow((poIntX2 - PointX1), 2) + Math.Pow((pointY2 - _pointY1), 2));
            Console.WriteLine("length of line : " + length);
        }
    }
}
