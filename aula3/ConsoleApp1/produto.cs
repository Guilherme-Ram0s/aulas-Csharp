using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Produto
    {
        public string Nome;
        public int QtdEstoque;
        public double Preco;

        public Produto(string nome, int qtdEstoque, double preco)
        {
            Nome = nome;
            QtdEstoque = qtdEstoque;
            Preco = preco;
        }

        public double getTotalAmount()
        { 
            return Preco * QtdEstoque;
        }
        public string getDetailProduct()
        {
            return $"Nome: {Nome} \npreço: {Preco} \nquantidade: {QtdEstoque}";
        }

    }
}
