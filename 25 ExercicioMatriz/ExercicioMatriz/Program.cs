using System;
using System.Threading;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());
            //criando a matriz do tamanho informado
            int[,] mat = new int[n, n];

            //loop para mudar as linhas
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                //loop para mudar as colunas
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);    
                }
            }
            //numeros da diagonal principal
            Console.WriteLine("Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
                
            }
            //percorrer a matriz e imprimir a quantidade de numeros negativos
            int negativos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    { negativos++; }
                }
            }
            Console.WriteLine("Negativos: " + negativos);


        }
    }
}
