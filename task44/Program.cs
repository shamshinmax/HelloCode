// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите b1 k1 и b2 k2");
int b1 = int.Parse(Console.ReadLine());
int k1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int x1 = (b2-b1/k1-k2);
int y1 = k1 * x1 + b1;
Console.WriteLine($"Точки пересечения ({x1};{y1})");