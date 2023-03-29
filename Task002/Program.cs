// Задача 40: Напишите программу, которая принимает на вход три числа и п 
// роверяет, может ли существовать треугольник с сторонами такой длины. 


int MessageToUser(string message)
{
    System.Console.Write(message);
    string userInput = System.Console.ReadLine();
    int result = int.Parse(userInput);
    return result;
}

void ChekTriangle(int a, int b, int c)
{
    if (a<b+c && b<a+c && c<a+b)
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} - существует");
    }
    else 
    {
        Console.WriteLine("Такого треугольника не существует");
    }
}

// bool triangleExists (int a, int b, int c) 
// { 
//     if ((a + b > c) && (a + c > b) && (b + c > a)) return true; 
//     else return false; 
// }




//AB<AC+CB - теорема о неравенстве треугольника
int a = MessageToUser("Введите длину первой стороны: ");
int b = MessageToUser("Введите длину первой стороны: ");
int c = MessageToUser("Введите длину первой стороны: ");
ChekTriangle(a,b,c);