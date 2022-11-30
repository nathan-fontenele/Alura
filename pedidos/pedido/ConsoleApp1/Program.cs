using ConsoleApp1;

public class Program
{ 
      static void Main(string[] args)
      {
        Cliente cliente = new Cliente();
        Pedido pedido = new Pedido();
        ItemPedido item = new ItemPedido();
        cliente.endereco = new Endereco();

        //declaração cliente
        cliente.nome = "José Silva";
        cliente.cpf = "854.054.321-04";
        cliente.email = "jose.silva@email.com";

        //cliente com endereço
        cliente.endereco.rua = "Av. Presidente Vargas";
        cliente.endereco.cidade = "Rio de Janeiro";
        cliente.endereco.bairro = "Centro";
        cliente.endereco.numero = 254;

        //declaração pedido
        pedido.cliente = cliente;
        pedido.numeroPedido = 001;
        pedido.item = item;
        pedido.valorTotal = 30;

        //declaração item
        item.numeroPedido = 001;
        item.quantidade = 2;
        item.produto1 = "Hamburguer";
        item.produto2 = "Refrigerante";
        item.produto3 = "Batata";
        
        pedido.exibeInformacoes();

      } 
}