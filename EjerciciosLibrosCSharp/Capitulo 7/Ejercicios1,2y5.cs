using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibrosCSharp.Capitulo_7
{
    class Ejercicios1_2y5
    {
        public static void Ejercicio5()
        {
            string cadena1;
            string cadena2;

            Console.WriteLine("Digite la primera cadena: ");
            cadena1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite la Segunda cadena: ");
            cadena2 = Convert.ToString(Console.ReadLine());

            if (cadena2.CompareTo(cadena1) == 1)
            {
                Console.WriteLine("Cadenas ordenadas Alfaveticamente");
                Console.WriteLine(cadena1);
                Console.WriteLine(cadena2);

            }
            if (cadena1.CompareTo(cadena2) == 1)
            {
                Console.WriteLine("Cadenas ordenadas Alfaveticamente");
                Console.WriteLine(cadena2);
                Console.WriteLine(cadena1);

            }

        }
    }
}
