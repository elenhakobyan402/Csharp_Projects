using System;

class Matrix
{
    private int N;
    private int A;
    private int B;
    private int[,] matrix;

    public int Size
    {
        get => N;
        set => N = value;
    }

    public int Min
    {
        get => A;
        set => A = value;
    }

    public int Max
    {
        get => B;
        set => B = value;
    }

    public Matrix(int n, int a, int b)
    {
        N = n;
        A = a;
        B = b;

        matrix = new int[N, N];
        FillMatrix();
    }

    private void FillMatrix()
    {
        Random random = new Random();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(A, B + 1);
            }
        }
    }

    public void ShowMatrix()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    public int CountOdd()
    {
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] % 2 != 0)
                    count++;
            }
        }

        return count;
    }
}