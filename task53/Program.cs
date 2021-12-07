// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int m = 5;
int n = 5;
bool flag = false;
int[,] array = new int[m,n];
Random rand = new Random();
Console.Write("Введите требуемый элемент:");
int number= int.Parse(Console.ReadLine());
void FillArray(int n, int m, int[,] array){
    for(int i = 0; i < m; i++ ){
        for(int j = 0; j < n; j++ ){
            array[i,j] = rand.Next(10);
        
    }
    }
}
void PrintArray(int m, int n, int[,] array){
    for(int i = 0; i < m; i++ ){
        for(int j = 0; j < n; j++ ){
            Console.Write($"{array[i,j]} ");
     }
    Console.WriteLine();
    }
}
void IftoReturn(int number, int[,] array){
    for(int i = 0; i < m; i++ ){
        for(int j = 0; j < n; j++ ){
            if(array[i,j]==number){
                Console.WriteLine($"Позиция числа {number}: ({i};{j})");
                flag = true;
            }
        
    }
    }
    if (flag == false){
        Console.WriteLine("Такого числа нету :(");
    }
}
FillArray(m, n, array);
PrintArray(m, n, array);
IftoReturn(number, array);