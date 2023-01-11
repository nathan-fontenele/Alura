using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using bytebank.Contas;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        //atributos
        private int numero_agencia;
        private string conta;
        private Cliente titular; //recebe a referência de Cliente
        private Cliente renda;
        private double saldo = 100; //define o valor padrão do atributo

        //propriedades
        public int Numero_Agencia 
        {
            get { return this.numero_agencia; }
            set
            {
                if(value > 2)
                {
                    this.numero_agencia = value;
                }
            }
        }
        public string Conta { get; set; }
        public Cliente Titular{ get; set; }
        public Cliente Renda { get; set; }
        public double Saldo { get; set;}
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; set; }

        //métodos
        public ContaCorrente(int agencia, string conta)
        {
            this.Numero_Agencia = agencia;
            this.Conta = conta;
            TaxaOperacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas++;
        }


        public void Sacar(int valor)
        {
            this.Saldo -= valor;
        }
        public void Depositar(int valor)
        {
            this.Saldo += valor;
        }
        public bool Transferir(int valor, ContaCorrente contaDestino)
        {
           if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                contaDestino.Saldo = contaDestino.saldo + valor;
                return true;
            }
        }

        public void ExibeInformacoe()
        {
            Console.WriteLine($"Titular: {Titular.Nome}");
            Console.WriteLine($"Conta: {Conta}");
            Console.WriteLine($"Agência: {Numero_Agencia}");
            Console.WriteLine($"Telefone: {Titular.Telefone}");
            Console.WriteLine($"Saldo: R${Saldo}");
            Console.WriteLine($"Renda: R${Titular.Renda}\n");
        }
    }
}
