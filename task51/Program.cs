// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("Введите кол-во строк и столбцов mxn:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int [,] array = new int[m, n];
void FillArray(int m, int n){
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < m ; j++){
            array[i, j] = i + j;
            
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
     Console.WriteLine("|");
    }
}
FillArray(m, n);
PrintArray(array);