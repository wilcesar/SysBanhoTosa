using SysBanhoTosa.Models;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysBanhoTosa.Controllers
{
    class ServicoController
    {
        /// <summary>
        /// Separador dos campos vindos do arquivo de texto.
        /// </summary>
        const string SEPARADOR = "|";

        /// <summary>
        /// Objeto de acesso a dados de serviço.
        /// </summary>
        ServicoDAO objServicoDAO = new ServicoDAO();

        /// <summary>
        /// Valida se o cadastro do serviço foi alimentado corretamente.
        /// </summary>
        /// <param name="pServico">Objeto contendo o serviço.</param>
        /// <returns>True se os campos obrigatórios foram preenchidos corretamente.</returns>
        public Boolean ValidaServico(Servico pServico)
        {
            if (pServico.Nome == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Gera a linha para ser salva no arquivo texto.
        /// </summary>
        /// <param name="pServico">Objeto contendo o serviço.</param>
        /// <returns>Linha pronta para ser salva.</returns>
        private string GetLinhaObj(Servico pServico)
        {
            return pServico.Id + SEPARADOR +
                pServico.Nome + SEPARADOR +
                pServico.Descricao + SEPARADOR;
        }

        /// <summary>
        /// Gera lista dos serviços que tem no arquivo texto.
        /// </summary>
        /// <param name="pSomenteAtivos"> Se true trás somente os ativos.</param>
        /// <returns>Lista de objetos contendo os serviços.</returns>
        public List<Servico> GetServicos(bool pSomenteAtivos)
        {
            List<Servico> lstServicos = new List<Servico>();
            var objServicosArquivo = objServicoDAO.GetServicos();
            foreach (string strLinha in objServicosArquivo)
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if ((pSomenteAtivos && (strArrayArquivo[4] == "ATIVO")) || !pSomenteAtivos)
                {
                    Servico objServico = new Servico();
                    objServico.Id = int.Parse(strArrayArquivo[0]);
                    objServico.Nome = strArrayArquivo[1];
                    objServico.Descricao = strArrayArquivo[2];
                    objServico.Valor = decimal.Parse(strArrayArquivo[3]);
                    objServico.Situacao = strArrayArquivo[4];

                    lstServicos.Add(objServico);
                }           
            }
            return lstServicos;
        }

        /// <summary>
        /// Atualiza a lista de serviços e cadastra o serviço novo.
        /// </summary>
        /// <param name="pServico">Objeto com o novo serviço.</param>
        /// <param name="pListServicos">Lista de serviços desatualizada.</param>
        public void AtualizarServico(Servico pServico, List<Servico> pListServicos)
        {
            if (pServico.Id == 0)
            {
                pListServicos.Add(pServico);
            }
            else
            {
                for (int intI = 0; intI <= pListServicos.Count; intI++)
                {
                    if (pListServicos[intI].Id == pServico.Id)
                    {
                        pListServicos[intI] = pServico;
                        break;
                    }
                }
            }
            int intContador = 1;
            objServicoDAO.LimparArquivoServicos();
            foreach (Servico objServico in pListServicos)
            {
                string strServico = intContador.ToString() + SEPARADOR +
                objServico.Nome + SEPARADOR +
                objServico.Descricao + SEPARADOR +
                objServico.Valor + SEPARADOR +
                objServico.Situacao + SEPARADOR;

                objServicoDAO.AdicionarLinhaServico(strServico);

                intContador++;
            }
        }

        /// <summary>
        /// Retorna determinado serviço a partir do código.
        /// </summary>
        /// <param name="pId">Código do serviço.</param>
        /// <returns>Objeto contendo o serviço.</returns>
        public Servico GeServicoById(int pId)
        {
            Servico objServico = new Servico();
            var objServicosArquivo = objServicoDAO.GetServicos();
            foreach (string strLinha in objServicosArquivo)
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if (pId == int.Parse(strArrayArquivo[0]))
                {

                    objServico.Id = int.Parse(strArrayArquivo[0]);
                    objServico.Nome = strArrayArquivo[1];
                    objServico.Descricao = strArrayArquivo[2];
                    objServico.Valor = decimal.Parse(strArrayArquivo[3]);
                    objServico.Situacao = strArrayArquivo[4];
                    break;
                }
            }
            return objServico;
        }
    }
}
