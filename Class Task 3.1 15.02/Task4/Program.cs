

// Kvadrat bo sitoraxo ruchnoy size:

// void PrintRectangle(int darozi, int balandi)
// {
//     for (int i = 0; i < balandi; i++)
//     {
//         PrintStars(darozi);
//         System.Console.WriteLine();

//     }
// }
// void PrintStars(int darozi)
// {
//     for (int i = 0; i < darozi; i++)
//     {
//         System.Console.Write("*");
//     }
// }

//     System.Console.Write("Darozii kvadrati sitoraxotona navise :");
//     int darozi = int.Parse(Console.ReadLine());
//     System.Console.Write("Balandii kvadrati sitoraxotona navise :");
//     int balandi = int.Parse(Console.ReadLine());
        
//         PrintRectangle(darozi, balandi);



// Kvadrati sitoraxo automatic
    //  int n = Convert.ToInt32(Console.ReadLine());
        
    //     for (int i = 0; i < n; i++) {
    //         for (int j = 0; j < n; j++) {
    //             Console.Write("*");
    //         }
    //         Console.WriteLine();
    //     }
    
    // Sekunjai Rostkunja
    // int h = int.Parse(Console.ReadLine());
    // string z = "*";
    // for (int i = 0; i < h; i++)
    // {
    //     Console.WriteLine(z);
    //     z += "**";
    // }




int a = int.Parse(Console.ReadLine());
string b = "*";
for (int i = 0; i <= a * 2; i++)
{
    System.Console.Write(b);
    if (i==a)Console.WriteLine();
    if (i==a*2);
}