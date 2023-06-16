using System;
using System.Globalization;
namespace EstoqueTV
{
    class ProdutoTV
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F4", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, total: $ " + ValorTotalEmEstoque().ToString("F4", CultureInfo.InvariantCulture);

        }
    }
}
