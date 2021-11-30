//27. Определить количество цифр в числе
Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
string totxt = number.ToString();
Console.WriteLine($"В числе {number} {totxt.Length} цифр");