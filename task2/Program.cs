// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();
int[,] matrix = Generate2DArray(rnd.Next(1, 5), rnd.Next(5, 9));
Print2DArray(matrix);
MinSumOfRows(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"строкa с наименьшей суммой элементов: {MinSumOfRows(matrix)}");
// Print2DArray(matrix);
int MinSumOfRows(int[,] arr)
{
    int sumOfRow = int.MaxValue; ;
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            temp = temp + arr[i, j];
        }
        if (temp < sumOfRow)
        {
            sumOfRow = temp;
            minRow = i + 1;
        }
    }
    return minRow;
}

int[,] Generate2DArray(int m, int n)
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
void Print2DArray(int[,] arr)
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