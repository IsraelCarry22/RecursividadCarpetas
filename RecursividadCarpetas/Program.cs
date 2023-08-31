using System;
using System.IO;

namespace RecursividadCarpetas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe la ruta de la carpeta: ");
            string RutaCarpeta = Console.ReadLine();
            if (!Directory.Exists(RutaCarpeta))
            {
                Console.WriteLine("No existe la ruta :(");
                Console.WriteLine("Pulse cualquier tecla para salir...");
            }
            ListaRecursividadCarpetas(RutaCarpeta);
            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadKey();
        }

        public static void ListaRecursividadCarpetas(string RutaCarpeta)
        {
            DirectoryInfo directory = new DirectoryInfo(RutaCarpeta);
            foreach (FileInfo Archivo in directory.GetFiles())
            {
                string nombre = Archivo.Name;
                string extension = Archivo.Extension;
                Console.WriteLine($"Nombre: {nombre} || extension: {extension}.");
            }
            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                ListaRecursividadCarpetas(subdirectory.FullName);
            }
        }
    }
}