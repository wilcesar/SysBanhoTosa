using SysBanhoTosa.Models;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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
            if ((pLancamento.Cliente == null) || (pLancamento.Pet == null) || (pLancamento.Servico == null) || (pLancamento.Situacao == ""))
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
            var objServicosArquivo = objLancamentoServicosDAO.GetLancamentos();
            foreach (string strLinha in objServicosArquivo) 
            {
                string[] strArrayArquivo = strLinha.Split('|');

                Lancamento objLancamento = new Lancamento();
                objLancamento.Id = int.Parse(strArrayArquivo[0]);
                objLancamento.Cliente = objClienteController.GetClienteById(int.Parse(strArrayArquivo[1]));
                objLancamento.Pet = objPetController.GetPetById(int.Parse(strArrayArquivo[2]));
                objLancamento.Servico = objServicoController.GeServicoById(int.Parse(strArrayArquivo[3]));
                objLancamento.Valor = decimal.Parse(strArrayArquivo[4]);
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
            string strNomeArquivo = "\\Lancamento" + pLancamento.Id + ".txt";
            File.WriteAllText($"{Directory.GetCurrentDirectory()}{strNomeArquivo}", $@"PETSHOP BICHO DO MATO                                          Nº{pLancamento.Id}

            Situacao: {pLancamento.Situacao}


                   Tutor: { pLancamento.Cliente.Id} - { pLancamento.Cliente.Nome}
                     Pet: { pLancamento.Pet.Id} - { pLancamento.Pet.Nome}
            Espécie/Raça:{pLancamento.Pet.Especie} / {pLancamento.Pet.Raca}



                    Data:{pLancamento.DataHora}
                 Serviço:{pLancamento.Servico.Nome}
                Valor R$:{pLancamento.Valor}
            Serv Detalhe:{pLancamento.Servico.Descricao}
              Observação: {pLancamento.Observacao}");


            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + strNomeArquivo);



        }
        /// <summary>
        /// Retorna o texto com os espaços necessários para ficar alinhado.
        /// </summary>
        /// <param name="pTexto">Texto a ser impresso.</param>
        /// <param name="pEspaco">Tamanho que deve ter o texto.</param>
        /// <returns>String formatada com os espaços a direita.</returns>
        private string ImprimirComEspacos(string pTexto, int pEspaco)
        {
            int intTamanhoEspaco = pEspaco-pTexto.Length;
            string strEspacos = new String(' ', intTamanhoEspaco);
            return pTexto + strEspacos;
        }
        /// <summary>
        /// Imprimir relatório de lançamentos.
        /// </summary>
        public void ImprimirRelatorioLancamentos()
        {
            string strNomeArquivo = "\\RelatorioLancamentos.txt";
            var lstLancamentos = GetLancamentos();
            
            StringBuilder stbRelatorio = new StringBuilder();
            stbRelatorio.AppendLine(ImprimirComEspacos("CÓDIGO", 9)+ 
                ImprimirComEspacos("CLIENTE",50) +
                ImprimirComEspacos("PET",30) +
                ImprimirComEspacos("VALOR", 10) +
                "SITUAÇÃO");
                
            foreach (Lancamento objLancamento in lstLancamentos)
            {
                stbRelatorio.AppendLine(ImprimirComEspacos(objLancamento.Id.ToString(),9) +
                    ImprimirComEspacos(objLancamento.Cliente.Nome,50)  +
                    ImprimirComEspacos(objLancamento.Pet.Nome, 30)  +
                    ImprimirComEspacos(objLancamento.Valor.ToString(),10)+
                    objLancamento.Situacao);
            }
            File.WriteAllText($"{Directory.GetCurrentDirectory()}{strNomeArquivo}", stbRelatorio.ToString());
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + strNomeArquivo);
        }
    }
}
