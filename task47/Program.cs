// Написать программу копирования массива
//void Method1() 
//{
 //   Console.WriteLine("Автор ...");
//}
// Вызов
//Method1();
Console.WriteLine("Введите значения массива:");
int[] array = new int[10];
for (int i = 0; i < 10; i++){
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Массив:");
for (int i = 0; i < 10; i++){
    Console.Write($"{array[i]} ");
}
void Returnmass(int[] array){
    int[] array2 = new int[array.Length];
    for (int i = 0; i < 10; i++){
        array2[i] = array[i];
    }
    Console.WriteLine();
    Console.WriteLine("Массив:");
    for (int i = 0; i < array2.Length; i++){
         Console.Write($"{array2[i]} ");
}
}
Returnmass(array);