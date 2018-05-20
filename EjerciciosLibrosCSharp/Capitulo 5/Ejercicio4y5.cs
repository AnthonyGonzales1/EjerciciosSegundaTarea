using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibrosCSharp.Capitulo_5
{
    public class Ejercicio4y5
    {
        static void Ejercicio4()
        {
            int numero, resultado = 1;

            Console.WriteLine("FACTORIAL DE UN NUMERO C# n Inserta el numero:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de " + numero + " es:" + resultado);
            Console.ReadLine();
        }

        public static void Nletra(int Numeros)
        {
            string cadena;

            if ((Numeros / 1000000) > 0)
            {
                if ((Numeros / 1000000) == 1)
                {
                    cadena = ("Un Millon");
                }
                else
                {
                    cadena = Nletra(Numeros / 1000000) + "Millones" + Nletra(Numeros % 1000000);
                }
            }
            else
            {
                if ((Numeros / 1000) > 0)
                {
                    if ((Numeros / 1000) == 1)
                    {
                        cadena = "Mil" + Nletra(Numeros % 1000);
                    }
                    else
                    {
                        cadena = Nletra(Numeros / 1000) + "Mil" + Nletra(Numeros % 1000);
                    }
                }
                else
                {
                    if ((Numeros / 100) > 0)
                    {
                        if ((Numeros / 100) == 1)
                        {
                            if ((Numeros % 100) == 0)
                            {
                                cadena = "Cien";
                            }
                            else
                            {
                                cadena = "Ciento" + Nletra(Numeros % 100);
                            }
                        }
                        else
                        {
                            if ((Numeros / 100) == 5)
                            {
                                if ((Numeros / 500) == 1)
                                {
                                    cadena = " Quinientos " + Nletra(Numeros % 100);
                                }
                                else
                                {
                                    if ((Numeros / 100) == 9)
                                    {
                                        cadena = " Novecientos " + Nletra(Numeros % 100);
                                    }
                                    else
                                    {
                                        cadena = Nletra(Numeros / 100) + " Cientos " + Nletra(Numeros % 1000);
                                    }
                                }

                            }
                        }
                    }
                    else
                    {
                        if ((Numeros / 10) > 0)
                        {
                            switch ((int)(Numeros / 10))
                            {
                                case 1:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = "Diez"; break;
                                        case 1: cadena = "Once"; break;
                                        case 2: cadena = "Doce"; break;
                                        case 3: cadena = "Trece"; break;
                                        case 4: cadena = "Catorce"; break;
                                        case 5: cadena = "Quince"; break;
                                        default:
                                            cadena = "Diez y " + Nletra(numero % 10); break;
                                    }
                                    break;
                                case 2:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Veinte "; break;
                                        default:
                                            cadena = " Veinti " + Nletra(Numeros % 10); break;
                                    }
                                    break;
                                case 3:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Treinta "; break;
                                        default:
                                            cadena = " Treinta y " + Nletra(Numeros % 10); break;
                                    }
                                    break;
                                case 4:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Cuarenta "; break;
                                        default:
                                            cadena = " Cuarenta y " + Nletra(Numeros % 10); break;
                                    }
                                    break;
                                case 5:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Cincuenta "; break;
                                        default:
                                            cadena = " Cincuenta y " + Nletra(Numeros % 10); break;
                                    }
                                    break;

                                case 6:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Sesenta "; break;
                                        default:
                                            cadena = " Sesenta y " + Nletra(Numeros % 10); break;
                                    }
                                    break;

                                case 7:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Setenta "; break;
                                        default:
                                            cadena = " Setenta y " + Nletra(Numeros % 10); break;
                                    }
                                    break;

                                case 8:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Ochenta "; break;
                                        default:
                                            cadena = " Ochenta y " + Nletra(Numeros % 10); break;
                                    }
                                    break;
                                case 9:
                                    switch ((int)(Numeros % 10))
                                    {
                                        case 0: cadena = " Noventa "; break;
                                        default:
                                            cadena = " Noventa y " + Nletra(Numeros % 10); break;
                                    }
                                    break;

                            }
                        }
                        else
                        {
                            switch ((int)(Numeros))
                            {
                                case 0: cadena = "Cero"; break;
                                case 1: cadena = "Uno"; break;
                                case 2: cadena = "Dos"; break;
                                case 3: cadena = "Tres"; break;
                                case 4: cadena = "Cuatro"; break;
                                case 5: cadena = "Cinco"; break;
                                case 6: cadena = "Seis"; break;
                                case 7: cadena = "Siete"; break;
                                case 8: cadena = "Ocho"; break;
                                case 9: cadena = "Nueve"; break;

                            }
                        }
                    }
                }
            }
        }
    }
    return cadena;
}
}
