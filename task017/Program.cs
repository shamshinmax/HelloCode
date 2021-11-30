//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

if (number1*number1  == number2  | number2*number2  == number1 ){
    if (number1 > number2){
        Console.WriteLine($"Число {number1} является квадратом числа {number2}");
    }
    else{
        Console.WriteLine($"Число {number2} является квадратом числа {number1}");
    }
    
}
else{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}