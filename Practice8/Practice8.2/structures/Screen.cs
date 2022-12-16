using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8._2.structures
{
    internal class Screen
    {
        private Resolution resolution;
        public float size;
        public int colorsCount;
        public bool isChroma;


        public Screen(int width, int height, float size, int colorsCount, bool isChroma)
        {
            this.resolution = new Resolution(width, height);
            this.size = size;
            this.colorsCount = colorsCount;
            this.isChroma = isChroma;
        }
        public void SetResolution(int width, int height)
        {
            resolution.SetResolution(width, height);
        }

        public Resolution GetResolution()
        {
            return this.resolution;
        }
    }

    class Resolution
    {
        public int width;
        public int height;
        public Resolution (int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void SetResolution(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
