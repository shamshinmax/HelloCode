﻿// Задать двумерный массив mxn
Console.WriteLine("Введите кол-во строк и столбцов mxn:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Random rand = new Random();
int [,] array = new int[m, n];
//rand.Next(10) от 0 до 9
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // Вызов
// int year = Method3();
void FillArray(int m, int n){
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
FillArray(m, n);
PrintArray(array);