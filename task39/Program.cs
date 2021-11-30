// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Сколько элементов в массиве?");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
Console.WriteLine("Введите значение для массива:");
for (int i = 0; i < num; i++){
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length/2; i++){
    Console.WriteLine($"Пара {i + 1}:");
    Console.WriteLine(array[i] * array[array.Length - i - 1]);
}
if (array.Length % 2 != 0){
    Console.WriteLine($"Недопара {(array.Length / 2)+ 1}: {array[(array.Length / 2)+ 1]}");
}