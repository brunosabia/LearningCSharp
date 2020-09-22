using System;
using System.Linq;

namespace _69_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especificar a fonte de dados:
            int[] numbers = new int[] { 2, 3, 4, 5 };


            //Definir a expressão de consulta:
            //(no caso ali, ela recebe x e retorna somenta os numeros pares)
            //( e na função select ele recebe x e retorna x * 10)
            //é usado 'var' pq o resultado das funcoes do Linq retornam um IEnumerable, que é uma coleção mais genérica. Por isso nao pode ser usada uma List
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //executar a consulta:
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
