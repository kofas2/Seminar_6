// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int MessageToUser(string message)
{
    System.Console.Write(message);
    string userInput = System.Console.ReadLine();
    int result = int.Parse(userInput);
    return result;
}


void Fibonacci(int [] array)
{   
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
}


void PrintArray(int[]array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}




int num = MessageToUser("Введите целое число: ");
int []array = new int[num];
Fibonacci(array);
PrintArray(array);


