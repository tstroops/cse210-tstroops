using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle myRectangle = new Rectangle("blue", 2.5, 3.5);
        Square mySquare = new Square("red", 4.5);
        Circle myCircle = new Circle("black", 1.0);
        List<Shape> myShapes = new List<Shape>(){myRectangle, mySquare, myCircle};
        foreach(Shape s in myShapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}