using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_agencia;
        private string conta;
        public string Conta { get; set; }
        private Cliente titular; //recebe a referência de Cliente
        public Cliente Titular { get; set; }
        public double saldo = 100; //define o valor padrão do atributo

        public int Numero_agencia
        {
            get
            {
                return numero_agencia;
            }
            set
            {
                if(this.numero_agencia > 3)
                {
                    this.numero_agencia = value;
                }
                else
                {
                    return;
                }
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor); //this.saldo -= valor;
                destino.Depositar(valor); //destino.saldo += valor;
                Console.WriteLine("Saldo após a transferencia:");
                Console.WriteLine($"Saldo do André: {saldo}");
                Console.WriteLine($"Saldo do Maria: {destino.saldo}");
                return true;
            }
        }
        public void ExibeInformacoes()
        {
            Console.WriteLine($"Titular da conta: {Titular.Nome}");
            Console.WriteLine($"Profissão: {Titular.Profissao}");
            Console.WriteLine($"CPF: {Titular.Cpf}");
            Console.WriteLine($"Número da agência: {numero_agencia}");
            Console.WriteLine($"Número da conta {conta}");
            Console.WriteLine($"Saldo da conta: {saldo}\n");
        }
    }
}
