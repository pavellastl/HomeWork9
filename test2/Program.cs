using System;
using static System.Console;
int PlusNumbers(int n, int m)
{
    int sum = 0;
    if(n == m)
    {
        return 0;
    
    }
    sum = sum + PlusNumbers(n + 1, m);
    return sum;
}
WriteLine("Введите число N");
int n = int.Parse(ReadLine());
WriteLine("Введите число M");
int m = int.Parse(ReadLine());
WriteLine(PlusNumbers(n, m));
