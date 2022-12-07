﻿using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        public int Numero_Agencia { get; set; }
        public string Conta { get; set; }
        public Cliente Titular { get; set; }
        public Cliente Renda { get; set; }
        public double Saldo { get; set;}
        public static int TotalDeContasCriadas { get; private set; }

        //métodos
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
                saldo = saldo - valor;
                contaDestino.Saldo = contaDestino.saldo + valor;
                return true;
            }
        }
    }
}
