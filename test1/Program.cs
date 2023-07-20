using System;
using static System.Console;
string PrintNumbers(int n)
{
    n = n - (n - 1);
    if(n == n)
    {
        string s = PrintNumbers(n + 1) + ", " + n.ToString();
    return s;
    
    }
    return n.ToString();
}
WriteLine("Введите число N");
int n = int.Parse(ReadLine()!);
WriteLine(PrintNumbers(n));
