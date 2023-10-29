using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__PROJETO_4_GESTOR_DE_ESTOQUE_NO_CMD
{
    [System.Serializable]

        class ProdutoFisico : Produto, IEstoque
        {
            public float frete;
            private int estoque;

            public ProdutoFisico (string nome, float preco, float frete)
   
            {
                this.nome = nome;
                this.preco = preco;
                this.frete = frete;
                
            }

            public void AdicionarEntrada()
            {
                Console.WriteLine($"Adicionar entrada no estoque do produto {nome}.");
                Console.WriteLine("Digite a Qtd. que você quer dar entrada: ");
                int entrada = int.Parse( Console.ReadLine() );
                estoque += entrada;
                Console.WriteLine("Entrada registrada");
                Console.ReadLine();
                

            }

            public void AdicionarSaída()
            {
                Console.WriteLine($"Adicionar Saída no estoque do produto {nome}.");
                Console.WriteLine("Digite a Qtd. que você quer dar baixa: ");
                int entrada = int.Parse( Console.ReadLine() );
                estoque -= entrada;
                Console.WriteLine("Saída registrada");
                Console.ReadLine(); 
            }

            public void Exibir()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Frete: {frete}");
                Console.WriteLine($"Preço: {preco}");
                Console.WriteLine($"Estoque: {estoque}");

                Console.WriteLine("===================");
            }
        }
    
}
