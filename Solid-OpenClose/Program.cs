using System;

namespace SolidOpenClose
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Reactangle r = new Reactangle();
            r.Height = 10;
            r.Width = 15;
            Console.WriteLine("Reactangle Area:" + r.Area());


            Circle c = new Circle();
            c.Radius = 12;
            Console.WriteLine("Cricle Area: " + c.Area());

            Console.ReadLine();
        
        }
    }
}
