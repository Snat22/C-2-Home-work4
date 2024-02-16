
void Recursion(int n)
{
    if (n <= 0)
    {
        System.Console.WriteLine("");
    }
    else
    {
        
        System.Console.Write($"{n} ");
        Recursion(n-1);
        
         
    }
}
int n = 10;
Recursion(n);