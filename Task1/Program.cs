int cnt = 1;
void Recursion(int n)
{
    
    if (cnt == n+1)
    {
        System.Console.WriteLine("");
    }
    else
    {
        System.Console.Write($"{cnt} ");
         cnt++;
        Recursion(n);
    }
}
int n = 10;
Recursion(n);