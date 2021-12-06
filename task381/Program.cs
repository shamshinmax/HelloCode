// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Сколько элементов в массиве?");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int[] array = new int[num];
Console.WriteLine("Введите значение для массива:");
for (int i = 0; i < num; i++){
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i = i + 2){
    sum = sum + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел элемента массива нечетных позиций: {sum}");