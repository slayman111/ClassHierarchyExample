using System;

namespace ClassHierarchy
{
    class Program
    {
        static void Main()
        {
            Execute();
        }

        static void Execute()
        {
            Console.Title = "Class Hierarchy Example";

            try
            {
                Point point1 = new Point(), point2 = new Point(5, 10);
                ColoredPoint coloredPoint = new ColoredPoint();
                Point[] Points = new Point[3]
                {
                    point1,
                    point2,
                    coloredPoint
                };

                Line line = new Line();
                ColoredLine coloredLine = new ColoredLine();
                Polygon polyGon = new Polygon();
                Line[] Lines = new Line[3]
                {
                    line,
                    coloredLine,
                    polyGon
                };

                Console.WriteLine("================================================================================");

                Console.WriteLine("Point. Default constructor:");
                Points[0] = new Point();
                Points[0].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Point. Constructor with coordinates:");
                Points[1] = new Point(1, 2);
                Points[1].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Colored point. Default constructor:");
                Points[2] = new ColoredPoint();
                Points[2].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Colored point. Constructor with coordinates and color:");
                Points[2] = new ColoredPoint(3, 8, Color.Green);
                Points[2].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Line. Default constructor:");
                Lines[0] = new Line();
                Lines[0].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Line. Constructor with coordinates:");
                Lines[0] = new Line(1, 2, 3, 4);
                Lines[0].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Line. Constructor with two points:");
                Lines[0] = new Line(point1, point2);
                Lines[0].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Colored line. Default constructor:");
                Lines[1] = new ColoredLine();
                Lines[1].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Colored line. Constructor with coordinates and color:");
                Lines[1] = new ColoredLine(1, 2, 3, 4, Color.Red);
                Lines[1].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Colored line. Constructor with two points and color:");
                Lines[1] = new ColoredLine(point1, point2, Color.Blue);
                Lines[1].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Polygon. Default constructor:");
                Lines[2] = new Polygon();
                Lines[2].Print();

                Console.WriteLine("================================================================================");

                Console.WriteLine("Polygon. Constructor with array of points:");
                Point[] points = CreatePoints();
                Lines[2] = new Polygon(points);
                Lines[2].SetPoints(points);
                Lines[2].Print();
                
                Console.WriteLine("================================================================================");

                Console.WriteLine("Polygon. Polygon with moved points on 1 unit:");
                Lines[2].Move(1, 1);
                Lines[2].Print();

                Console.WriteLine("================================================================================");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public static Point[] CreatePoints()
        {
            Console.Write("Enter amount of vertices: ");
            int amountOfVertices = Convert.ToInt32(Console.ReadLine());
            Point[] points = new Point[amountOfVertices];
            for (int i = 0; i < amountOfVertices; i++)
            {
                points[i] = new Point();
                Console.Write("Enter X[" + (i + 1) + "]: ");
                points[i].X = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Y[" + (i + 1) + "]: ");
                points[i].Y = (float)Convert.ToDouble(Console.ReadLine());
            }

            return points;
        }
    }
}
