using System;

class A
{

    public int Cube(int a)
    {
        return a * a;
    }


    public double Cube(double a)
    {
        return a * a;
    }


    public int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }


    public int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}

class Program
{
    static void Main()
    {
        A math = new A();


        Console.WriteLine("Cube of 5 (int): " + math.Cube(5));
        Console.WriteLine("Cube of 1.5 (double): " + math.Cube(1.5));


        Console.WriteLine("Min of 1, 9, 5: " + math.MinElement(1, 9, 5));
        Console.WriteLine("Min of 6, 20, 8, 11: " + math.MinElement(6, 20, 8, 11));
    }
}