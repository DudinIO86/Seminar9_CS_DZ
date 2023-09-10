// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SetNumber(string Number=" ")
{
    System.Console.WriteLine($"Введите размер {Number}");
    int num=int.Parse(Console.ReadLine());
    return num;
}

int SumNumbers(int M, int N)
{
    int sum=M;
    if(M==N)
    {
        return sum;
    }
   
    return sum+SumNumbers(M+1,N);
}

int M=SetNumber("M= ");
int N=SetNumber("N= ");

System.Console.WriteLine(SumNumbers(M,N));