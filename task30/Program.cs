// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число N:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Кубы чисел от 1 до N , заканчивающихся на четную цифру:");
for (int i = 1; i <= number; i++){
    if ((Math.Pow(i, 3)%10)%2 == 0){
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}