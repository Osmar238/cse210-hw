using System;

class Program
{
    static void Main(string[] args)
    {
        //Cual su numero magico?
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessnumber = -1;

        while (guessnumber != magicNumber)
        {
            //Cual crees que es?
            Console.Write("Guess the number: ");
            guessnumber = int.Parse(Console.ReadLine());

            //Estamos menos?
            if (guessnumber < magicNumber)
            {
                Console.WriteLine("lower");
            }

            //Estamos mucho te pasaste o estas diciendo de mas?
            else if (guessnumber > magicNumber)
            {
                Console.WriteLine("higher");
            }

            //lo encontramos
            else
            {
                Console.WriteLine("You found it");
            }
        }

    }
}













//Random randomGenerator = new Random();
//int MagicNumber = randomGenerator.Next(1, 101);