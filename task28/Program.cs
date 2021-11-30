// 28. Подсчитать сумму цифр в числе
Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
int count = 0;
int toResult = number;
while (number > 0){
    count = count + (number%10);
    number = number / 10;
}
Console.WriteLine($"Сумма цифр {toResult} = {count}");