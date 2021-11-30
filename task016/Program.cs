//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите день недели:");
int number = int.Parse(Console.ReadLine());
if (number % 6 == 0 || number % 7 == 0){
    Console.WriteLine("Является днем недели");
}
else{
    Console.WriteLine("Не является днем недели");
}