using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Práctica_10
{
    class Práctica_10_2
    {
        //Andrés Lemus 23/10/2019
        public static string[] paises = new string[15];
        static void Main(string[] args)
        {
             try
            {
                
                int op = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("ALMACENADOR DE NOMBRES DE PAÍSES");
                    Console.WriteLine();
                    Console.WriteLine("1- Agregar país");
                    Console.WriteLine("2- Mostrar países");
                    Console.WriteLine("3- Buscar país");
                    Console.WriteLine("4- Salir");
                    
                    if (int.TryParse(Console.ReadLine(), out op) && op > 0 && op <= 4)
                    {
                        Console.Clear();
                        switch (op)
                        {
                            case 1:
                                agregar();
                                break;
                            case 2:
                                mostrar();
                                break;
                            case 3:
                                buscar();
                                break;
                            case 4:
                                salir();
                                break;
                            default:
                                break;
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Tiene que ser un número entero entre 1 y 4 :c");
                        Console.ReadKey();
                    }
                } while (op != 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void agregar()
        {
            StreamWriter archivo = new StreamWriter(@"paises.txt", false);
            Console.WriteLine("Cantidad de países a ingresar");
            int p = Convert.ToInt32(Console.ReadLine());
            paises = new string[p];
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine("Ingrese el nombre del país #" + (i + 1));
                paises[i] = Console.ReadLine();
            }
            string texto = string.Join(",", paises);
            archivo.WriteLine(texto);
            archivo.Close();
            Console.WriteLine("¡Países ingresados con éxito!");
        }

        public static void mostrar()
        {
            StreamReader archivoL = new StreamReader(@"paises.txt");
            string[] paises = new string[15];
            string texto = archivoL.ReadToEnd();
            paises = texto.Split(',');
            Console.WriteLine("LISTADO DE PAISES");
            Console.WriteLine();
            archivoL.Close();
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }

        }

        public static void buscar()
        {
            StreamReader archivoL = new StreamReader(@"paises.txt");
            Console.WriteLine("Nombre del país que desea buscar");
            string paisB = Console.ReadLine();
            string[] paises = new string[15];
            string texto = archivoL.ReadToEnd();
            paises = texto.Split(',');
            Console.WriteLine("LISTADO DE PAISES");
            Console.WriteLine();
            archivoL.Close();
            foreach (string pais in paises)
            {
                if (pais == paisB)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(pais);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(pais);

                }
            }
        }

        public static void salir()
        {
            Console.WriteLine("Nos vemos o/");
        }
    }
}
