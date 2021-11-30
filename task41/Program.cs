// являются сторонами треугольника если a+b>C и b+c>a и a+c>b.
// Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Введите а:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c:");
int c = int.Parse(Console.ReadLine());
if ((a + b) > c && (b + c) > a && (a + c) > b){
    Console.WriteLine($"Стороны {a} {b} {c} являются сторонами треугольника");
}
else {
    Console.WriteLine($"Стороны {a} {b} {c} не являются сторонами треугольника");
}