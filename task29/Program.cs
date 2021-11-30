// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine());
int summ = 1;
for (int i = 1; i <= N; i++){
    summ = summ * i ;

}
Console.WriteLine($"Произведение чисел от 1 до {N} = {summ}");