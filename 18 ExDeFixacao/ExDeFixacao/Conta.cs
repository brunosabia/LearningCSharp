using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Globalization;

namespace ExDeFixacao
{
    class Conta
    {
        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }


        public string Nome {

            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
            
        }
        public Conta(int numero, string nome)
        {
            Numero = numero;
            _nome = nome;
            Saldo = 0.00;
        }

        public void Deposito (double valorDep)
        {
            Saldo += valorDep;
            
        }

        public void Saque( double valorSaque)
        {
            Saldo -= valorSaque;
            Saldo -= 5;
            
        }
        public void depInicial(string decisao)
        {
            if(decisao == "s")
            {
                Console.WriteLine("Entre um valor de depósito inicial: ");
                double dep = double.Parse(Console.ReadLine());
                Deposito(dep);
            }

        }

        public override string ToString()
        {
            return "Dados da conta: \n"
                + "Conta " + Numero + ", "
                + "Titular: " + _nome + ", "
                + "Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);               
        }
    }
}
