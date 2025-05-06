using System;

public class Box
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Length { get; set; }

    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    public double Volume()
    {
        return Width * Height * Length;
    }

    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
}

/*
+----------------------------+
|           Box             |
+----------------------------+
| - Width: double           |
| - Height: double          |
| - Length: double          |
+----------------------------+
| +Box(width: double,       |
|       height: double,     |
|       length: double)     |
| +Volume(): double         |
| +Area(): double           |
+----------------------------+
*/

class Program
{
    static void Main(string[] args)
    {
        Box box = new Box(3.0, 4.0, 5.0);

        Console.WriteLine("體積：" + box.Volume());
        Console.WriteLine("面積：" + box.Area());
    }
}