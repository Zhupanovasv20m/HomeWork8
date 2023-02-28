// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random rnd = new Random();
int[,,] array3D = Generate3DArray(rnd.Next(2, 2), rnd.Next(2, 2), rnd.Next(2, 2));
WriteArray(array3D);
CreateArray(array3D);
int[,,] Generate3DArray(int m, int n, int x)
{
    int[,,] array3D = new int[m, n, x];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
    return array3D;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k}); ");
            }
            System.Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
        int count = 0;
        for (int m = 0; m < array3D.GetLength(0); m++)
        {
            for (int n = 0; n < array3D.GetLength(1); n++)
            {
                for (int x = 0; x < array3D.GetLength(2); x++)
                {
                    array3D[m, n, x] = temp[count];
                    count++;
                }
            }
        }
    }
}
