using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Endereco
    {
        private string logradouro;
        private string numero;
        private string bairro;
        private string complemento;
        private string cidade;
        private string uf;
        private string cep;

        public string Logradouro
        {
            get => logradouro;
            set => logradouro = value;
        }
        public string Numero
        {
            get => numero;
            set => numero = value;
        }
        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }
        public string Complemento
        {
            get => complemento;
            set => complemento = value;
        }
        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }
        public string Uf
        {
            get => uf;
            set => uf = value;
        }
        public string Cep
        {
            get => cep;
            set => cep = value;
        }

    }
}
