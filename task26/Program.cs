//26. Возведите число А в натуральную степень B используя цикл
//27. Определить количество цифр в числе
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень :");
int step = int.Parse(Console.ReadLine());
int temp = A;
for (int i = 1; i < step; i++){
    A = A * temp;
}
Console.WriteLine($"Число {temp} в степени {step} = {A}");
