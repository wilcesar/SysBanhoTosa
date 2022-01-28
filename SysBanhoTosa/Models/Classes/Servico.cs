using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Servico
    {
        /// <summary>
        /// Código de identificação do serviço.
        /// </summary>
        private int intId;

        /// <summary>
        /// Nome do serviço.
        /// </summary>
        private string strNome;

        /// <summary>
        /// Descrição detalhada do serviço.
        /// </summary>
        private string strDescricao;

        /// <summary>
        /// Valor do serviço.
        /// </summary>
        private float fltValor;

        /// <summary>
        /// Situação cadastral do serviço(ATIVO/INATIVO).
        /// </summary>
        private string strSituacao;

        /// <summary>
        /// Get e set da indentificação do serviço.
        /// </summary>
        public int Id
        {
            get => intId;
            set => intId = value;
        }

        /// <summary>
        /// Get e set do nome do serviço.
        /// </summary>
        public string Nome
        {
            get => strNome;
            set => strNome = value;
        }

        /// <summary>
        /// Get e set da descrição detalhada do serviço.
        /// </summary>
        public string Descricao
        {
            get => strDescricao;
            set => strDescricao = value;
        }

        /// <summary>
        /// Get e set do valor do serviço.
        /// </summary>
        public float Valor { 
            get => fltValor; 
            set => fltValor = value; 
        }

        /// <summary>
        /// Get e set da situação do serviço.
        /// </summary>
        public string Situacao
        {
            get => strSituacao;
            set => strSituacao = value;
        }
    }
}
