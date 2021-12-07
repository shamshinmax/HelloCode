// В двумерном массиве n×k заменить четные элементы на противоположные
Console.WriteLine("Введите кол-во строк и столбцов mxn:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
int [,] array = new int[m, n];
void FillArray(int m, int n){
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < m ; j++){
            array[i, j] = rand.Next(10);
            if (array[i, j]%2==0){
                array[i, j] = array[i, j] * -1;
            }
            
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
