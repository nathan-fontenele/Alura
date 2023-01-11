using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Funcionarios;
using bytebank.Parceria;

namespace bytebank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Login (IAutenticar nome, string senha, string login)
        {
            bool usuarioAutenticado = nome.Autenticacao(login, senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema bytebank");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário incorreto");
                return false;
            }
        }

        public bool Login(ParceiroComercial nome, string senha, string login)
        {
            bool usuarioAutenticado = nome.Autenticacao(login, senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema bytebank");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário incorreto");
                return false;
            }
        }

    }
}
