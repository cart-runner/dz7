Console.WriteLine("введите количество строк");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int num2 = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[num1, num2];

FillArray( array );

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-10, 10));
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine("]");

    }
}







