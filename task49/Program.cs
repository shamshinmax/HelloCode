// Показать двумерный массив размером m×n заполненный вещественными числами
// Задать двумерный массив mxn
Console.WriteLine("Введите кол-во строк и столбцов mxn:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
double [,] array = new double[m, n];
void FillArray(int m, int n){
    for (int i = 0 ; i < m ; i++){
        for (int j = 0 ; j < m ; j++){
            array[i, j] = rand.NextDouble() + rand.Next(10);
            
        }
    }
}
void PrintArray(double[,] array)
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