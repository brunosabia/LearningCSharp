using System;
using _72_LINQ_Similar_SQL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _72_LINQ_Similar_SQL
{
    class Program
    {
        //CONTEUDO DESTA AULA POSSUI COMENTÁRIOS EM CAPS
        //O CONTEUDO DA AULA PASSADA QUE ERA USADO FOI COMENTADO
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
            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            //SINTAXE ALTERNATIVA SIMILAR AO SQL
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("Tier 1 and price < 900:", r1);







            //neste caso vc consulta a lista e retorna os produtos com a categoria Tools , porém vc seleciona apenas o nome do produto para ser retornado
            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);

            //SINTAXE ALTERNATIVA
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Names of products from tools:", r2);





            //Neste caso é realizada novamente a consulta porém na hora dos valores que serao selecionados do produto, vc atribui para um novo obj. e atribui somente esses dados a r3
            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });

            //SINTAXE ALTERNATIVA
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("Names started with 'C' and anonymous object", r3);





            //Agora vc seleciona todos os products com tier 1 e ordena os mesmos por preço e se tiverem o mesmo preço, ordena por nome.
            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            //SINTAXE ALTERNATIVA - a ordem dos Order by neste caso são inversas, para obter o mesmo resultado
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;

            Print("Tier 1 ordered by Price then by Name", r4);




            //Skip vai pular os 2 primeiros no caso e apenas atribuir a r5 os proximos 4
            //var r5 = r4.Skip(2).Take(4);
            //SINTAXE ALTERNATIVA - é possivel fazer a expressao padrão sql entre parenteses e depois selecionar utilizando as funcoes do LINQ
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("Tier 1 ordered by Price then by Name BUT skip 2 and take 4", r5);


            //Pegar o primeiro obj da products
            //var r6 = products.First();
            //SINTAXE ALTERNATIVA
            var r6 = (from p in products select p).First();
            Console.WriteLine("First test1: " + r6);



            //Neste caso nao tem nenhum produto com mais de 3000 - entao se tentar rodar apenas com a Func First, vai dar erro. Use First or Default OU trate a exceção
            //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            //SINTAXE ALTERNATIVA
            var r7 =
                (from p in products
                 where p.Price > 3000.0
                 select p).FirstOrDefault();
            Console.WriteLine("First test2: " + r7);


            //Agrupando os produtos pela categoria
            //var r16 = products.GroupBy(p => p.Category);
            //o foreach desse agrupamento é diferente pois o r16 se torna um IGrouping<Chave, Valor>
            //para cada categoria imprimir o nome dela  (key == Category)
            //o segundo foreach vai imprimir cada produto de cada grupo de categoria
            
            //SINTAXE ALTERNATIVA
            var r16 =
                from p in products
                group p by p.Category;


            foreach (IGrouping<Category, Product> group in r16)
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