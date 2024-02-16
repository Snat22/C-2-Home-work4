int cnt = 0;

int Recursion(int n)
{
    if (n == 0)
    {
        return 1;
    }else
    {
        cnt++; 
        Recursion(n/10);
    }
    return cnt;
}
// System.Console.Write("Write number for find sum of num:");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(Recursion(n));

