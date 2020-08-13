using System;
using System.IO;
using System.Collections.Generic;

namespace _45_DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder";

            try
            {   
                //LISTAR AS PASTAS
                //ao usar o Directory.EnumerateDirectories ele retorna uma lista do tipo IEnumerable, entao 
                //é criado um IEnumerable para receber a lista de folders e tambem pode ser usado o "var", por exemplo:
                // var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //*.* significa com qualquer nome e com qualquer extensão
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //LISTAR OS ARQUIVOS
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //CRIAR UMA PASTA
                Directory.CreateDirectory(path + "\\newfolder");


            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
