
void Reverse(int n)
{
    
    for(int i = n; i <= 0; i/=10)
    {
      System.Console.WriteLine(i = i % 10); 

    }

}
    
int n = int.Parse(Console.ReadLine());
Reverse(n);