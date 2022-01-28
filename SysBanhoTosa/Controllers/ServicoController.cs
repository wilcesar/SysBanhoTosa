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
        const string SEPARADOR = "|";
        ServicoDAO objServicoDAO = new ServicoDAO();
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
        private string GetLinhaObj(Servico pServico)
        {
            return pServico.Id + SEPARADOR +
                pServico.Nome + SEPARADOR +
                pServico.Descricao + SEPARADOR;
        }
        public List<Servico> GetServicos()
        {
            List<Servico> lstServicos = new List<Servico>();

            foreach (string strLinha in objServicoDAO.GetServicos())
            {
                string[] strArrayArquivo = strLinha.Split('|');

                Servico objServico = new Servico();
                objServico.Id = int.Parse(strArrayArquivo[0]);
                objServico.Nome = strArrayArquivo[1];
                objServico.Descricao = strArrayArquivo[2];
                objServico.Valor = float.Parse(strArrayArquivo[3]);
                objServico.Situacao = strArrayArquivo[4];

                lstServicos.Add(objServico);                
            }
            return lstServicos;
        }
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
        public Servico GeServicoById(int pId)
        {
            Servico objServico = new Servico();
            foreach (string strLinha in objServicoDAO.GetServicos())
            {
                string[] strArrayArquivo = strLinha.Split('|');
                if (pId == int.Parse(strArrayArquivo[0]))
                {

                    objServico.Id = int.Parse(strArrayArquivo[0]);
                    objServico.Nome = strArrayArquivo[1];
                    objServico.Descricao = strArrayArquivo[2];
                    objServico.Valor = float.Parse(strArrayArquivo[3]);
                    objServico.Situacao = strArrayArquivo[4];
                    break;
                }
            }
            return objServico;
        }
    }
}
