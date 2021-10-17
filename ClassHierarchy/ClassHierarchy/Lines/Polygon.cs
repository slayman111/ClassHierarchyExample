namespace ClassHierarchy
{
    public class Polygon : Line
    {
        public Polygon() : base()
        {
        }

        public Polygon(Point[] points)
        {
            Points = new Point[points.Length];

            for (int i = 0; i < Points.Length; i++)
                Points[i] = new Point
                {
                    X = points[i].X,
                    Y = points[i].Y
                };
        }

        public override string ToString()
        {
            string polyLine = "--------------------------------------------------\n";
            for (int i = 0; i < Points.Length; i++)
                polyLine += "X" + (i + 1) + " = " + Points[i].X + "\n" +
                            "Y" + (i + 1) + " = " + Points[i].Y + "\n" +
                            "--------------------------------------------------\n";

            return polyLine;
        }
    }
}
