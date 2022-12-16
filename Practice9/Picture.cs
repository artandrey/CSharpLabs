using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Picture: IDraw
    {
        private List<Shape> Collection = new List<Shape>();
        public int CollectionLength
        {
            get => Collection.Count;
        }

        public Picture()
        {

        }

        public Picture(int capacity)
        {
            this.Collection = new List<Shape>(capacity);
        }

        public void AddNewShape(Shape shape)
        {
            Collection.Add(shape);
        }

        public int RemoveShape(string name)
        {
            return Collection.RemoveAll(shape => shape.Name == name);
        }
        public int RemoveShape(Type type)
        {
            return Collection.RemoveAll(shape => shape.GetType() == type);
        }

        public int RemoveShape(double maxArea)
        {
            return Collection.RemoveAll(shape => shape.GetArea() == maxArea);
        }

        [System.Runtime.CompilerServices.IndexerName("Shape")]
        public Shape this[int index]
        {
            get => Collection[index];
            set => Collection[index] = value;
        }

        public void Draw()
        {
            Collection.ForEach(shape => shape.Draw());
        }

    }
}
