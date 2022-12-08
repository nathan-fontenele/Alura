using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        //atributos
        private string nome;
        private string cpf;
        private string profissao;
        private string telefone;
        private int renda;

        //propriedades
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public string Telefone 
        {
            get { return telefone; }
            set
            {
                if (value.Length == 14) 
                {
                    telefone = value;
                }
                else
                {
                    Console.WriteLine($"Tamanho inválido");
                }
            }
        }
        public int Renda { get; set;}
    }
}
