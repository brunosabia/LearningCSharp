using System;

namespace MatrizSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar uma matriz chamada matriz com 2 linhas e 3 colunas.
            double[,] matriz = new double[2, 3];
            //Quantidade de elementos no total:
            Console.WriteLine(matriz.Length);
            //Quantidade de linhas:
            Console.WriteLine(matriz.Rank);

            //Quantidade de linhas tambem:
            Console.WriteLine(matriz.GetLength(0));

            //Quantidade de COLUNAS:
            Console.WriteLine(matriz.GetLength(1));


        }
    }
}
