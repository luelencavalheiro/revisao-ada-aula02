using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_02_revisao_ada
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade = this.quantidade + quantidade;

        }
         public void RemoverProdutos(int quantidade)
        {
            this.quantidade = this.quantidade - quantidade;
        }

    }
}
