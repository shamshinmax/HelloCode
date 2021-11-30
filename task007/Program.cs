Console.WriteLine("Введите значение a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("{0} {1} {2} {3}", "Все числа от", a * -1 , "до", a);
for (int i = -a; i < a + 1; i++)
{
    Console.Write(" {0} ", i);
}