using System;

//Programa C# que inclui itens de um pedido (com informações de nome, valor e quantidade) e no fim, 
//se o usuário não querer incluir mais itens, o programa finaliza informando o valor total do pedido.

namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido lista = new Pedido();
            string resposta;

            do
            {
                Console.WriteLine("Cadastro de pedidos");
                ItemPedido item = new ItemPedido();
                Console.WriteLine("Informe o nome do item:");
                item.setDescricao(Console.ReadLine());
                Console.WriteLine("Informe o valor do item: (Ex.: 10,00)");
                item.setValorUnitario(double.Parse(Console.ReadLine()));
                Console.WriteLine("Informe a quantidade do item:");
                item.setQuantidade(double.Parse(Console.ReadLine()));
                lista.incluir(item);
                Console.WriteLine("Deseja adicionar outro pedido? (s/n)");
                resposta=Console.ReadLine();
            } while (resposta!="n");
                lista.listar();
                Environment.Exit(0); 
        }
    }
}
