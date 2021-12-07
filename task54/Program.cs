// В матрице чисел найти сумму элементов главной диагонали
int m = 5;
int n = 5;
int summ = 0;
int count = 0;
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
void DiagSumm(int[,] array, int m){
    for (int i = 0; i < m; i++){
        summ = summ + array[i, i];
    }
        
}
    
FillArray(n, m, array);
PrintArray(n, m, array);
DiagSumm(array, m);
Console.WriteLine($"Сумма равна : {summ}");