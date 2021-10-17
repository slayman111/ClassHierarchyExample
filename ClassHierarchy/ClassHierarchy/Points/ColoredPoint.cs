namespace ClassHierarchy
{
    public class ColoredPoint : Point
    {
        private Color color;

        public Color Color { get => color; set => color = value; }

        public ColoredPoint() : base()
        {
            Color = Color.Black;
        }

        public ColoredPoint(float x, float y, Color color) : base(x, y)
        {
            Color = color;
        }

        public ColoredPoint(ColoredPoint coloredPoint) : base(coloredPoint)
        {
            Color = coloredPoint.Color;
        }

        public override string ToString() => "X = " + X + "\nY = " + Y + "\nColor = " + Color;
    }
}
