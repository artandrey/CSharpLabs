using System;

namespace The3rdPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Перевірити істинність вислову: "Дані числа x, у є координатами точки, що лежить у квадраті ".*/

            Point point = new Point(2, 3);
            Square square = new Square(new Point(1, 2), 10);

            bool checkResult = IntersectionChecker.Check(square, point);

            Console.WriteLine("Result {0}", checkResult);


            Console.ReadKey();
        }
    }

    class Point {
        public float X { get; }
        public float Y { get; }
        public Point (float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

    }


    class BoundingRect
    {
        public float X {get; }
        public float Y {get; }

        public float Width { get; }
        public float Height { get; }

        public BoundingRect(float x, float y, float width)
        {
            X = x;
            Y = y;
            Width = width;
            Height = width;
        }
        public BoundingRect(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }

    abstract class Figure
    {
        public abstract BoundingRect GetBoundingRect();
    }

    class Square: Figure
    {
        private Point TopLeftPoint { get; }
        private float Width { get; }
        public Square(Point topLeftPoint, float width)
        {
            this.TopLeftPoint = topLeftPoint;
            this.Width = width;
        }

        public override BoundingRect GetBoundingRect()
        {
            return new BoundingRect(this.TopLeftPoint.X, this.TopLeftPoint.Y, this.Width);
        }
    }

    class IntersectionChecker
    {
        public static bool Check(Figure figure, Point point)
        {
            BoundingRect figureBoundingRect = figure.GetBoundingRect();
            bool isIntersectionByY = figureBoundingRect.Y - point.Y <= 0 && figureBoundingRect.Y + figureBoundingRect.Height - figureBoundingRect.Y >= 0;
            bool isIntersectionByX = figureBoundingRect.X - point.X <= 0 && figureBoundingRect.X + figureBoundingRect.Width - figureBoundingRect.X >= 0;

            return isIntersectionByX && isIntersectionByY;
        }
    }
}

