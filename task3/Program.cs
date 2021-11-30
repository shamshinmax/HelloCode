Console.WriteLine("Введите 1 число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("{0} {1} {2} {3}", "Число", numberA, "больше числа", numberB);
}
else {
    Console.WriteLine("{0} {1} {2} {3}", "Число", numberB, "больше числа", numberA);
    }