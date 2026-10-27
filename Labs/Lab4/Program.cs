using System;

class Program
{
    static void A(in int x)
    {
        Console.WriteLine("A: " + x);
    }

    static void B(out int x)
    {
        x = 10;
    }

    static void C(ref int x)
    {
        x = x + 5;
    }

    static int SumValues(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    static void Show(int x = 100)
    {
        Console.WriteLine("Default value: " + x);
    }

    static void Main()
    {
        int a = 5;
        A(in a);

        int b;
        B(out b);
        Console.WriteLine("B: " + b);

        int c = 10;
        C(ref c);
        Console.WriteLine("C: " + c);

        Console.WriteLine(SumValues(1, 2, 3));
        Console.WriteLine(SumValues(10, 20, 30, 40));

        Show();
        Show(50);
    }
}