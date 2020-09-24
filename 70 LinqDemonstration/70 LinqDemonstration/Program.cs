using System;
using _70_LinqDemonstration.Entities;
using System.Collections.Generic;
using System.Linq;

namespace _70_LinqDemonstration
{
    class Program
    {   
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };

            Category c2 = new Category() { ID = 2, Name = "Computers", Tier = 1 };

            Category c3 = new Category() { ID = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(1,"Computer", 1100.0,c2),
                new Product(2,"Hammer",90.0,c1),
                new Product(3,"TV", 1700.0,c3),
                new Product(4,"Notebook",1300.0,c2),
                new Product(5,"Saw", 80.0,c1),
                new Product(6,"Tablet",700.0,c2),
                new Product(7,"Camera", 700.0,c3),
                new Product(8,"Printer",350.0,c3),
                new Product(9,"MacBook", 1800.0,c2),
                new Product(10,"Sound bar",700.0,c3),
                new Product(11,"Level", 70.0,c1)
            
            };

            //o linq faz a consulta da lista sozinho - recebe o produto p, realiza a comparação para ver se condizem, SE SIM, ele atribui para r1
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 and price < 900:", r1);

            //neste caso vc consulta a lista e retorna os produtos com a categoria Tools , porém vc seleciona apenas o nome do produto para ser retornado
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of products from tools:",r2);

            //Neste caso é realizada novamente a consulta porém na hora dos valores que serao selecionados do produto, vc atribui para um novo obj. e atribui somente esses dados a r3
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price ,CategoryName = p.Category.Name });
            Print("Names started with 'C' and anonymous object", r3);

            //Agora vc seleciona todos os products com tier 1 e ordena os mesmos por preço e se tiverem o mesmo preço, ordena por nome.
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 ordered by Price then by Name", r4);

            //Skip vai pular os 2 primeiros no caso e apenas atribuir a r5 os proximos 4
            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 ordered by Price then by Name BUT skip 2 and take 4", r5);


            //Pegar o primeiro obj da products
            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            //Neste caso nao tem nenhum produto com mais de 3000 - entao se tentar rodar apenas com a Func First, vai dar erro. Use First or Default OU trate a exceção
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First test2: " + r7);

            //retorna apenas um elemento ou se nao encontrar nenhum , tras o default(null) - vale lembrar que se o Where desse mais de um resultado, daria erro.
            var r8 = products.Where(p => p.ID == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            //teste com id inexistente
            var r9 = products.Where(p => p.ID == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            //Atribui apenas o maior preco dos produtos da lista
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: " + r10);

            //Atribui apenas o menor preco dos produtos da lista
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            //Soma dos precos dos produtos de categoria 1:
            var r12 = products.Where(p => p.Category.ID == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum Prices: " + r12);

            //Média dos precos dos produtos de categoria 1:
            var r13 = products.Where(p => p.Category.ID == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average Prices: " + r13);

            //Esquema para tornar mais segura uma operação CASO exista o risco dela retornar null e crashar
            //vc seleciona no caso uma categoria inexistente. logo o r14 ficaria vazio.
            //vc seleciona apenas o atributo desejado para a média com o Select.
            //Cria o DefaultIfEmpty para setar um valor default  e evitar um crash execução
            //E por fim executa o Average sem precisar passar nem argumentos pois o select já separou apenas os prices (Double)
            var r14 = products.Where(p => p.Category.ID == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average Prices: " + r14);


            //Criando uma operação PERSONALIZADA utilizando o aggregate
            //o select separa todos os produtos com ID 1 e Seleciona apenas os Preços deles.
            // E o Aggregate pega um preco e soma com o outro. resultando na Soma de todos 
            // Caso os valores passados a r15 sejam zero ou null daria um erro, entao é colocado um parametro em Aggregate como valor Default(0.0)
            var r15 = products.Where(p => p.Category.ID == 1).Select(p => p.Price).Aggregate(0.0,(x,y) => x + y);
            Console.WriteLine("Category 1 Aggregate SUM: "+ r15);

            Console.WriteLine();

            //Agrupando os produtos pela categoria
            var r16 = products.GroupBy(p => p.Category);
            //o foreach desse agrupamento é diferente pois o r16 se torna um IGrouping<Chave, Valor>
            //para cada categoria imprimir o nome dela  (key == Category)
            //o segundo foreach vai imprimir cada produto de cada grupo de categoria
            foreach (IGrouping<Category,Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");

                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }


        }
    }
}
