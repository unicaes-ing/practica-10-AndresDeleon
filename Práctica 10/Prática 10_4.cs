using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Práctica_10
{
    class Prática_10_4
    {
        //Andrés Lemus 23/10/2019
        static void Main(string[] args)
        {
            StreamReader archivo = new StreamReader(@"contraseña.txt");
            string contraseña = archivo.ReadLine();
            string contra = "";
            int cont = 3;
            do
            {
                Console.Clear();
                Console.WriteLine("Alma errante, por favor ingrese su contraseña :)");
                Console.WriteLine("INTENTOS RESTANTES: "+ cont);
                contra = Console.ReadLine();
                contra = contra.Replace("a", "1*#");
                contra = contra.Replace("e", "m2odn");
                contra = contra.Replace("i", "a4w21s");
                contra = contra.Replace("o", "241q#");
                contra = contra.Replace("u", "%&//(as2");
                //Console.WriteLine(contraseña);
                //Console.WriteLine(contra);
                cont--;
            } while (contra != contraseña && cont > 0);
            Console.Clear();
            archivo.Close();
            if (cont == 0)
            {
                Console.WriteLine("Lo siento, pero superó el límite de ingreso de contraseña, por lo tanto su alma será nuestra ;)");
            }
            else
            {
                Console.WriteLine("Bienvenid@ Alma Errante, su alma esta a salvo");
            }
            Console.ReadKey();
        }

    }
}
