using System;
using System.IO;

namespace _38_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            finally
            {
                //fechar arquivos e conexões com banco
            }



            //exemplo melhor do uso do finally:

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Users\bruno\OneDrive\Área de Trabalho\ideias de nomes.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }

        }
    }
}
