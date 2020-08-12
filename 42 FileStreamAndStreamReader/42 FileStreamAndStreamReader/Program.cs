using System;
using System.IO;

namespace _42_FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //cria um FileStream onde abre o arquivo passado
                fs = new FileStream(path, FileMode.Open);
                //traz o arquivo passado como uma stream
                sr = new StreamReader(fs);

                //enquanto nao chegar no fim da stream, continuar lendo e imprimindo as linhas
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("an error occurred");
                Console.WriteLine(e.Message);
            }

            //como fechar os FileStream e StreamReader de forma MANUAL, pois são externos ao ".Net"
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
