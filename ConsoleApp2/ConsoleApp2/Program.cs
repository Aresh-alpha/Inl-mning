﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett hel tal mellan 1 till 101! ");
            
            Random random = new Random();
            int randomZ = random.Next(1 , 101);
            int Gissa;
            do
            {
                Gissa = int.Parse(Console.ReadLine());
                if (Gissa < randomZ)
                {
                    Console.WriteLine("Du gissade för låg");
                }
                else if (Gissa > randomZ)
                    Console.WriteLine("Du gissade för hög");

            } while (Gissa != randomZ);
                Console.WriteLine("Grattis du gissade rätt");


        }
    }
}
