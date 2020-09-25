using System;

namespace _71_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operações Basicas da álgebra Relacional:
            /*
            -Restrição
            -Projeção
            -Produto cartesiano
            -Junção

             //CHAVE ESTRANGEIRA É QUANDO UM DADO QUE É PARTE DE UMA TABELA É USADO COMO CHAVE PARA ASSIMILAR COM OUTRA TABELA
             //POR EXEMPLO, O CATEGORY ID DE UM PRODUTO É A CHAVE ESTRANGEIRA QUE VAI SER USADA COMO DESIGNADOR DE QUAL CATEGORIA O PRODUTO CONDIZ NA TABELA 'CATEGORY'


             JUNÇÃO E PRODUTO CARTESIANO:
             ------------------------------
                 SELECT *     (ESTE COMANDO BUSCA TODOS OS DADOS)
                 FROM PRODUCT, CATEGORY           (QUANDO A PALAVRA FROM É USADA, É CRIADO UM 'PRODUTO CARTESIANO' QUE É A JUNÇÃO DE CADA PRODUTO COM TODAS AS CATEGORIAS SEM NENHUM CRITÉRIO)


             ------------------------------(AGORA O PRODUTO CARTESIANO SÓ VAI SELECIONAR OS PRODUTOS E JUNTAR ELAS COM SUAS DEVIDAS CATEGORIAS) JUNÇÃO! e o WHERE é uma clausula de RESTRIÇÃO!
                 SELECT *
                 FROM PRODUCT, CATEGORY
                 WHERE
                 PRODUCT.CATEGORY_ID = CATEGORY.ID

             ------------------------------(os comandos acima podem ser feitos assim tambem):
                 SELECT *
                 FROM PRODUCT
                 INNER JOIN CATEGORY cat
                 ON PRODUCT.CATEGORY_ID = cat.ID





            RESTRIÇÃO:
            -------------------------------(IMAGINE QE VC QUER PEGAR O RESULTADO DESSA TABELA E RESTRINGIR MAIS AINDA)
                 SELECT *
                 FROM PRODUCT
                 INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID
                 WHERE CATEGORY.NAME = 'Computers'



            PROJEÇÃO:
            -------------------------------QUANDO VOCÊ NAO QUER POR EXEMPLO QUE RETORNE TODOS OS DADOS DO OBJETO, E SIM ALGUNS DADOS ESPECIFICOS, A MUDANCA ESTA NO SELECT - TODOS OS DADOS DE PRODUCT E SOMENTE O NOME DA CATEGORY
                 SELECT PRODUCT.*,CATEGORY.NAME
                 FROM PRODUCT
                 INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID
                 WHERE CATEGORY.NAME = 'Computers'


             */
        }
    }
}
