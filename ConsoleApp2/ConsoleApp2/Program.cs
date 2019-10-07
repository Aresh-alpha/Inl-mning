using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett hel tal mellan 1 till 9! ");
            int Gissa = int.Parse(Console.ReadLine());
            if (Gissa < 2)
            {
                Console.WriteLine("Du gissade för låg");
            }
            else if (Gissa > 2)
                Console.WriteLine("Du gissade för hög");
            else
                Console.WriteLine("Grattis du gissade rätt");



        }
    }
}
