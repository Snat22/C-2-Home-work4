int Recursion(int n)
{
    if (n <= 1)
    {
        return 1;
    }else
    {
        return n + Recursion(n -1);
        
    }
}
System.Console.Write("Write number for find sum of num:");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine(Recursion(n));


