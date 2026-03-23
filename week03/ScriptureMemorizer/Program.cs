using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS: 
        // 1. The program is smart: it only selects words that are not already hidden to be hidden next. 
        //    This prevents the program from randomly selecting already hidden words and appearing to do nothing.
        // 2. It hides multiple words per turn (3 words) to make the game flow better.

        // 1. Crear la Referencia (usaremos el constructor de rango que hicimos)
        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        
        // El texto de la escritura correspondiente
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // 2. Crear el objeto Scripture uniendo la referencia y el texto
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        // 3. El bucle principal del juego
        string userInput = "";

        // El juego continúa mientras el usuario no escriba "quit" 
        // y mientras la escritura NO esté completamente oculta
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            // Limpiamos la consola para dar el efecto de que el texto se actualiza en el mismo lugar
            Console.Clear();
            
            // Mostramos la escritura actual (con las palabras ocultas que correspondan)
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            // Le damos instrucciones al usuario
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            // Si el usuario simplemente presionó Enter (dejó el texto vacío), ocultamos 3 palabras
            if (userInput == "")
            {
                scripture.HideRandomWords(3);
            }
        }

        // Cuando el bucle termina (ya sea por "quit" o porque se ocultó todo), 
        // hacemos una última limpieza y mostramos el resultado final.
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Congratulations! You have memorized the scripture.");
        }
    }
}