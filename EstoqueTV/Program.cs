using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstoqueTV
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoTV p = new ProdutoTV();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            //assima é a parte da leitura de um produto.

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados ao estoque da loja: ");
            int Qtidades = int.Parse(Console.ReadLine()); //linha para add a quantidade do produto
            p.AdicionarProdutos(Qtidades);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            Qtidades = int.Parse(Console.ReadLine());
            p.RemoverProdutos(Qtidades);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadKey();
        }
    }
}
