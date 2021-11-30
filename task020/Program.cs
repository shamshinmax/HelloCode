Console.WriteLine($"Введите 5-значное число:");
int num1 = int.Parse(Console.ReadLine());
string txt1 = num1.ToString();
bool flag = true;

for (int i = 0; i < txt1.Length; i++){
    if (txt1[i] != txt1[txt1.Length - i - 1]){
        flag = false;
        break;   
    }  
}
if (flag){
    Console.WriteLine($"Число {num1} является палиндромом");
}
else{
    Console.WriteLine($"Число {num1} не является палиндромом");
}
