using System;
using System.Collections.Generic;

namespace Atividade01
{
    public class Pedido
    {
       //Propriedade
       private List<ItemPedido> lista = new List<ItemPedido>();

       //Métodos
       public void incluir(ItemPedido item)
       {
           lista.Add(item);
       }

       public void listar()
       {
           double total = 0;
           for (int contador = 0; contador < lista.Count; contador++)
           {
               //Cálculo total dos preços
               total = total + lista[contador].getQuantidade()*lista[contador].getValorUnitario();
           }

           Console.WriteLine("O total é: " + total);
       }
    }
}