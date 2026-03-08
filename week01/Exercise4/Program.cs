using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Pedir al usuario que ingrese numeros y si quiere parar que escriba 0

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = -1;
        while (number != 0)
        {

            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if(number != 0)
            {
                numbers.Add(number);
            }

        }

        //Calcule la suma total de los num
        int sum = 0;

        foreach (int numlist in numbers)
        {
            sum += numlist;
        }

        Console.WriteLine($"The sum is: {sum}");
        //Calcule el promedio de los numeros en la lista

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Encuentre el numero más grande

        int max = numbers[0];

            foreach (int numberlist in numbers)
        {
            if (numberlist > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = numberlist;
            }
        }

        Console.WriteLine($"The max is: {max}");
        
        
    }
}