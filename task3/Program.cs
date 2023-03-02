// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrixOne = {{2, 4, 5, 1},
                    {7, 4, 2, 8},
                    {3, 2, 1, 3},
                    {3, 5, 3, 4}};

int[,] matrixTwo = {{7, 1, 5, 1},
                    {5, 4, 9, 8},
                    {7, 4, 2, 1},
                    {3, 7, 1, 1}};

int[,] resultMatrix = new int[4, 4];

MultiplyMatrix(matrixOne, matrixTwo, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
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
                sum += matrixOne[i, k] * matrixTwo[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
void PrintArray(int[,] arr)
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