using System;
//Pregunte al usuario su porcentaje de calificación y luego escriba una serie de if, else if, else instrucciones para imprimir la calificación correspondiente. (En este punto, tendrá una instrucción de impresión independiente para cada calificación en el bloque correspondiente).

//Suponga que debe obtener al menos un 70 para aprobar la clase. Después de determinar la calificación e imprimirla, agregue una instrucción if aparte para determinar si el usuario aprobó el curso y, de ser así, muestre un mensaje de felicitación. De no ser así, muestre un mensaje diferente para animarlo para la próxima vez.

//Modifique el código de la primera parte para que, en lugar de imprimir la calificación en el cuerpo de cada bloque, o, cree una nueva variable llamada ify else if, en cada bloque, asigne el valor correspondiente a esta variable. Finalmente, después de toda la serie de instrucciones, incluya una única instrucción print que imprima la calificación una sola vez.elseletterif, else if, else
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percent? ");
        string answer = Console.ReadLine();

        int percent = int.Parse(answer);

        string letter = "";

        //A >= 90
        if (percent >= 90)
        {
            letter = "A";
        }

        if (percent >= 80)
        {
            letter = "B";
        }

        if (percent >= 70)
        {
            letter = "C";
        }

        if (percent >= 60)
        {
            letter = "D";
        }

        if (percent < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if(letter == "D" || letter == "C" || letter == "B" || letter == "A")
        {
            Console.WriteLine("You approved");
        }

        if(letter == "F")
        {
            Console.WriteLine("You don´t have the enough grade, keep stuying you are amazing!");
        }


    }
}