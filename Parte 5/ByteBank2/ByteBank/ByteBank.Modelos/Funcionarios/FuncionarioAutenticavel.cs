﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper AutenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return AutenticacaoHelper.CompararSenhas(Senha,senha);
        }
    }
}
