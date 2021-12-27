// 46. Написать программу масштабирования фигуры
//```
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 олучаем "(0,0) (4,0) (4,4) (0,4)" Char.IsDigit("sample string", 7)
Console.WriteLine("Введите значения вершнин фигуры");
string text = Console.ReadLine();
int[] array = new int[8];
int k = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < text.Length; i++){
    char b = text[i];
    Console.WriteLine(b);
    if (Char.IsDigit(b)){
        array[count] = Convert.ToInt32(Convert.ToString(text[i]));
        Console.WriteLine(text[i]);
        Console.WriteLine(array[count]);
        count++;
        

    }
}
Console.WriteLine($"({array[0]*k};{array[1]*k}) ({array[2]};{array[3]}) ({array[4]};{array[5]}) ({array[6]};{array[7]})");
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);