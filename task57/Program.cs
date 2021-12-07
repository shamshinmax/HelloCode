// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// Написать программу, которая обменивает элементы первой строки и последней строки
int m = 5;
int n = 5;
int max = 0;
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
void StringTallToLow(int m, int[,] array){
    for (int k = 0; k < m; k++){
        for (int i = 0; i < array.GetLength(1); i++)
		    for (int j = 0; j < array.GetLength(1) - 1; j++)
		 	    if (array[k, j] < array[k, j + 1]){
                    int temp = array[k, j + 1];
		 		    array[k, j + 1] = array[k, j];
		 		    array[k, j] = temp;
                 }

		}
} 
FillArray(n, m, array);
Console.WriteLine("Изначальный массив:");
PrintArray(m, n, array);
Console.WriteLine();
StringTallToLow(m, array);
Console.WriteLine("Изменённый массив:");
PrintArray(m, n, array);
