namespace ClassHierarchy
{
    public class ColoredLine : Line
    {
        private Color color;

        public Color Color { get => color; set => color = value; }

        public ColoredLine() : base()
        {
            Color = Color.Black;
        }

        public ColoredLine(float x1, float y1, float x2, float y2, Color color) : base(x1, y1, x2, y2)
        {
            Color = color;
        }

        public ColoredLine(Point startPoint, Point endPoint, Color color) : base(startPoint, endPoint)
        {
            Color = color;
        }

        public override string ToString()
        {
            return "Point 1 = " + Points[0].X + ", " + Points[0].Y + "\n" +
                "Point 2 = " + Points[1].X + ", " + Points[1].Y + "\n" +
                "Color = " + Color;
        }
    }
}
