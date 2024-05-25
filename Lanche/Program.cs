using System;
using System.Globalization;

namespace Lanche
{
    class program
    {

        static Produto GetProdutoById(int id){
            foreach (Produto pd in produtos){
                if (pd.Codigo == id){
                    return pd;
                }
            }
                return null;
        }
        static Produto[] produtos = new Produto[5];

        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');

            int item = int.Parse(vetor[0]);
            int quantidade = int.Parse(vetor[1]);

            produtos[0] = new Produto(1, "Cachorro-Quente", 4.0F );

            produtos[1] = new Produto(2, "X-Salada", 4.50F);

            produtos[2] = new Produto(3, "X-Bacon", 5.0F);

            produtos[3] = new Produto(4, "Torrada Simples", 2.0F);

            produtos[4] = new Produto(5, "Refrigerante", 1.5F);

            Produto produtoSelecionado = GetProdutoById(item);

            System.Console.WriteLine("Total: R$ "+ (produtoSelecionado.Valor * quantidade).ToString("F2"));
        }
    }

    class Produto
    {
        public Produto(int codigo, string nome, float valor){
            this.Nome = nome; //objeto é igual ao argumento da função
            this.Codigo = codigo;
            this.Valor = valor;
        }
        public string Nome;
        public int Codigo;
        public float Valor;

    }

}