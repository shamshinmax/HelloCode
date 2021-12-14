// Найти произведение двух матриц
// Задать двумерный массив mxn
Console.WriteLine("Введите кол-во строк и столбцов mxn:");
int m = 2;
int n = 2;
Random rand = new Random();
int [,] array1 = new int[m, n];
int [,] array2 = new int[m, n];
int[,] finalArray = new int[m, n];
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
array1[0,0] = 44;
array1[0,1] = 24;
array1[1,0] = 16;
array1[1,1] = 16;
array2[0,0] = 45;
array2[0,1] = 9;
array2[1,0] = 13;
array2[1,1] = 7;
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
void multiplication(int[,] array1, int[,] array2, int[,] finalArray){//                      44 24         45 9     |44*45+24*13|  |24*13 + 16 * 7|
    for (int i = 0; i < m; i++){                                     //                      16 16         13 7     |16*45+16*13|
        for (int j = 0; j < m; j++){
            for (int k = 0; k < m; k++){
                finalArray[i,j] = finalArray[i,j] + (array1[i, k] * array2[k, j]);
                Console.WriteLine($"{i} {j}");

            }
            //[0, 0]0 0 * 0 0 + 0 1 * 1 0 
            //[0, 1]0 1 * 1 0 + 1 1 * 1 0 
            //[1, 0]1 0 * 0 0 + 1 1 * 0 1
            //[1, 1]1 0 * 0 1 + 1 1 * 1 1
                }

        }
    }
multiplication(array1, array2, finalArray);
PrintArray(finalArray);