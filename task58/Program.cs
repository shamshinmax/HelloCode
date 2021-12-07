//58. Написать программу, которая в двумерном массиве заменяет строки на столбцы
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
FillArray(n, m, array);
Console.WriteLine("Изначальный массив:");
PrintArray(m, n, array);
Console.WriteLine();
Console.WriteLine("Изменённый массив:");
int [,] array2 = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++){
	for (int j = 0; j < array.GetLength(1); j++){
        int temp = array[i, j];
		array2[i, j] = array[j, i];
		array2[j, i] = temp;
    }
}
PrintArray(m, n, array2);