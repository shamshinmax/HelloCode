// 72. Написать программу возведения числа А в целую стень B
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int step = int.Parse(Console.ReadLine());
int count = 1;
void NumIntoStep(int number, int step)
{
    count = count * number;
    if ((step - 1) != 0)
    {
        NumIntoStep(number, step-1);
    } 
}
NumIntoStep(number, step);
Console.WriteLine($"Число {number} в степени {step} = {count}");
