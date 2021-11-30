int find = int.Parse(Console.ReadLine());
int[] array = {3, 6, 5, 7, 1, 7, 4};
int n = array.Length;
int index = 0;
while (index < n){
    if (array[index] == find){
        Console.Write(index);
        break;
    }
    index++;
}