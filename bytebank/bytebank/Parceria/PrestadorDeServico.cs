using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Parceria
{
    public abstract class PrestadorDeServico : IBonificacao
    {
        public string CNPJ { get; set; }

        public double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
