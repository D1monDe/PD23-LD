using System;

class Point
{
    private int x;
    private int y;
    private string name;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }

    public Point(int xValue, int yValue, string pointName)
    {
        x = xValue;
        y = yValue;
        name = pointName;
    }
}