using System;
// Порушено принцип заміщення Лісков

interface IShape
{
    int GetArea();
}


class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}


class Square : IShape
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var sq = new Square();
        sq.Side = 5;
        Console.WriteLine(sq.GetArea());
    }
}
