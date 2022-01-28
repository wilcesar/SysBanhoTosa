using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Lancamento
    {
        private int id;
        private Cliente cliente;
        private Pet pet;
        private Servico servico;
        private float valor;
        private DateTime dataHora;
        private string situacao;
        private string observacao;

        public int Id { get => id; set => id = value; }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        public Pet Pet { get => pet; set => pet = value; }

        public Servico Servico { get => servico; set => servico = value; }

        public float Valor { get => valor; set => valor = value ; }

        public DateTime DataHora { get => dataHora; set => dataHora = value; }
        
        public string Situacao { get => situacao; set =>situacao = value; }

        public string Observacao { get => observacao; set => observacao = value; }

    }
}
