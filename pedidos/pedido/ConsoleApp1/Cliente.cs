using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string email;
        public Endereco endereco;

        public void exibeInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine($"Endereço: {endereco.rua} {endereco.numero} {endereco.complemento}");
            Console.WriteLine($"Complemento: {endereco.complemento}");
        }
    }
}
