using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Pet
    {
        private int id;
        private string nome;
        private string especie;
        private string raca;
        private Cliente tutor;
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
        public string Especie
        {
            get => especie;
            set => especie = value;
        }
        public string Raca
        {
            get => raca;
            set => raca = value;
        }
        public Cliente Tutor
        {
            get => tutor;
            set => tutor = value;
        }
        public string Situacao
        {
            get => situacao;
            set => situacao = value;
        }
    }
}
