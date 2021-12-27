// 70. Найти сумму цифр числа
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int count = 0;
void SummaryFigure(int number)
{
    count = count + number % 10;
    if (number != 0)
    {
        SummaryFigure(number/10);
    } 
}
SummaryFigure(number);
Console.WriteLine($"Сумма цифр = {count}");
