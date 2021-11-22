Console.WriteLine("Введите 1 чилсло:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 чилсло:");
int numberB = int.Parse(Console.ReadLine());
if (numberB == numberA * numberA)
{
    Console.WriteLine("{0} {1} {2} {3}", "Число ", numberB, "является квадратом числа", numberA);
}
else {
    Console.WriteLine("{0} {1} {2} {3}", "Число", numberB, "не является квадратом числа", numberA);
}

