void EvenNumber(int a,int b)
{
    if(a%2==0)
    {
        if(a>b) {
        System.Console.WriteLine("");
    }else
    {
        System.Console.Write($"{a} ");
        EvenNumber(a+2,b);
    }
    }   else
    {
        System.Console.Write($"{a+1} ");
        EvenNumber(a+3,b);
    }
}


void OddNumber(int a,int b)
{
    if(a%2!=0)
    {
        if(a>b) {
        System.Console.WriteLine("");
    }else
    {
        System.Console.Write($"{a} ");
        OddNumber(a+1,b);
    }
    }   else
    {
        System.Console.Write($"{a+1} ");
        OddNumber(a+3,b);
    }
}
System.Console.Write("Write num az chand :");
int n = int.Parse(Console.ReadLine());
System.Console.Write("Write num to chand :");

int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("All even numbers from 1 to 20 are : ");
EvenNumber(n,b);

System.Console.WriteLine("All even numbers from 1 to 20 are : ");
OddNumber(n,b);