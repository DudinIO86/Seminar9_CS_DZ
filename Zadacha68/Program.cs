// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int SetNumber(string Number=" ")
{
    System.Console.WriteLine($"Введите размер {Number}");
    int num=int.Parse(Console.ReadLine());
    return num;
}

int SumNumbers(int m, int n)
{
    if (m == 0)
    {

        return n+1;
    }

    else
    {
        if ((m!=0) && (n==0))
        {
            return SumNumbers(m - 1, 1);
        }
        else
        {
            return SumNumbers(m-1, SumNumbers(m,n - 1));
        }
    }
}



int M = SetNumber("M= ");
int N = SetNumber("N= ");

System.Console.WriteLine(SumNumbers(M, N));