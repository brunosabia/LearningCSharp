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
            //é usado 'var' pq o resultado das funcoes do Linq retornam um IEnumerable, que é uma coleção mais genérica. Por isso nao pode ser usada uma List.
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //executar a consulta:
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }




            /* Lista de operações do Linq:

            Operações que filtram:
                -Where
                -OfType

            Operações que ordenam:
                -OrderBy
                -OrderByDescending
                -ThenBy
                -ThenByDescending
                -Reverse

            Operações de Set:
                -Distinct
                -Except
                -Intersect
                -Union

            Operações para quantificar:
                -All
                -Any
                -Contains

            Operações de Projeção:
                -Select
                -SelectMany

            Operações para Particionar (Muito usado para paginação.)
                -Skip (pule elementos)
                -Take (pegue x elementos)

            Operações para junção:
                -Join
                -GroupJoin

            Operação de Agrupamento:
                -GroupBy

            Operação de Gerar uma fonte de dados vazia
                -Empty

            Operação de Igualdade:
                -SequenceEquals

            Operações para obter elementos:
                -ElementAt
                -First
                -FirstOrDefault
                -Last
                -LastOrDefault
                -Single
                -SingleOrDefault

            Operações de Conversão:
                -AsEnumerable
                -AsQueryable

            Operação de Concatenação:
                -Concat

            Operações de Agregação:
                -Aggregate
                -Average
                -Count
                -LongCount
                -Max
                -Min
                -Sum

             
             
             
             */
        }
    }
}
