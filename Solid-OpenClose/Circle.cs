using System;

namespace SolidOpenClose
{
    public class Circle :Shape
    {
        public Double Radius
        {
            get;
            set;
        }

        public override double Area()
        {
            return 3.14 * Radius;
        }
    }
}
