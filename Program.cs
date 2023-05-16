using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введіть друге слово: ");
        string word2 = Console.ReadLine();

        string commonLetters = new string(word1.Intersect(word2).Distinct().ToArray());

        Console.Write("Літери, які є в обох словах: ");
        for (int i = 0; i < commonLetters.Length; i++)
        {
            Console.Write(commonLetters[i]);
            if (i < commonLetters.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.ReadKey();
    }
}
