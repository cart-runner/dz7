//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
System.Console.WriteLine("введите строку от 1 до 5");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите столбец от 1 до 5");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,9);
        System.Console.Write($"{array[i,j]} ");
    }
    System.Console.WriteLine();
}

if (num1 == 0 && num2 == 0)
{
    System.Console.WriteLine("число 0 не принимается");   
}

if (num1 <= array.GetLength(0) && num2 <= array.GetLength(1))
{
    System.Console.WriteLine($"по индексу строки {num1} и индексу столбца {num2} находится элемент массива {array[num1 - 1,num2 - 1]}");
}
else
{
    System.Console.WriteLine($"числа {num1}{num2} нет в массиве");
}

