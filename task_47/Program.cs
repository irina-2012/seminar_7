/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Clear();
GetArray(3,4);

void GetArray(int m, int n)
{
    double[,] mas = new double[m, n];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = Convert.ToDouble(new Random().Next(1, 100) / 10.0);
            Console.Write($"{mas[i, j]}  ");
        }
        Console.WriteLine();
    }
}
