using System;

class Program
{
    static void Main()
    {
        Matrix m = new Matrix(3, 1, 10);

        Console.WriteLine("Matrix:");
        m.ShowMatrix();

        Console.WriteLine("Odd numbers: " + m.CountOdd());
    }
}