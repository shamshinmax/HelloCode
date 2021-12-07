// В прямоугольной матрице найти строку с наименьшей суммой элементов.
int m = 5;
int n = 10;
Random rand = new Random();
int [,] array = new int[m,n];
void FillArray(int m, int n, int[,] array){
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
void WhatIsLow(int[,] array){
    int summ = 0;
    int min = 1000;
    int minInd = 0;
    for(int i = 0; i < m; i++ ){
        for(int j = 0; j < n; j++ ){
            summ = summ + array[i,j];
        }
    if (summ < min){
        minInd = i + 1;
        min = summ;

    }
    Console.WriteLine($"Сумма {i+1} строки = {summ} ");
    summ = 0;
    } 
    Console.WriteLine($"Минимальная сумма элементов в {minInd} строке");     
}
FillArray(m, n, array);
Console.WriteLine("Массив:");
PrintArray(m, n, array);
WhatIsLow(array);

