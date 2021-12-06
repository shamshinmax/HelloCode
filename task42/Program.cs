// 42. Определить сколько чисел больше 0 введено с клавиатуры
int count = 0;
string txt = "да";
while (txt == "да"){
    Console.WriteLine("Введите число с клавиатуры:");
    int num = int.Parse(Console.ReadLine());
    if ( num >= 0 ){
        count ++;
    }
    Console.WriteLine("Дальше или нет?");
    txt = Console.ReadLine();


}
Console.WriteLine($"С клавитуры было введено {count} чисел больше нуля");
