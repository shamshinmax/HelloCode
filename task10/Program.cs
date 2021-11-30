//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
while(number > 999){
    number = number / 10;
    
}
Console.WriteLine(number%10);