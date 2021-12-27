// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int m = 5;
int n = 5;
int stroka = 0;
int column = 0;
Random rand = new Random();
int [,] array = new int[m,n];
void FillArray(int m, int n, int[,] array){
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < m ; j++){
            array[i, j] = rand.Next(50);
            
        }
    }
}
void PrintArray(int[,] array)
{
    int count = array.Length;
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < m ; j++){
            Console.Write($"{array[i, j]} ");
        }
     Console.WriteLine();
    }
}
void FindMinIndex(int[,] array){
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (array[i,j] < min){
                min = array[i,j];
                stroka = i;
                column = j;
            }
        }
    }
}
void DeleteSringColumn(int[,] array, int stroka, int column){
    for (int i = 0; i < array.GetLength(0); i++){
        array[i, column] = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            array[stroka, j] = 0;
        }
    }
}
FillArray(m, n, array);
PrintArray(array);
FindMinIndex(array);
DeleteSringColumn(array, stroka, column);
Console.WriteLine();
PrintArray(array);
