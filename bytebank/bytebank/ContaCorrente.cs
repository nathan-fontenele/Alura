using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public string titularCPF;
        public string titularProfissao;
        public double saldo = 100; //define o valor padrão do atributo

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor) 
            {
                return false;
            }
            else
            {
                this.Sacar(valor); //this.saldo -= valor;
                destino.Depositar(valor); //destino.saldo += valor;
                return true;
            }
        }

        public void ExibeInformacoes()
        {
            Console.WriteLine($"Titular da conta: {titular}");
            Console.WriteLine($"Número da agência: {numero_agencia}");
            Console.WriteLine($"Número da conta {conta}");
            Console.WriteLine($"Saldo da conta: {saldo}\n");
        }


    }


}
