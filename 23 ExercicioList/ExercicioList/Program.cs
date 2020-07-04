using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> func = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                func.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

               
            }
            Console.Write("Insira o ID do funcionário que receberá um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario funci = func.Find(x => x.Id == idAumento);
            if(funci != null)
            {
                Console.Write("Entre a porcentagem do aumento: ");
                funci.aumentoSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("ID não foi encontrado!");
            }

            Console.WriteLine();

            Console.WriteLine("Lista de funcionários atualizada:" );

            foreach (Funcionario obj in func)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
