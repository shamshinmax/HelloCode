//Частотный анализ
Console.WriteLine("Напишите текст:");
string text = Console.ReadLine();
string[] arr = new string[text.Length];
string[] arr2 = new string[text.Length];
void ConvertTxtToMass(string txt, string[] array){
    for(int i = 0; i < txt.Length; i++){
        array[i] = Convert.ToString(txt[i]);
    }
}
void PrintArray(string[] arr){
    for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}
}
int Unical(string[] arr, string[] arr2){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if(sravnenie(arr, arr2, i) == 0){
            arr2[count] = arr[i] ;
            count++;
        }
    }
    return count;


}
int sravnenie(string[] arr, string[] arr2, int i){
    int flag = 0;
    for (int j = 0; j < arr2.Length; j++){
        if(arr[i] == arr2[j]){
            flag++;
    }
    }
    return flag;

}
void sravnenie2(string[] arr, string[] arr2, int number){
    int count = 0;
    for(int i = 0; i < number; i++){
        for(int j = 0; j < arr2.Length; j++){
            if(arr2[i] == arr[j]){
                count++;   
            }
        }
        if (arr2[i] != " "){
            Console.WriteLine($"Всего {arr2[i]} в массиве: {count}. Частота {Math.Round(Convert.ToDouble(count)/Convert.ToDouble(arr.Length)*100, 3)}%");
            count = 0;
        }
        else{
            Console.WriteLine($"Всего пробелов в массиве: {count}. Частота {Math.Round(Convert.ToDouble(count)/Convert.ToDouble(arr.Length)*100, 3)}%");
            count = 0;
        }

    }
}

ConvertTxtToMass(text, arr);
PrintArray(arr);
Console.WriteLine();
int number = Unical(arr, arr2);
PrintArray(arr2);
Console.WriteLine();
Console.WriteLine($"Всего символов: {arr.Length}");
sravnenie2(arr, arr2, number);