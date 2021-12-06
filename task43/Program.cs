//Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите число в 10 системе счисления:");
int number10 = int.Parse(Console.ReadLine());
string number2temp = "";
string number2 = "";
while (number10 > 1){
    if (number10 % 2 == 0){
        number2temp = number2temp + "0";
    }
    else{
        number2temp = number2temp + "1";
    }
    number10 = number10 / 2;

}
for (int i = 0; i < number2temp.Length; i++){
    number2 = number2 + number2temp[number2temp.Length - 1 - i];
    
}
Console.WriteLine($"Число {number10} в двоичной системе счисления : {number2}");