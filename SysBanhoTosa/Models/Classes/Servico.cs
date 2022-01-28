using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Servico
    {
        private int id;
        private string nome;
        private string descricao;
        private float valor;
        private string situacao;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }
        public float Valor { 
            get => valor; 
            set => valor = value; 
        }
        public string Situacao
        {
            get => situacao;
            set => situacao = value;
        }
    }
}
