using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Models.Classes
{
    class Pet
    {
        /// <summary>
        /// Código de identificação do pet.
        /// </summary>
        private int intId;

        /// <summary>
        /// Nome do pet.
        /// </summary>
        private string strNome;

        /// <summary>
        /// Espécie do pet.
        /// </summary>
        private string strEspecie;

        /// <summary>
        /// Raça do pet.
        /// </summary>
        private string strRaca;

        /// <summary>
        /// Cliente/Tutor do pet.
        /// </summary>
        private Cliente objTutor;

        /// <summary>
        /// Situação cadastral do pet(ATIVO/INATIVO).
        /// </summary>
        private string strSituacao;

        /// <summary>
        /// Get e set do código de identificação do pet.
        /// </summary>
        public int Id
        {
            get => intId;
            set => intId = value;
        }

        /// <summary>
        /// Get e set do nome do pet.
        /// </summary>
        public string Nome
        {
            get => strNome;
            set => strNome = value;
        }

        /// <summary>
        /// Get e set da espécie do pet.
        /// </summary>
        public string Especie
        {
            get => strEspecie;
            set => strEspecie = value;
        }

        /// <summary>
        /// Get e set da raça do pet.
        /// </summary>
        public string Raca
        {
            get => strRaca;
            set => strRaca = value;
        }

        /// <summary>
        /// Get e set do tutor do pet / cliente.
        /// </summary>
        public Cliente Tutor
        {
            get => objTutor;
            set => objTutor = value;
        }

        /// <summary>
        /// Get e set da situação cadastral.
        /// </summary>
        public string Situacao
        {
            get => strSituacao;
            set => strSituacao = value;
        }
    }
}
