using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibrosCSharp.Capitulo_8
{
    class Ejercicios3y5
    {
        public static void Ejercicio3()
        {

            DateTime thisDay = DateTime.Now;
            
            Console.WriteLine(thisDay.ToString("hh:mm:ss tt"));
            Console.WriteLine();
            
            Console.WriteLine(thisDay.ToString("yy/MM/dd"));

        }

        public static void Ejercicio5()
        {


            int C;
            int R;
            float[][] calif;
            int menu = 0;
            int cont = 0;

            float suma = 0;
            float minima;
            float maxima;

            Console.WriteLine("Dame la calificacion: ");
            calif[cont] = Convert.ToInt32(Console.ReadLine());
            minima = calif[0];
            maxima = calif[0];

            while (menu != 0)
            {
                Console.WriteLine("Dame la calificacion: ");
                calif[cont] = Convert.ToSingle(Console.ReadLine());
                if (minima > calif[cont]
    
                            minima = calif[cont];
                if (maxima < calif[cont]

                maxima = calif[cont];
                cont++;
            }

            Console.WriteLine("Suma total : {0}", suma);
            Console.WriteLine("La nota minima es: {0}", minima);
            Console.WriteLine("La nota maxima es: {0}", maxima);


        }


    }
}
