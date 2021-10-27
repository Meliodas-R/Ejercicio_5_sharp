using System;

namespace Ejercicio_5_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables.
            int contador = 1;
            decimal media = 0;

            // Pedimos al usuario que introduzca números mientras se cumpla la condición.
            do
            {
                Console.Write("Introduzca un número: ");
                media = media + Convert.ToDecimal(Console.ReadLine());
                contador++;
            }

            while (contador <= 3);
            media = Math.Round((media / 3), 2);
            Console.WriteLine("\nLa media es: " + media);
        }
    }
}
