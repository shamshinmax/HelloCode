// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.WriteLine("Введите кол-во строк и столбцов mxn:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
int[,] array = new int[m,n];
void FillArray(int m, int n, int[,] array){
    for (int i = 0; i < m; i++){
       for (int j = 0; j < n; j++){
           array[i,j] = rand.Next(10);
    }
    }
}
void ifToStep2(int m, int n, int[,] array){
    for (int i = 0; i < m; i++){
       for (int j = 0; j < n; j++){
           if (i%2 == 0 && j%2 == 0 && i != 0 && j != 0){
               array[i,j] = array[i,j]* array[i,j];
           }
    }
    }
}
void PrintArray(int m, int n, int[,] array){
    for (int i = 0; i < m; i++){
       for (int j = 0; j < n; j++){
           Console.Write($"{array[i,j]}  ");
       }
    Console.WriteLine();
    }

}
FillArray(m, n, array);
PrintArray(m, n, array);
Console.WriteLine();
ifToStep2(m, n, array);
PrintArray(m, n, array);
