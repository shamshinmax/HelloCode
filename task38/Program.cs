//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Random freenum = new Random();
int[] array = new int[123];
for (int i = 0; i < array.Length; i++){
    array[i] = freenum.Next(0, 1000);
}
Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}
int numbers = 0;
for (int i = 0; i < array.Length; i++){
    if ((array[i] > 9) && (array[i] < 100)){
        numbers++;


    }
}
double probability =  Convert.ToDouble(numbers)/Convert.ToDouble(array.Length);
Console.WriteLine();
Console.WriteLine($"Количества элементов в отрезке [10, 99]= {numbers}");
Console.WriteLine($"Вероятность выпадения равно в данном случае равна = {probability * 100}");