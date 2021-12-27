//73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
Console.WriteLine("Введите первое число:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int second = int.Parse(Console.ReadLine());
int third = 0;
void Fibonacci(int first, int second)
{
    third = first + second;
    Console.WriteLine(third);
    first = second;
    second = third;
    if (third < 1000)
    {
        Fibonacci(first, second);
    }
    
}
Fibonacci(first, second);