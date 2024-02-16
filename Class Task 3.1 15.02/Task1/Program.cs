void PrintFormNumberToOne(int num)
{
    for (int i = num; i > 0; i--)
    {
        System.Console.Write(i+ " ");
    }
}

int n = int.Parse(Console.ReadLine());
PrintFormNumberToOne(n);