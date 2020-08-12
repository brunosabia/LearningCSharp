using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {

                //FileInfo
                //instancia um FileInfo informando o caminho do arquivo
                FileInfo fileInfo = new FileInfo(sourcePath);
                //Copia o conteudo dessa instancia para o caminho destino
                fileInfo.CopyTo(targetPath);
                

                //File

                //sem criar nenhuma instancia, ele apenas lê o conteudo do arquivo
                string[] lines = File.ReadAllLines(sourcePath);
                //e imprime
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
