using System;
using System.Collections.Generic;
using System.Text;

namespace Teste3
{
    class Funcionario
    {
        public string nome, endereco;
        public int idade, numero;
        public Funcionario()
        {
            Console.Write("nome do funcionario: ");
            nome = Console.ReadLine();
            Console.Write("idade do funcionario: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("endereco do funcionario: ");
            endereco = Console.ReadLine();
            Console.Write("numero da casa: ");
            numero = int.Parse(Console.ReadLine());
        }

        public int anoQueVem()
        {
            int idade2 = idade + 1;
            return idade2;
        }
        public int anoNascimento()
        {
            int nascimento = 2020 - idade;
            return nascimento;
        }
        public void imprimirFunc()
        {
            Console.WriteLine("Nome cadastrado: {0}",nome);
            Console.WriteLine("Idade cadastrada: {0}", idade);
            Console.WriteLine("Endereço cadastrado: {0} , {1}", endereco,numero);
        }
    }
}
