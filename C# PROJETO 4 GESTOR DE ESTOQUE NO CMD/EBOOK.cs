using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace C__PROJETO_4_GESTOR_DE_ESTOQUE_NO_CMD
{
    [System.Serializable]

    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;
    

      public Ebook(string nome,float preco, string autor)
      { 
       this.nome = nome;
       this.preco = preco;
       this.autor = autor;
     
      }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada no estoque de um EBOOK");
            Console.ReadLine();
        }

        public void AdicionarSaída()
        {
            Console.WriteLine($"Adicionar vendas no e-book {nome}.");
            Console.WriteLine("Digite a Qtd. de vendas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas += entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();

        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");

            Console.WriteLine("===================");
        }
    }

}
