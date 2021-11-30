// Задать массив из 8 элементов и вывести их на экран 
// Объявить массив
string [] array = new string[8];
Console.WriteLine("Введите значения массива поочередно:");
for (int i = 0; i < 8; i++){
    string txt = Console.ReadLine();
    array[i] = txt;
    
}
for (int j = 0; j < array.Length; j++){
    Console.Write($"'{array[j]}'");
}