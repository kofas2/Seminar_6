// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,100);
    }
}

void PrintArray(int []array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void ReverseArray(int [] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        (array[i] , array [array.Length - 1 -i]) = (array[array.Length - 1 -i] , array[i]); // множественное присваивание
    }
    // {
    //     int temp = array [i];
    //     array[i] = array [array.Length - 1 -i];
    //     array [array.Length -1 -i] = temp; 
    // }
}




Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
ReverseArray(array);
PrintArray(array);

