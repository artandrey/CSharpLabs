using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{

    abstract class Shape: IDraw
    {
        public int PolygonsCount { get; }

        public string Name { get; }
        public ConsoleColor ShapeColor { get; set; }
        public Shape (string name, int polygonsCount, ConsoleColor shapeColor)
        {
            this.Name = name;
            this.PolygonsCount = polygonsCount;
            this.ShapeColor = shapeColor;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public abstract void Draw();

    }
}
