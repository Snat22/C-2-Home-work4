
// void PrintStar(int n)
// {
//     string z = "*";
//     for (int i = 0; i < n; i++)
//     {
//         System.Console.Write(z + " ");
//     }
// }
// int n = int.Parse(Console.ReadLine());
// PrintStar(n);
System.Console.Write("Write visotai Yolkatona: ");
int visota = int.Parse(Console.ReadLine());
int space = int.Parse(Console.ReadLine());
int z = 1;
for (int i = 0; i < visota; i++)
{
    for (int j = 0; j < space; j++)
    {
        System.Console.Write(" ");
    }
    for (int k = 0; k < z; k++)
    {
        System.Console.Write("*");
    }
    space -= 1;
    z += 2;
    System.Console.WriteLine();
}
