using UPeDowncasting.Entities;
using System;

namespace UPeDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount busacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


            //UPCASTING
            //Atribuir um objeto de uma subclasse a uma superclasse

            Account acc1 = busacc;


            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);


            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);




            //DOWNCASTING
            //Atribuir um objeto de uma superclasse a uma subclasse
            //é preciso fazer a conversão para o compilador aceitar

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //A operação abaixo nao funciona. Ao atribuir a BusinessAccount para Account na linha 21, vc perde a opção de utilizar os metodos da BusinessAccount. Que se tornam  acessiveis novamente
            //quando o downcasting é feito novamente.
            //acc2.Loan(100.0);






            //No caso abaixo, acc3 é um SavingsAccount, e nao pode ser atribuido a um objeto de Business account. 
            //Isso iria causar um erro na hora da execução:

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            
            //pois esta tentando atribuir um obj SavingsAccount a um obj BusinessAccount.
            //Para garantir que um Downcasting sera feito apenas caso o objeto seja do tipo desejado, é usado o exemplo abaixo:

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }

            //este IF serve de verificação para que a atribuição seja valida (no caso não é) 


            //Agora este IF sera verdadeiro e o DOWNCASTING será executado
            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                //Sintaxe ALTERNATIVA PRA LINHA ACIMA:
                SavingsAccount acc5 =  acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}