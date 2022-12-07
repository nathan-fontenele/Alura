using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pedido
    {
        public int numero_pedido;
        public Cliente cliente;
        public ItemPedido item;
        public float valor_pedido;

        public void ExibePedido()
        {
            Console.WriteLine($"Cliente: {cliente.nome}");
            Console.WriteLine($"E-mail: {cliente.email}");
            Console.WriteLine($"Endereço: {cliente.endereco.rua}, {cliente.endereco.numero}");
            Console.WriteLine($"{cliente.endereco.cidade}, {cliente.endereco.bairro}\n");
            Console.WriteLine($"Itens pedidos:\n");
            Console.WriteLine($"{item.produto1.descricao} qtde: {item.produto1.quantidade}");
            Console.WriteLine($"Valor unitário: {item.produto1.valor_unitario}\n");
            Console.WriteLine($"{item.produto2.descricao} qtde: {item.produto2.quantidade}");
            Console.WriteLine($"Valor unitário: {item.produto2.valor_unitario}\n");
            Console.WriteLine($"Subtotal: R${item.produto1.valor_unitario * item.produto1.quantidade + item.produto2.valor_unitario * item.produto2.quantidade}");
        }
    }
}
