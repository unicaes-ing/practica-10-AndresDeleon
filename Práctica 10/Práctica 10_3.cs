using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Práctica_10
{
    class Práctica_10_3
    {
        //Andrés Lemus 23/10/2019
        static void Main(string[] args)
        {
            try
            {
                StreamWriter archivo = new StreamWriter(@"contraseña.txt", false);
                string contraseña;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese la contraseña deseada");
                    contraseña = Console.ReadLine();
                } while (contraseña.Length < 7 && contraseña.Length > 20);
                contraseña = contraseña.Replace("a", "1*#");
                contraseña = contraseña.Replace("e", "m2odn");
                contraseña = contraseña.Replace("i", "a4w21s");
                contraseña = contraseña.Replace("o", "241q#");
                contraseña = contraseña.Replace("u", "%&//(as2");
                //Console.WriteLine(contraseña);
                archivo.WriteLine(contraseña);
                archivo.Close();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
