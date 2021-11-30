//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("введите делитель");
int del = int.Parse(Console.ReadLine());
if ( number % del == 0){
    Console.WriteLine($"Число {number} кратко числу {del}");
}
else{
    Console.WriteLine($"Число {number} не кратко числу {del}");
}