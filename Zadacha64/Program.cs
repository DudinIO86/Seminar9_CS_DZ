// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();

int SetNumber(string Number = " ")
{
    System.Console.WriteLine($"Введите число {Number}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

string StringRangeNumber(int numberN, int start)
{

    if (start == 1)
    {
        return 1.ToString();
    }
   
    return $"{start}, {StringRangeNumber(numberN, start - 1)}";

}

int number = SetNumber("N");

System.Console.WriteLine(StringRangeNumber(number, number));