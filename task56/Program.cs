// Написать программу, которая обменивает элементы первой строки и последней строки
int m = 5;
int n = 5;
Random rand = new Random();
int [,] array = new int[m,n];
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
void ReplaceOneToLast(int m, int[,] array){
    int temp = 0;
    for (int i = 0; i < m; i++){
        temp = array[0, i];
        array[0, i] = array[m-1,i];
        array[m-1,i] = temp;
}
}
FillArray(n, m, array);
Console.WriteLine("Изначальный массив:");
PrintArray(m, n, array);
Console.WriteLine();
ReplaceOneToLast(m, array);
Console.WriteLine("Изменённый массив:");
PrintArray(m, n, array);

