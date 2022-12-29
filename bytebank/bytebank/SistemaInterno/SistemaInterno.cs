using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Funcionarios;

namespace bytebank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Login (Diretor nome, string senha)
        {
            bool usuarioAutenticado = Funcionario.Autenticar(senha);

        }
    }
}
