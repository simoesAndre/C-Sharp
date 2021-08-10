namespace Atividade01
{
    public class ItemPedido
    {
        //Propriedades
        private string descricao;
        private double valorUnitario;
        private double quantidade;

        //Métodos

        //GET
       public string getDescricao()
       {
           return descricao;
       }
       public double getValorUnitario()
       {
           return valorUnitario;
       }
       public double getQuantidade()
       {
           return quantidade;
       }


       //SET
       public void setDescricao(string descricao)
       {
           this.descricao = descricao;
       }
       public void setValorUnitario(double valorUnitario)
       {
           this.valorUnitario = valorUnitario;
       }
       public void setQuantidade(double quantidade)
       {
           this.quantidade = quantidade;
       }
    }
}