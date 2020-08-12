using System;
using System.IO;

namespace _44_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {   //guarda o conteudo das linhas do arquivo no vetor 
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }



            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
