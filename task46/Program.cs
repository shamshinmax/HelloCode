// 46. Написать программу масштабирования фигуры
//```
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 олучаем "(0,0) (4,0) (4,4) (0,4)"
Console.WriteLine("Введите значения вершнин фигуры");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// int x3 = int.Parse(Console.ReadLine());
// int y3 = int.Parse(Console.ReadLine());
// int x4 = int.Parse(Console.ReadLine());
// int y4 = int.Parse(Console.ReadLine());
int x1 = 0;
int y1 = 0;
int x2 = 2;
int y2 = 0;
int x3 = 2;
int y3 = 2;
int x4 = 0;
int y4 = 2;
Console.WriteLine("Введите k:");
int k = int.Parse(Console.ReadLine());
int [,] array = new int[x2, y4];
void PrintArray(int[,] array)
{
    int count = array.Length;
    for (int i = 0 ; i < x2 ; i++){
        for (int j = 0 ; j < y4 ; j++){
            Console.Write($"*");
        }
     Console.WriteLine();
    }
}
PrintArray(array);
x1 = x1 * k;
y1 = y1 * k;
x2 = x2 * k;
y2 = y2 * k;
x3 = x3 * k;
y3 = y3 * k;
x4 = x4 * k;
y4 = y4 * k;
Console.WriteLine($"({x1};{y1}) ({x2};{y2}) ({x3};{y3}) ({x4};{y4})");
PrintArray(array);
