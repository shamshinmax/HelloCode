// 24. Найти кубы чисел от 1 до N
//25. Найти сумму чисел от 1 до А
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Куб чисел от 1 до {n}:");
for (int i = 1; i < n + 1; i++){
    Console.Write($"{Math.Pow(i, 3)} ");
    
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел от 1 до {n}:");
int summ = 0;
for (int i = 1; i < n + 1; i++){
    summ = summ + i;
}
Console.WriteLine(summ);