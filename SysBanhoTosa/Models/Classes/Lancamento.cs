using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Lancamento
    {
        /// <summary>
        /// Código de identificação do lançamento.
        /// </summary>
        private int intId;

        /// <summary>
        /// CLiente do lançamento / Tutor do Pet.
        /// </summary>
        private Cliente objCliente;

        /// <summary>
        /// Pet do lançamento.
        /// </summary>
        private Pet objPet;

        /// <summary>
        /// Serviço a ser feito.
        /// </summary>
        private Servico objServico;

        /// <summary>
        /// Valor do lançamento.
        /// </summary>
        private decimal decValor;

        /// <summary>
        /// data e hora do serviço
        /// </summary>
        private DateTime dtaDataHora;

        /// <summary>
        /// Situação do lançamento
        /// </summary>
        private string strSituacao;

        /// <summary>
        /// Observação do lançamento
        /// </summary>
        private string strObservacao;

        /// <summary>
        /// Get e set do código de identificação do lançamento.
        /// </summary>
        public int Id { get => intId; set => intId = value; }

        /// <summary>
        /// Get e set do cLiente do lançamento / Tutor do Pet.
        /// </summary>
        public Cliente Cliente { get => objCliente; set => objCliente = value; }

        /// <summary>
        /// Get e set do pet.
        /// </summary>
        public Pet Pet { get => objPet; set => objPet = value; }

        /// <summary>
        /// Get e set do serviço prestado.
        /// </summary>
        public Servico Servico { get => objServico; set => objServico = value; }

        /// <summary>
        /// Get e Set do valor do lançamento.
        /// </summary>
        public decimal Valor { get => decValor; set => decValor = value ; }

        /// <summary>
        /// Get e set da data e hora do agendamento ou prestação.
        /// </summary>
        public DateTime DataHora { get => dtaDataHora; set => dtaDataHora = value; }
        
        /// <summary>
        /// Get e set da situação do lançamento.
        /// </summary>
        public string Situacao { get => strSituacao; set => strSituacao = value; }

        /// <summary>
        /// Get e set da situação da observação.
        /// </summary>
        public string Observacao { get => strObservacao; set => strObservacao = value; }

    }
}
