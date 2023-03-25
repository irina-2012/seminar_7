/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 */

Console.Clear();
int[,] mas = GetArray(3, 4);

Console.WriteLine("Введите позиицию элемента: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Posihion(mas));

int[,] GetArray(int m, int n)
{
    int[,] mas = new int[m, n];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(1, 100);
            Console.Write($"{mas[i, j]}  ");
        }
        Console.WriteLine();
    }
    return mas;
}


void Posihion(int[,] mas)
{
    // Console.WriteLine("Введите позиицию элемента: ");
    // int a = int.Parse(Console.ReadLine());
    // int b = int.Parse(Console.ReadLine());
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = 0; j < mas.Length; j++)
        {
            if (a > m && b > n)
                Console.WriteLine("такого числа нет");
            else
            {
                object c = array.GetValue(a, b);
                Console.WriteLine(c);
            }
        }
    }
}