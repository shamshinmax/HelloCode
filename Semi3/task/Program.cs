//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите от 10 до 99");
int x = int.Parse(Console.ReadLine());
int temp = x % 10;
x =  x / 10;
if (temp > x ){
    Console.WriteLine(temp);
}
else{
    Console.WriteLine(x);
}