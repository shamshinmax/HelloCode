// 35. Определить, присутствует ли в заданном массиве, некоторое число 
//void Method2(string msg)
//{
 //   Console.WriteLine(msg);
//}
// Вызов
//Method2(msg: "Текст сообщения");
void numInArray(int num){
int[] array = {1, 56, 42, 67, 234, 65};
Console.WriteLine("Заданный массив:");
for (int i = 0; i < array.Length; i++){
    Console.WriteLine($"{array[i]} ");
}
Console.WriteLine("Введите 'да' если хотите изменить массив, если нет - что либо другое:");
if (Console.ReadLine() == "да"){
    Console.WriteLine("Введите значения в массив поочередно:");
    for (int i = 0; i < array.Length; i++){
        array[i] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Новый массив:");
for (int i = 0; i < array.Length; i++){
    Console.WriteLine($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++){
    if (array[i] == num){
        Console.WriteLine($"Число {num} присутствует в массиве array");
        break;
    }
}
}
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
numInArray(num);