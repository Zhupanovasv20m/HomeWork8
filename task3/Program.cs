// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Random rnd = new Random();
int[,] matrixOne = GenerateFirst2DArray(rnd.Next(1, 10), rnd.Next(1, 10));
int[,] matrixTwo = GenerateSecond2DArray(rnd.Next(1, 10), rnd.Next(1, 10));
PrintFirst2DArray(matrixOne);
System.Console.WriteLine();
PrintSecond2DArray(matrixTwo);
int[,] resultMatrix = new int[m,p];

MultiplyMatrix(matrixOne, matrixTwo, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixOne.GetLength(1); k++)
      {
        sum += matrixOne[i,k] * matrixTwo[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int[,] GenerateFirst2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintFirst2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int[,] GenerateSecond2DArray(int n, int k)
{
    int[,] result = new int[n, k];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintSecond2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}