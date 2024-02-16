

void Recursion(int n)
{
    if (n == 0)
    {
        return ;
    }else
    {
        Recursion(n/10);
        System.Console.Write($"{n%10} ");
    }
    
}
// System.Console.Write("Write number for find sum of num:");
int n = int.Parse(Console.ReadLine());
Recursion(n);
