using System;
using System.Drawing;

namespace MarsRobot
{
    public class Plateau
    {
        public Plateau(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Plateau(string width, string height)
        {
            Width = Int32.Parse(width);
            Height = Int32.Parse(height);
        }

        private int Width { get; set; }
        private int Height { get; set; }

        public bool AreCoordinatesValid(Point point)
        {
            return point.X >= 1 && point.X <= Width && point.Y >= 1 && point.Y <= Height;
        }
    }
}
