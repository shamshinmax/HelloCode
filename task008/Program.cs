Console.WriteLine("Введите от 100 до 1000");
int x = int.Parse(Console.ReadLine());
int temp = x % 10;
x = (x / 100) * 10;
x = x + temp;
Console.WriteLine(x);
