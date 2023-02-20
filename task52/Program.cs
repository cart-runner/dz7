﻿// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
System.Console.WriteLine("введите количество столбцов");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите количество строчек");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[num2,num1];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,9);
        System.Console.Write($"{array[i,j]} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    float result = 0;

    for (int j = 0; j < array.GetLength(0); j++)
    {
        result = result + array[j,i];
    }
    System.Console.Write($"{Math.Round((result / array.GetLength(0)), 1)};  ");
}





