using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pedido
    {
        public int numeroPedido;
        public Cliente cliente;
        public ItemPedido item;
        public float valorTotal;

        public void exibeInformacoes()
        {
            Console.WriteLine($"Número do pedido: {numeroPedido}");
            Console.WriteLine($"Cliente: {cliente.nome}");
            Console.WriteLine($"E-mail: {cliente.email}");
            Console.WriteLine($"Endereço: {cliente.endereco.rua} {cliente.endereco.numero} {cliente.endereco.complemento}");
            Console.WriteLine($"Complemento: {cliente.endereco.complemento}");
            Console.WriteLine($"Item: {item.produto1}");
            Console.WriteLine($"Item: {item.produto2}");
            Console.WriteLine($"Item: {item.produto3}");
            Console.WriteLine($"Quantidade: {item.quantidade}");
            Console.WriteLine($"Valor total: {valorTotal}");
        }
    }
}
