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

void FindSum(int[,] matrix)
{
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        int max = 0;
        

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[i, j];
        }
        if (sum > max){
            max = sum;
            index = i;
        }
    }
    Console.WriteLine($"{index+1} строка ");
}

int[,] matrix = CreateMatrixRndInt(2, 3, -100, 100);
PrintMatrix(matrix);
FindSum(matrix);