Console.WriteLine("Введите 3 числa:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int m = a;
for (int i = 1; i < 4; i++){
    if (m > b){
        m = a;
    }
    else {
        m = b;
    }
    if (m < c){
        m = c;
    }
    
}
Console.WriteLine("{0} {1}", "Макс.число =", m);