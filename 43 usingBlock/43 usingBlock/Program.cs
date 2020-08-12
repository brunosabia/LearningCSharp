using System;
using System.IO;

namespace _43_usingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";


            try
            {
                //o bloco using fecha automaticamente as instancias quando o bloco dele é terminado.
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
