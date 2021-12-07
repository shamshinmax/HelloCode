//Частотный анализ
Console.WriteLine("Напишите текст:");
string text = Console.ReadLine();
string[] arr = new string[text.Length];
void ConvertTxtToMass(string txt, string[] array){
    for(int i = 0; i < txt.Length; i++){
        array[i] = Convert.ToString(txt[i]);
    }
}
ConvertTxtToMass(text, arr);
for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}

