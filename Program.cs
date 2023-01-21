// Teste fil for Git commit.

using System.ComponentModel;

Console.WriteLine("Hello Git!");

static void test()
{
    Console.WriteLine("\nThis function prints the multiplication table. Pick a number:");
    int tall = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"\nPrinting multiplication table for {tall}:");
    Console.WriteLine("");
    for (int i = 1; i < 11; i++)
        Console.WriteLine(tall * i);
}

test();