using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Endereco
    {
        /// <summary>
        /// Logradouro/rua do endereço.
        /// </summary>
        private string strLogradouro;

        /// <summary>
        /// Número do endereço no logradouro.
        /// </summary>
        private string strNumero;

        /// <summary>
        /// Bairro do endereço.
        /// </summary>
        private string strBairro;
        /// <summary>
        /// Complemento do endereço.
        /// </summary>
        private string strComplemento;

        /// <summary>
        /// Cidade onde fica o endereço.
        /// </summary>
        private string strCidade;

        /// <summary>
        /// Estado onde fica a cidade.
        /// </summary>
        private string strUf;

        /// <summary>
        /// CEP do endereço.
        /// </summary>
        private string strCep;

        /// <summary>
        /// Get e set do logradouro.
        /// </summary>
        public string Logradouro
        {
            get => strLogradouro;
            set => strLogradouro = value;
        }

        /// <summary>
        /// Get e set do número do endereço.
        /// </summary>
        public string Numero
        {
            get => strNumero;
            set => strNumero = value;
        }

        /// <summary>
        /// Get e set do bairro.
        /// </summary>
        public string Bairro
        {
            get => strBairro;
            set => strBairro = value;
        }

        /// <summary>
        /// Get e set do complemento do endereço.
        /// </summary>
        public string Complemento
        {
            get => strComplemento;
            set => strComplemento = value;
        }

        /// <summary>
        /// Get e set da cidade.
        /// </summary>
        public string Cidade
        {
            get => strCidade;
            set => strCidade = value;
        }

        /// <summary>
        /// Get e set do estado.
        /// </summary>
        public string Uf
        {
            get => strUf;
            set => strUf = value;
        }

        /// <summary>
        /// Get e set do CEP do endereço.
        /// </summary>
        public string Cep
        {
            get => strCep;
            set => strCep = value;
        }

    }
}
