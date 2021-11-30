// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисеl

Random freenum = new Random();
Console.WriteLine("Введите число элементов массива:");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < array.Length; i++){
    array[i] = freenum.Next(100, 1000);
}
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}
int countChet = 0;
int countNeChet = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0){
        countChet++;
    }
    else{
        countNeChet++;
    }
}
Console.WriteLine();
Console.WriteLine($"Четных:{countChet}");
Console.WriteLine($"Нечетных:{countNeChet}");