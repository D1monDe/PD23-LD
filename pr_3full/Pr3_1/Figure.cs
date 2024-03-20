using System;

class Figure
{
    private Point[] points;

    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }

    public double LengthSide(Point A, Point B)
    {
        int sideX = Math.Abs(A.X - B.X);
        int sideY = Math.Abs(A.Y - B.Y);
        return Math.Sqrt(sideX * sideX + sideY * sideY);
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length;
            perimeter += LengthSide(points[i], points[nextIndex]);
        }
        Console.WriteLine("Периметр багатокутника: " + perimeter);
    }
}