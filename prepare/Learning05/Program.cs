using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a list to house all shapes
        List<Shapes> shapes = new List<Shapes>();

        // Gives parameters for all shapes here and adds them to list
        Square ss = new Square("red", 5);
        shapes.Add(ss);

        Circle sc = new Circle("blue", 5);
        shapes.Add(sc);

        Rectangle sr = new Rectangle("yellow", 5, 5);
        shapes.Add(sr);

        // Uses a for-each loop to call each function and display each shape
        foreach (Shapes s in shapes)
        {
            string color = s.getColor();

            double area = s.getArea();

            Console.WriteLine($"The {color} shape has an area of {area} square units.");
        }


    }


}