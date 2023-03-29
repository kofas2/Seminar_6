// 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10 


int MessageToUser(string message)
{
    System.Console.Write(message);
    string userInput = System.Console.ReadLine();
    int result = int.Parse(userInput);
    return result;
}

string NumberToBin(int number)
{
string bin = string.Empty;
while (number>0)
{
    bin += number%2;
    number = number/2;
}
return bin;
}



int number = MessageToUser("Введите целое десятичное число: ");
Console.WriteLine($"\nВведенное число в двоичной системе: {NumberToBin(number)}");