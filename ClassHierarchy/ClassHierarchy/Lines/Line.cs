using ClassHierarchy.Interfaces;
using System;

namespace ClassHierarchy
{
    public class Line : IMove, IInitialize
    {
        protected Point[] Points;

        public Line()
        {
            Points = new Point[2];
            Points[0] = new Point(0, 0);
            Points[1] = new Point(1, 1);
        }

        public Line(float x1, float y1, float x2, float y2)
        {
            Points = new Point[2];
            Points[0] = new Point(x1, y1);
            Points[1] = new Point(x2, y2);
        }

        public Line(Point startPoint, Point endPoint)
        {
            Points = new Point[2];
            Points[0] = new Point(startPoint);
            Points[1] = new Point(endPoint);
        }

        public virtual void MoveX(int i, float shiftX)
        {
            Points[i].X += shiftX;
        }

        public virtual void MoveY(int i, float shiftY)
        {
            Points[i].Y += shiftY;
        }

        public virtual void Move(float shiftX, float shiftY)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                MoveX(i, shiftX);
                MoveY(i, shiftY);
            }
        }

        public virtual void SetPoints(params Point[] points)
        {
            for (int i = 0; i < Points.Length; i++)
                Points[i] = points[i];
        }

        public void Print() => Console.WriteLine(this.ToString());

        public virtual new string ToString() => "Start point = " + Points[0].X + ", " + Points[0].Y + "\n" +
                "End point = " + Points[1].X + ", " + Points[1].Y;
    }
}
