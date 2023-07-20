using System;
using static System.Console;
int PrintNumbers(int n, int m)
{
    int sum = 0;
    if(n == m)
    {
        return 0;
    
    }
    sum = sum + PrintNumbers(n - 1, m - 1);
    return sum;
}
WriteLine("Введите число N");
int n = int.Parse(ReadLine());
WriteLine("Введите число M");
int m = int.Parse(ReadLine());
WriteLine(PrintNumbers(n, m));
