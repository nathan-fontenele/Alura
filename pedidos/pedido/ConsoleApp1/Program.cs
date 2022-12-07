using ConsoleApp1;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente();
        cliente1.nome = "André Silveira";
        cliente1.cpf = "123.456.789-12";
        cliente1.email = "andre.silveira@gmail.com";
        
        cliente1.endereco = new Endereco(); //evita referência nula
        cliente1.endereco.rua = "Rua dos Andradas";
        cliente1.endereco.cidade = "Rio de Janeiro";
        cliente1.endereco.bairro = "Centro";
        cliente1.endereco.numero = 123;
        cliente1.endereco.cep = "23412-943";

        Pedido pedido1 = new Pedido();
        pedido1.cliente = cliente1;
        pedido1.item = new ItemPedido();
        pedido1.numero_pedido = 001;
        pedido1.item.numero_pedido = 001;
        pedido1.item.quantidade = 3;
        pedido1.item.produto1 = new Produto();
        pedido1.item.produto1.numero_produto = 1;
        pedido1.item.produto1.descricao = "Hamburguer";
        pedido1.item.produto1.quantidade = 2;
        pedido1.item.produto1.valor_unitario = 15;
        pedido1.item.produto2= new Produto();
        pedido1.item.produto2.numero_produto = 2;
        pedido1.item.produto2.descricao = "Suco";
        pedido1.item.produto2.quantidade = 2;
        pedido1.item.produto2.valor_unitario = 10;

        pedido1.ExibePedido();

    }
}