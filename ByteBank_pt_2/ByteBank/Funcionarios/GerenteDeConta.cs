﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string Nome, string CPF) : base(4000, Nome,CPF) { }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }

        public override void ObterAumentoSalario()
        {
             Salario *= 0.5;
        }

    }
}