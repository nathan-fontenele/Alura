﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
        public Auxiliar(string cpf) : base(cpf, 2000) 
        {
        }
        public override double aumentarSalario()
        {
            return Salario *= 1.1;
        }
    }
}
