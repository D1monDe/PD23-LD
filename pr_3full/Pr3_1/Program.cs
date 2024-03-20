using System;

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(3, 0, "B");
        Point C = new Point(3, 4, "C");
        Point D = new Point(0, 4, "D");

        Figure figure = new Figure(A, B, C, D);
        figure.PerimeterCalculator();
    }
}