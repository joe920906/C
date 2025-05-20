using System;

class UnitConverter
{

    public delegate double A(double a);


    public static double B(double a)
    {
        return a / 12.0;
    }


    public static double C(double a)
    {
        return a / (3.0 * 12.0);
    }

    static void Main()
    {
        Console.WriteLine("請輸入英吋數值：");
        double input = double.Parse(Console.ReadLine());

        Console.WriteLine("請選擇轉換方式：");
        Console.WriteLine("1. 英吋 轉 英尺");
        Console.WriteLine("2. 英吋 轉 英碼");

        string choice = Console.ReadLine();

        A converter;

        if (choice == "1")
        {
            converter = B;
        }
        else if (choice == "2")
        {
            converter = C;
        }
        else
        {
            Console.WriteLine("無效選項！");
            return;
        }

        double result = converter(input);
        Console.WriteLine($"轉換後的數值為：{result}");
    }
}