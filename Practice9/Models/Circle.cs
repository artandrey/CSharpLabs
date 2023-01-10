using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Circle : Shape
    {
        private double radius;
        private static readonly int POLYGONS_COUNT = 0;
        public Circle(string name) : this(name, Randomise.GetRandomSideSize())
        {

        }
        public Circle(string name, double radius) : this(name, Randomise.GetRandomColor(), radius)
        {

        }
        public Circle(string name, ConsoleColor shapeColor, double radius) : base(name, POLYGONS_COUNT, shapeColor)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public override double GetPerimeter()
        {
            return this.radius * Math.PI * 2;
        }

        public override void Draw()
        {
            Painter.Paint(this.Name, sizes:  new Dictionary<string, double>() { { "radius", this.radius } }, this.ShapeColor);
        }
    }
}
