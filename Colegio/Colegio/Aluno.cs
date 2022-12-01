using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    public class Aluno
    {
        private int matricula;
        public int Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Valor inválido, deve ser maior que 0");
                }
                else
                {
                    matricula = value;
                }
            }
        }
        private string nome;
        private string email;
        private string status;
        private string tipoCurso;
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
}
