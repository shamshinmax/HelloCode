//34. Написать программу замену элементов массива на противоположные
Console.WriteLine("Массив какой длины хотите ввести и изменить?");
int x = int.Parse(Console.ReadLine());
int[] array = new int[x];
Console.WriteLine("Введите значения массива поочередно:");
for (int i = 0; i < x; i++){
    int num = int.Parse(Console.ReadLine());
    array[i] = num;
}
for (int i = 0; i < array.Length; i++){
    array[i] = array[i] * (-1);
}    
for (int j = 0; j < array.Length; j++){
    Console.Write($"{array[j]}");
}