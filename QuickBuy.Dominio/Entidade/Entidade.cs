﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidade
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());  }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
