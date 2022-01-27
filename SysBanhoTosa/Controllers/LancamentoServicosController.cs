using SysBanhoTosa.Models;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Controllers
{
    class LancamentoServicosController
    {
        /// <summary>
        /// Separador dos campos vindos do arquivo de texto.
        /// </summary>
        const string SEPARADOR = "|";        

        /// <summary>
        /// Controller de clientes.
        /// </summary>
        ClienteController objClienteController = new ClienteController();

        /// <summary>
        /// Controller de serviços.
        /// </summary>
        ServicoController objServicoController = new ServicoController();

        /// <summary>
        /// Controller de pets.
        /// </summary>
        PetController objPetController = new PetController();

        LancamentoServicosDAO objLancamentoServicosDAO = new LancamentoServicosDAO();

        /// <summary>
        /// Realiza o lançamento do serviço prestado.
        /// </summary>
        /// <param name="pLancamento">Lançamento passado para ser salvo</param>
        public void SalvarLancamento(Lancamento pLancamento)
        {
                
        }
        /// <summary>
        /// Valida se os campos foram preenchidos corretamente.
        /// </summary>
        /// <param name="pLancamento">Lançamento a ser validado</param>
        /// <returns>true caso os campos foram preenchidos corretamente</returns>
        public Boolean ValidaLancamento(Lancamento pLancamento)
        {
            if ((pLancamento.Cliente != null) || (pLancamento.Pet != null) || (pLancamento.Servico != null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Transforma o objeto em uma linha para o arquivo.
        /// </summary>
        /// <param name="pLancamento">Objeto com o lançamento.</param>
        /// <returns>Retorna uma linha para ser inserida no arquivo texto.</returns>
        private string GetLinhaObj(Lancamento pLancamento)
        {
            return pLancamento.Id + SEPARADOR +
                pLancamento.Cliente.Id + SEPARADOR +
                pLancamento.Pet.Id + SEPARADOR +
                pLancamento.Servico.Id + SEPARADOR +
                pLancamento.Valor+ SEPARADOR +
                pLancamento.DataHora+SEPARADOR;
        }
        /// <summary>
        /// Busca os lancamentos do arquivo texto.
        /// </summary>
        /// <returns>Retorna uma lista com os lançamentos.</returns>
        public List<Lancamento> GetLancamentos()
        {
            List<Lancamento> lstLancamentos = new List<Lancamento>();

            foreach (string strLinha in objLancamentoServicosDAO.GetLancamentos()) 
            {
                string[] strArrayArquivo = strLinha.Split('|');

                Lancamento objLancamento = new Lancamento();
                objLancamento.Id = int.Parse(strArrayArquivo[0]);
                objLancamento.Cliente = objClienteController.GetClienteById(int.Parse(strArrayArquivo[1]));
                objLancamento.Pet = objPetController.GetPetById(int.Parse(strArrayArquivo[2]));
                objLancamento.Servico = objServicoController.GeServicoById(int.Parse(strArrayArquivo[3]));
                objLancamento.Valor = float.Parse(strArrayArquivo[4]);
                objLancamento.DataHora = DateTime.Parse(strArrayArquivo[5]);

                lstLancamentos.Add(objLancamento);
            }

            return lstLancamentos;
        }
    }
}
