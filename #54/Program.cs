int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int a = 0; a < matrix.GetLength(1) - (j+1); a++)
            {
                if (matrix[i, a] > matrix[i, a+1])
                {
                    int value = matrix[i, a];
                    matrix[i, a] = matrix[i, a+1];
                    matrix[i, a+1] = value;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(matrix);
Sort(matrix);
PrintMatrix(matrix);