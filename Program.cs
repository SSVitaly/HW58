void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
    }
}
int rows1 = 2;
int rows2 = 3;
int coloms1 = 3;
int coloms2 = 2;



int[,] matr1 = new int[rows1, coloms1];
int[,] matr2 = new int[rows2, coloms2];

Console.WriteLine("Матрица #1:");
FillArray(matr1);
PrintArray(matr1);

Console.WriteLine();

Console.WriteLine("Матрица #2:");
FillArray(matr2);
PrintArray(matr2);

Console.WriteLine();

int[,] result = new int[rows1, coloms2];
for (int i = 0; i < matr1.GetLength(0); i++)
{
    for (int j = 0; j < matr2.GetLength(1); j++)
    {
        for (int k = 0; k < matr2.GetLength(0); k++)
        {
            result[i, j] += matr1[i, k] * matr2[k, j];
        }
    }
}
Console.WriteLine("Произведение матриц");
PrintArray(result);