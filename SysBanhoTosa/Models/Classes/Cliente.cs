using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Cliente
    {
        /// <summary>
        /// Código de identificação do cliente.
        /// </summary>
        private int intId;

        /// <summary>
        /// Nome do cliente.
        /// </summary>
        private string strNome;

        /// <summary>
        /// Telefone celular do cliente.
        /// </summary>
        private string strTelefone;

        /// <summary>
        /// Endereço do cliente.
        /// </summary>
        private Endereco objEndereco;

        /// <summary>
        /// E-mail do cliente.
        /// </summary>
        private string strEmail;

        /// <summary>
        /// Situação do cliente(ATIVO/INATIVO)
        /// </summary>
        private string strSituacao;

        /// <summary>
        /// Get e set do código de identificação do cliente.
        /// </summary>
        public int Id
        {
            get => intId;
            set => intId = value;
        }

        /// <summary>
        /// Get e set do nome do cliente.
        /// </summary>
        public string Nome
        {
            get => strNome;
            set => strNome = value;
        }

        /// <summary>
        /// Get e set do telefone celular do cliente.
        /// </summary>
        public string Telefone
        {
            get => strTelefone;
            set => strTelefone = value;
        }

        /// <summary>
        /// Get e set do endereço do cliente.
        /// </summary>
        public Endereco Endereco
        {
            get => objEndereco;
            set => objEndereco = value;
        }

        /// <summary>
        /// Get e set do e-mail do cliente.
        /// </summary>
        public string Email
        {
            get => strEmail;
            set => strEmail = value;
        }
        /// <summary>
        /// Get e Set situação do cliente.
        /// </summary>
        public string Situacao { 
            get => strSituacao; 
            set => strSituacao = value; }
    }
}
