using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Triangle : Shape
    {
        private double scale;
        private static readonly int POLYGONS_COUNT = 3;
        public Triangle(string name) : this(name, Randomise.GetRandomSideSize())
        {

        }
        public Triangle(string name, double scale) : this(name, Randomise.GetRandomColor(), scale)
        {

        }
        public Triangle(string name, ConsoleColor shapeColor, double scale) : base(name, POLYGONS_COUNT, shapeColor)
        {
            this.scale = scale;

        }

        public override double GetArea()
        {
            return this.scale * this.scale * Math.PI;
        }

        public override double GetPerimeter()
        {
            return this.scale * Math.PI * 2;
        }

        public override void Draw()
        {
            Painter.Paint(this.Name, sizes: new Dictionary<string, double> { {"sides", this.scale } }, this.ShapeColor);
        }
    }
}
