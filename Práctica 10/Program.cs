using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Práctica_10
{
    class Program
    {
        //Andrés Lemus 23/10/2019
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
            StreamWriter archivo = new StreamWriter(@"paises.txt", true);
            Console.WriteLine("Ingrese el nombre del país");
            string pais = Console.ReadLine();
            archivo.WriteLine(pais);
            archivo.Close();
            Console.WriteLine("¡País ingresado con éxito!");
        }

        public static void mostrar()
        {
            StreamReader archivoL = new StreamReader(@"paises.txt");
            Console.WriteLine("LISTADO DE PAISES");
            Console.WriteLine();
            string texto;
            texto = archivoL.ReadToEnd();
            Console.WriteLine(texto);
            archivoL.Close();
           
        }

        public static void buscar()
        {
            StreamReader archivoL = new StreamReader(@"paises.txt");
            Console.WriteLine("Nombre del país que desea buscar");
            string paisB = Console.ReadLine();
            Console.WriteLine("============================================");
            Console.WriteLine("PAISES");
            Console.WriteLine();
            string linea;
            do
            {
                linea = archivoL.ReadLine();
                if (linea == paisB)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(linea);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(linea);

                }
                
            } while (linea != null);
            archivoL.Close();
        }

        public static void salir()
        {
            Console.WriteLine("Nos vemos o/");
        }
    }
}
