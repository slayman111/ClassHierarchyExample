using System;

namespace ClassHierarchy
{
    public class Point
    {
        private float x;
        private float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public void Print() => Console.WriteLine(this.ToString());

        public virtual new string ToString() => "X = " + X + "\nY = " + Y;
    }
}
