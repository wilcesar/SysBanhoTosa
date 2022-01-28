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

        /// <summary>
        /// Faz a comunicação com o arquivo de texto.
        /// </summary>
        LancamentoServicosDAO objLancamentoServicosDAO = new LancamentoServicosDAO();
       
        /// <summary>
        /// Realiza o lançamento ou atualização do serviço prestado.
        /// </summary>
        /// <param name="pLancamento">Lançamento passado para ser salvo.</param>
        /// <param name="pListLancamentos">Lista de lançamentos vinda da grid.</param>
        public void AtualizarLancamento(Lancamento pLancamento,List<Lancamento> pListLancamentos)
        {
            if (pLancamento.Id == 0)
            {
                pListLancamentos.Add(pLancamento);
            }
            else
            {
                for (int intI = 0; intI <= pListLancamentos.Count; intI++)
                {
                    if (pListLancamentos[intI].Id == pLancamento.Id)
                    {
                        pListLancamentos[intI] = pLancamento;
                        break;
                    }
                }
            }
            int intContador = 1;
            objLancamentoServicosDAO.LimparArquivoLancamentos();
            foreach (Lancamento objLancamento in pListLancamentos)
            {
                string strLancamento = intContador.ToString() + SEPARADOR +
                objLancamento.Cliente.Id + SEPARADOR +
                objLancamento.Pet.Id + SEPARADOR +
                objLancamento.Servico.Id + SEPARADOR +
                objLancamento.Valor + SEPARADOR +
                objLancamento.DataHora + SEPARADOR +
                objLancamento.Situacao + SEPARADOR +
                objLancamento.Observacao+SEPARADOR;
                ;

                objLancamentoServicosDAO.AdicionarLinhaLancamento(strLancamento,"");

                intContador++;
            }
        }
        /// <summary>
        /// Valida se os campos foram preenchidos corretamente.
        /// </summary>
        /// <param name="pLancamento">Lançamento a ser validado.</param>
        /// <returns>true caso os campos foram preenchidos corretamente.</returns>
        public bool ValidaLancamento(Lancamento pLancamento)
        {
            if ((pLancamento.Cliente == null) || (pLancamento.Pet == null) || (pLancamento.Servico == null))
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
                pLancamento.DataHora+SEPARADOR+
                pLancamento.Observacao + SEPARADOR;
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
                objLancamento.Situacao = strArrayArquivo[6];
                objLancamento.Observacao = strArrayArquivo[7];
                lstLancamentos.Add(objLancamento);
            }

            return lstLancamentos;
        }
        /// <summary>
        /// Impressão do serviço a ser feito.
        /// </summary>
        /// <param name="pLancamento">Lançamento que será executado.</param>
        public void ImprimirLancamento(Lancamento pLancamento)
        {
            string strNomeArquivo = "\\Lancamento" + pLancamento.Id;
            objLancamentoServicosDAO.AdicionarLinhaLancamento("PETSHOP BICHO DO MATO                                          Nº"+pLancamento.Id,strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("", strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("", strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("", strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("       Tutor: "+pLancamento.Cliente.Id+"-"+pLancamento.Cliente.Nome, strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("         Pet: "+pLancamento.Pet.Nome, strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("Espécie/Raça: "+ pLancamento.Pet.Especie+"/"+pLancamento.Pet.Raca, strNomeArquivo);

            objLancamentoServicosDAO.AdicionarLinhaLancamento("", strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("", strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("", strNomeArquivo);

            objLancamentoServicosDAO.AdicionarLinhaLancamento("        Data:"+ pLancamento.DataHora, strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("     Serviço:" + pLancamento.Servico.Nome, strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("    Valor R$:" + pLancamento.Valor, strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("Serv Detalhe:" + pLancamento.Servico.Descricao, strNomeArquivo);
            objLancamentoServicosDAO.AdicionarLinhaLancamento("  Observação:" + pLancamento.Observacao, strNomeArquivo);

        }
    }
}
