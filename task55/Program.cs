// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int m = 5;
int n = 5;
int summ = 0;
Random rand = new Random();
int[,] array = new int[m, n];
void FillArray(int n, int m, int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(10);

        }
    }
}
void PrintArray(int m, int n, int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void StolbSumm(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            summ = summ + array[j, i];
        }
        Console.WriteLine($"Сумма {i + 1} столбца = {summ}");
        summ = 0;
    }
}

FillArray(n, m, array);
PrintArray(n, m, array);
StolbSumm(array, m, n);
