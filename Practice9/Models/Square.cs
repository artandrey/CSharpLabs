using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Square : Shape
    {
        private double scale;
        private static readonly int POLYGONS_COUNT = 4;
        public Square(string name) : this(name, Randomise.GetRandomSideSize())
        {

        }
        public Square(string name, double scale) : this(name, Randomise.GetRandomColor(), scale)
        {
            this.scale = scale;
            
        }
        public Square(string name, ConsoleColor shapeColor, double scale) : base(name, POLYGONS_COUNT, shapeColor)
        {
            this.scale = scale;
        }

        public override double GetArea()
        {
            return this.scale * this.scale;
        }

        public override double GetPerimeter()
        {
            return this.scale * POLYGONS_COUNT;
        }

        public override void Draw()
        {
            Painter.Paint(this.Name, sizes: new Dictionary<string, double> { { "scale", this.scale } }, this.ShapeColor);
        }


    }
}
