//  В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("Сколько элементов в массиве?");
int num = int.Parse(Console.ReadLine());
double[] array = new double[num];
//Console.WriteLine("Введите значение для массива:");
//for (int i = 0; i < num; i++){
//    array[i] = double.Parse(Console.ReadLine());
//}
Random rand = new Random();
for (int i = 0; i < num; i++){
    array[i] = rand.Next(-100, 100) + rand.NextDouble();
}
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}
double max = array[0];
double min = array[0];
Console.WriteLine();
for (int i = 0; i < array.Length; i++){
    if (array[i] > max){
        max = array[i];
    }
    if (array[i] < min){
        min = array[i];
    }
}
Console.WriteLine($"Минимальное число из массива: {min}");
Console.WriteLine($"Максимальное число из массива: {max}");