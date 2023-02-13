#region Task1

//Требуется сгенерировать двумерный массив по введённым пользователем размерам.

Random rand = new Random();
int sum1 = 0;
int sum2 = 0;
int sum3 = 0;

Console.WriteLine("Введите размеры генерируемого массива.");
Console.WriteLine("Введите количество столбцов.");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк.");
int m = int.Parse(Console.ReadLine());
int[,] ints1= new int[m, n];

Console.WriteLine();
Console.WriteLine("Первый массив :");
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        ints1[i, j] = rand.Next()%100;
        Console.Write(ints1[i, j]);
        Console.Write(" ");
        sum1 = sum1 + ints1[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Сумма всех эл-тов массива 1 = " + sum1);
Console.ReadLine();
#endregion

#region Task2

int[,] ints2 = new int[m, n];


Console.WriteLine("Второй массив :");
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        ints2[i, j] = rand.Next() % 100;
        Console.Write(ints2[i, j]);
        Console.Write(" ");
        sum2 = sum2 + ints2[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Сумма всех эл-тов массива 2 = " + sum2);

Console.WriteLine();
Console.ReadLine();

int[,] ints3 = new int[m, n];

Console.WriteLine("Массив, полученный в результате слияния первых двух массивов :");
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        ints3[i, j] = ints1[i, j] + ints2[i, j];
        Console.Write(ints3[i, j]);
        Console.Write(" ");
        sum3 = sum3 + ints3[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Сумма всех эл-тов суммарного массива = " + sum3);
Console.ReadLine();
#endregion