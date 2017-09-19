using System;
namespace SolidOpenClose
{
    public class Reactangle : Shape
    {
        public Double Width
        {
            get;
            set;
     
        }

        public Double Height
        {
            get;
            set;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
