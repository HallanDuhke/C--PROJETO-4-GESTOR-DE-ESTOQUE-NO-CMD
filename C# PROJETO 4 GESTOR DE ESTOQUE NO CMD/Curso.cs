using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__PROJETO_4_GESTOR_DE_ESTOQUE_NO_CMD
{
    [System.Serializable]

    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;


        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Consumir vagas no curso {nome}.");
            Console.WriteLine("Digite a Qtd. de vagas que você quer consumir: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();


        }

        public void AdicionarSaída()
        {
            Console.WriteLine($"Adicionar Saída no estoque do produto {nome}.");
            Console.WriteLine("Digite a Qtd. que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();


        }


        public void Exibir()
       {
          Console.WriteLine($"Nome: {nome}");
          Console.WriteLine($"Autor: {autor}");
          Console.WriteLine($"Preço: {preco}");
          Console.WriteLine($"Vagas restantes: {vagas}");

          Console.WriteLine("===================");
        }
        

        
    }
}
