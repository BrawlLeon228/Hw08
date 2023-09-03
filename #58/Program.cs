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

int[,] Umn(int[,] first_matrix, int[,] second_matrix)
{
    int[,] third_matrix = new int[first_matrix.GetLength(0), second_matrix.GetLength(1)];

    for (int i = 0; i < third_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < third_matrix.GetLength(1); j++)
        {
            int pro_a = 1;
            int pro_b = 1;

            for (int a = 0; a < first_matrix.GetLength(1); a++)
            {
                pro_a*=first_matrix[i, a];
            }
            for (int b = 0; b < second_matrix.GetLength(0); b++)
            {
                pro_b*=second_matrix[b, j];
            }

            third_matrix[i, j] = pro_a+pro_b;
            pro_a = 1;
            pro_b = 1;
        }

    }

    return third_matrix;
}

int[,] firstMatrix = CreateMatrixRndInt(4, 3, 0, 5);
int[,] secondMatrix = CreateMatrixRndInt(3, 3, 0, 5);

PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);


PrintMatrix(Umn(firstMatrix, secondMatrix));